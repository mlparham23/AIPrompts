using System;
using System.Collections.Generic;
using System.Data;
using AIPrompts.Models;
using Microsoft.Data.SqlClient;
using AIPrompts.Forms;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AIPrompts
{
    internal class DBInOut
    {
        #region Class Variables
        private readonly string connectionString    = "Data Source=MParham\\SQLEXPRESS;Initial Catalog=Parham;Encrypt=False;Integrated Security=True";
        string                  message             = "";
        #endregion

        //public DBInOut()
        //{

        //}

        #region GPT

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ChatCategoryClass> chatGetAllCategory()
        {
            //  Variables
            List<ChatCategoryClass> chatCategories = new List<ChatCategoryClass>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Categories  Order by CategoryName";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ChatCategoryClass cat = new ChatCategoryClass();
                                {
                                    cat.categoryID = reader.GetInt32(reader.GetOrdinal("CategoryID"));
                                    cat.category = reader.GetString(reader.GetOrdinal("CategoryName"));
                                }
                                chatCategories.Add(cat);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load GPT categories.";
                ShowMsgBox("DB Get GPT Categories - Failed", message, (int)_icon.Error, "OK", "","","","","", ex.ToString());
            }

            return chatCategories;
        }

        /// <summary>
        /// Get all GPTs in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ChatGPTClass> getChatGPT()
        {
            //  Variables
            List<ChatGPTClass> chatGPTs = new List<ChatGPTClass>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT GPTID, VersionName FROM GPT ORDER BY VersionName";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    { 
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ChatGPTClass gpt = new ChatGPTClass
                                {
                                    GPTID = reader.GetInt32(reader.GetOrdinal("GPTID")),
                                    versionName = reader.GetString(reader.GetOrdinal("VersionName"))
                                };
                                chatGPTs.Add(gpt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load GPT list from Database.";
                ShowMsgBox("DB Get GPT List - Failed", message, (int)_icon.Error, "OK", "", "","","","", ex.ToString());
            }

            return chatGPTs;
        }

        /// <summary>
        /// Rename GPT Prompt
        /// </summary>
        /// <param name="cat"></param>
        /// <param name="newCat"></param>
        public void renGPTPrompt(ChatCategoryClass cat, string newCat)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    connection.Open();
                    string query = "UPDATE Categories SET CategoryName = @newCat WHERE CategoryID = @catID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newCat", newCat);
                        command.Parameters.AddWithValue("@catID", cat.categoryID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            message = "Renamed GPT category successful.\r\n\r\n";
                            message += "From: " + cat.category + "\r\n";
                            message += "To: " + newCat;
                            ShowMsgBox("DB Rename GPT Category", message, (int)_icon.Information, "OK");
                        } 
                        else
                        {
                            message = "Failed to rename GPT category.\r\n\r\n";
                            message += "From: " + cat.category + "\r\n";
                            message += "To: " + newCat;
                            ShowMsgBox("DB Rename GPT Category", message, (int)_icon.Information, "OK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Failed to rename GPT category.\r\n\r\n";
                message += "From:  " + cat.category + "\r\n";
                message += "To:    " + newCat;
                ShowMsgBox("DB Rename GPT Category - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }
        }

        /// <summary>
        /// Post GPT Prompt
        /// </summary>
        public void addGPTPrompt(ChatGPTPrompt gPTPrompt)
        {
            //  Variables
               string  sql         = "";

            try
            {
                sql = "INSERT INTO GPTPrompt (Ranking, Category1, Category2, Category3, PromptTitle, Prompt, GPTVersion, NSFW) " +
                    "VALUES (@Ranking, @Category1, @Category2, @Category3, @PromptTitle, @Prompt, @GPTVersion, @NSFW)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Ranking",     gPTPrompt.Rank);
                    command.Parameters.AddWithValue("@Category1",   gPTPrompt.Category1);
                    command.Parameters.AddWithValue("@Category2",   gPTPrompt.Category2);
                    command.Parameters.AddWithValue("@Category3",   gPTPrompt.Category3);
                    command.Parameters.AddWithValue("@PromptTitle", gPTPrompt.PromptTitle);
                    command.Parameters.AddWithValue("@Prompt",      gPTPrompt.Prompt);
                    command.Parameters.AddWithValue("@GPTVersion",  gPTPrompt.GPTVersion);
                    command.Parameters.AddWithValue("@NSFW",        gPTPrompt.NSFW);

                    //  Open cponnection
                    connection.Open();

                    //  Execute
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if rows were affected
                    if (rowsAffected > 0)
                    {
                        message                 = "Added GPT prpmpt successfully.\r\n\r\n";
                        message                 += "Prompt Title: " + gPTPrompt.PromptTitle;
                        ShowMsgBox("DB Add GPT Prompt", message, (int)_icon.Information, "OK");
                    }
                    else
                    {
                        message = "Failed to add GPT prpmpt.\r\n\r\n";
                        message += "Prompt Title:  " + gPTPrompt.PromptTitle + "\r\n";
                        message += "GPT Version:   " + gPTPrompt.GPTVersion + "\r\n";
                        message += "NSFW:          " + gPTPrompt.NSFW + "\r\n";
                        message += "Category 1:    " + gPTPrompt.Category1 + "\r\n";
                        message += "Category 2:    " + gPTPrompt.Category2 + "\r\n";
                        message += "Category 3:    " + gPTPrompt.Category3 + "\r\n";
                        message += "Rank:          " + gPTPrompt.Rank + "\r\n";
                        message += "Prompt:        " + gPTPrompt.Prompt + "\r\n";
                        ShowMsgBox("DB Add GPT Prompt - Failed", message, (int)_icon.Error, "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Failed to add GPT prpmpt.\r\n\r\n";
                message += "Prompt Title:  " + gPTPrompt.PromptTitle + "\r\n";
                message += "GPT Version:   " + gPTPrompt.GPTVersion + "\r\n";
                message += "NSFW:          " + gPTPrompt.NSFW + "\r\n";
                message += "Category 1:    " + gPTPrompt.Category1 + "\r\n";
                message += "Category 2:    " + gPTPrompt.Category2 + "\r\n";
                message += "Category 3:    " + gPTPrompt.Category3 + "\r\n";
                message += "Rank:          " + gPTPrompt.Rank + "\r\n";
                message += "Prompt:        " + gPTPrompt.Prompt + "\r\n";
                ShowMsgBox("DB Add GPT Prompt - Failed", message, (int)_icon.Error, "OK","", "","","","",ex.ToString());
            }
        }

        /// <summary>
        /// Add GPT Category
        /// </summary>
        /// <param name="addCategory"></param>
        public void addGPTCategory(string addCategory)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Categories (Name) VALUES (@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", addCategory);
                        // Add other parameters for additional properties

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            message = "Added GPT category successfully.\r\n\r\n";
                            message += "Category: " + addCategory;
                            ShowMsgBox("DB Add GPT Category", message, (int)_icon.Information, "OK");
                        }
                        else
                        {
                            message = "Failed to add GPT category.\r\n\r\n";
                            message += "Category: " + addCategory;
                            ShowMsgBox("DB Add GPT Category", message, (int)_icon.Information, "OK");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                message = "Failed to add GPT category.\r\n\r\n";
                message += "Category:  " + addCategory;
                ShowMsgBox("DB Add GPT Category - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }
        }

        /// <summary>
        /// Delete GPT Category
        /// </summary>
        /// <param name="cat"></param>
        public void delGPTCategory(ChatCategoryClass cat)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    connection.Open();
                    string query = "DELETE FROM Categories WHERE CategoryID = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    { 
                        command.Parameters.AddWithValue("@Id", cat.categoryID);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "Deleted GPT category successfully.\r\n\r\n";
                            message += "Category: " + cat.category;
                            ShowMsgBox("DB Delete GPT Category", message, (int)_icon.Information, "OK");
                        }
                        else
                        {
                            message = "Failed to delete GPT category.\r\n\r\n";
                            message += "Category: " + cat.category;
                            ShowMsgBox("DB Delete GPT Category", message, (int)_icon.Information, "OK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Failed to delete GPT category.\r\n\r\n";
                message += "Category ID: " + cat.categoryID + "\r\n";
                message += "Category:    " + cat.category;
                ShowMsgBox("DB Delete GPT Category - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }
        }

        #endregion
        #region AI Image

        /// <summary>
        /// Check for duplicate AI Image Prompt before posting
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public string checkAIImagePromptExists(ImagePrompt prompt)
        {
            string result = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM AIImagePrompts WHERE Prompt = @Prompt";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Prompt", prompt.prompt);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    result = "Error: Already Exists";
                }
                else
                {
                    result = "Good to Proceed";
                }
                
                connection.Close();
                return result;
            }
        }            

        /// <summary>
        /// Post AI Image Prompt
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public int AddAIImagePrompt(ImagePrompt prompt)
        {
            int primeKey = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    string query = $"INSERT INTO AIImagePrompts (PromptTitle, Prompt, NegativePrompt, Notes, Rating) VALUES (@promptTitle, @prompt, @negativePrompt, @notes, @rating)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@promptTitle",     prompt.promptTitle);
                        command.Parameters.AddWithValue("@prompt",          prompt.prompt);
                        command.Parameters.AddWithValue("@negativePrompt",  prompt.negativePrompt);
                        command.Parameters.AddWithValue("@notes",           prompt.notes);
                        command.Parameters.AddWithValue("@rating",          prompt.rating);

                        connection.Open();
                        primeKey = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();

                        query = @"SELECT PromptID FROM AIImagePrompts WHERE PromptTitle = @PromptTitle AND Rating = @Rating AND Prompt = @Prompt";
                        SqlCommand command1 = new SqlCommand(query, connection);
                        command1.Parameters.AddWithValue("@PromptTitle",    prompt.promptTitle);
                        command1.Parameters.AddWithValue("@Rating",         prompt.rating);
                        command1.Parameters.AddWithValue("@Prompt",         prompt.prompt);
                        connection.Open();
                        var result = command1.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            primeKey = Convert.ToInt32(result);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                message = "Failed to add AI Image prompt.\r\n\r\n";
                message += "Prompt Title:  " + prompt.promptTitle;
                ShowMsgBox("DB Add GPT Prompt - Failed", message, (int)_icon.Error, "OK", "","","","","", ex.Message.ToString());
            }

            return primeKey;
        }

        /// <summary>
        /// Add to CategoryBridge during add Prompt
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="cat"></param>
        public void addAIImageCategory(int prompt, List<int> cat)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO AIImageCategoryBridge (PromptID, CatID) VALUES (@PromptID, @CatID)", connection))
                {
                    command.Parameters.Add("@PromptID", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@CatID",    System.Data.SqlDbType.Int);

                    foreach (var item in cat)
                    {
                        command.Parameters["@PromptID"].Value   = prompt;
                        command.Parameters["@CatID"].Value      = item;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            message = "Failed to add to Category Bridge.\r\n\r\n";
                            message += "Category:  " + item.ToString();
                            ShowMsgBox("DB Add Category  - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add to Style Bridge during add image prompt
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="styles"></param>
        public void addAIImageStyle(int prompt, List<int> styles)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO AIImageStyleBridge (StyleID, PromptID) VALUES (@StyleID, @PromptID)", connection))
                {
                    command.Parameters.Add("@StyleID", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@PromptID", System.Data.SqlDbType.Int);

                    foreach (var item in styles)
                    {
                        command.Parameters["@StyleID"].Value = item;
                        command.Parameters["@PromptID"].Value = prompt;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            message = "Failed to add to Style Table.\r\n\r\n";
                            message += "Style:  " + item.ToString();
                            ShowMsgBox("DB Add Style Name  - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add to Lora Bridge during add image prompt
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="l"></param>
        public void addAIImageLora(int prompt, List<int> l)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO AIImageLoraBridge (PromptID, LoraID) VALUES (@PromptID, @LoraID)", connection))
                {
                    command.Parameters.Add("@PromptID", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@LoraID", System.Data.SqlDbType.Int);

                    foreach (var item in l)
                    {
                        command.Parameters["@PromptID"].Value = prompt;
                        command.Parameters["@LoraID"].Value = item;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            message = "Failed to add to Lora Bridge.\r\n\r\n";
                            message += "Category:  " + item.ToString();
                            ShowMsgBox("DB Add Lora Bridge  - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add to Model Bridge during add image prompt
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="m"></param>
        public void addAIImageModel(int prompt, List<int> m)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO AIImageModelBridge (PromptID, ModelID) VALUES (@PromptID, @ModelID)", connection))
                {
                    command.Parameters.Add("@PromptID", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@ModelID",  System.Data.SqlDbType.Int);

                    foreach (var item in m)
                    {
                        command.Parameters["@PromptID"].Value   = prompt;
                        command.Parameters["@ModelID"].Value    = item;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            message = "Failed to add to Model Bridge.\r\n\r\n";
                            message += "Category:  " + item.ToString();
                            ShowMsgBox("DB Add Model Bridge  - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
                        }
                    }
                }
            }
        }

        public void addAIImageSite(int PromptID, ImagePrompt prompt, List<int> s)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO AIImageSiteBridge (SiteID, PromptID, Rank, Note) VALUES (@SiteID, @PromptID, @Rank, @Note)", connection))
                {
                    command.Parameters.Add("@SiteID", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@PromptID", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@Rank", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@Note", System.Data.SqlDbType.VarChar);

                    foreach (var item in s)
                    {
                        command.Parameters["@SiteID"].Value = item;
                        command.Parameters["@PromptID"].Value = PromptID;
                        command.Parameters["@Rank"].Value = prompt.rating;
                        command.Parameters["@Note"].Value = prompt.notes;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            message = "Failed to add to Site Bridge.\r\n\r\n";
                            message += "Site:  " + item.ToString();
                            ShowMsgBox("DB Add Site Bridge  - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add AI Image Settings
        /// </summary>
        /// <param name="promptID"></param>
        /// <param name="settings"></param>
        public void AddAISettings(int promptID, ImageSettings settings)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO AIImageSettings (Seed, CFGScale, ImageAspectRatio, PromptID, Steps, Scheduler, SamplingMethod, Tags, DPMSolverGuidanceScale, DPMSolverInterferenceSteps, SASolverGuidanceScale, SASolverInterferenceSteps) " +
                                                            "VALUES (@Seed, @CFGScale, @ImageAspectRatio, @PromptID, @Steps, @Scheduler, @SamplingMethod, @Tags, @DPMSolverGuidanceScale, @DPMSolverInterferenceSteps, @SASolverGuidanceScale, @SASolverInterferenceSteps)", connection))
                {
                    command.Parameters.Add("@Seed",                         System.Data.SqlDbType.Int).Value           = settings.seed;
                    command.Parameters.Add("@CFGScale",                     System.Data.SqlDbType.Int).Value           = settings.CGFScale;
                    command.Parameters.Add("@ImageAspectRatio",             System.Data.SqlDbType.NVarChar, 50).Value  = settings.imageAspectRatio;
                    command.Parameters.Add("@PromptID",                     System.Data.SqlDbType.Int).Value           = promptID;
                    command.Parameters.Add("@Steps",                        System.Data.SqlDbType.Int).Value           = settings.steps;
                    command.Parameters.Add("@Scheduler",                    System.Data.SqlDbType.Int).Value           = settings.scheduler;
                    command.Parameters.Add("@SamplingMethod",               System.Data.SqlDbType.NVarChar, 50).Value  = settings.samplingMethod;
                    command.Parameters.Add("@Tags",                         System.Data.SqlDbType.NVarChar, 200).Value = settings.tags;
                    command.Parameters.Add("@DPMSolverGuidanceScale",            System.Data.SqlDbType.Int).Value           = settings.DPMSolverGuidanceScale;
                    command.Parameters.Add("@DPMSolverInterferenceSteps",   System.Data.SqlDbType.Int).Value           = settings.DPMSolverInterferenceSteps;
                    command.Parameters.Add("@SASolverGuidanceScale",        System.Data.SqlDbType.Int).Value           = settings.SASolverGuidanceScale;
                    command.Parameters.Add("@SASolverInterferenceSteps",     System.Data.SqlDbType.Int).Value           = settings.SASolverInterferenceSteps;

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error inserting settings for model:");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageLora> getAllLoras()
        {
            //  Variables
            List<ImageLora> loras = new List<ImageLora>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageLoras Order by Lora";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageLora l = new ImageLora();
                                {
                                    l.loraID        = reader.GetInt32(reader.GetOrdinal("LoraID"));
                                    l.lora          = reader.GetString(reader.GetOrdinal("Lora"));
                                    l.NSFW          = reader.GetBoolean(reader.GetOrdinal("NSFW"));
                                    l.notes         = reader.GetString(reader.GetOrdinal("Notes"));
                                    l.createDate    = reader.GetDateTime(reader.GetOrdinal("CreateDate"));
                                }
                                loras.Add(l);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Loras.";
                ShowMsgBox("DB Get AI Image Loras - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return loras;
        }

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageSite> getAllSites()
        {
            //  Variables
            List<ImageSite> sites = new List<ImageSite>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageSite Order by Name";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageSite s = new ImageSite();
                                {
                                    s.siteID        = reader.GetInt32(reader.GetOrdinal("SiteID"));
                                    s.siteName      = reader.GetString(reader.GetOrdinal("Name"));
                                    s.siteUrl       = reader.GetString(reader.GetOrdinal("URL"));
                                    s.userName      = reader.GetString(reader.GetOrdinal("UserName"));
                                    s.password      = reader.GetString(reader.GetOrdinal("Password"));
                                    s.notes         = reader.GetString(reader.GetOrdinal("Notes"));
                                    s.createdDate   = reader.GetDateTime(reader.GetOrdinal("CreateDate"));
                                    s.NSFW          = reader.GetBoolean(reader.GetOrdinal("NSFW"));
                                    s.eMail         = reader.GetString(reader.GetOrdinal("EMail"));
                                }
                                sites.Add(s);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Sites.";
                ShowMsgBox("DB Get AI Image Sites - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return sites;
        }

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageStyle> getAllStyles()
        {
            //  Variables
            List<ImageStyle> st = new List<ImageStyle>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageStyle Order by Style";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageStyle m = new ImageStyle();
                                {
                                    m.styleID       = reader.GetInt32(reader.GetOrdinal("StyleID"));
                                    m.styleName     = reader.GetString(reader.GetOrdinal("Style"));
                                    m.notes         = reader.GetString(reader.GetOrdinal("Notes"));
                                    m.createdDate   = reader.GetDateTime(reader.GetOrdinal("CreateDate"));
                                }
                                st.Add(m);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Styles.";
                ShowMsgBox("DB Get AI Image Styles - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return st;
        }

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageModel> getAllModels()
        {
            //  Variables
            List<ImageModel> models = new List<ImageModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageModel Order by Model";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageModel m = new ImageModel();
                                {
                                    m.modelID       = reader.GetInt32(reader.GetOrdinal("ModelID"));
                                    m.modelName     = reader.GetString(reader.GetOrdinal("Model"));
                                    m.notes         = reader.GetString(reader.GetOrdinal("Notes"));
                                    m.createDate    = reader.GetDateTime(reader.GetOrdinal("CreateDate"));
                                }
                                models.Add(m);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Models.";
                ShowMsgBox("DB Get AI Image Models - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return models;
        }

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageCategory> getAllCategories()
        {
            //  Variables
            List<ImageCategory> categories = new List<ImageCategory>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageCategory Order by Category";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageCategory c = new ImageCategory();
                                {
                                    c.catID         = reader.GetInt32(reader.GetOrdinal("CatID"));
                                    c.category      = reader.GetString(reader.GetOrdinal("Category"));
                                    c.createdDate   = reader.GetDateTime(reader.GetOrdinal("CreateDate"));
                                }
                                categories.Add(c);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Categories.";
                ShowMsgBox("DB Get AI Image Categories - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return categories;
        }

        /// <summary>
        /// Get all image aspect ratios in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageAspectRatio> getAllAspectRatios()
        {
            //  Variables
            List<ImageAspectRatio> aspectRatios = new List<ImageAspectRatio>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageAspectratio Order by AspectRatio";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageAspectRatio ar = new ImageAspectRatio();
                                {
                                    ar.ARID = reader.GetInt32(reader.GetOrdinal("ARID"));
                                    ar.AspectRatio = reader.GetString(reader.GetOrdinal("AspectRatio"));
                                }
                                aspectRatios.Add(ar);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Aspect Ratios.";
                ShowMsgBox("DB Get AI Image Aspect Ratios - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return aspectRatios;

        }

        /// <summary>
        /// Get all image sample methods in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ImageSampleMethod> getAllSampleMethods()
        {
            //  Variables
            List<ImageSampleMethod> sampleMethods = new List<ImageSampleMethod>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM AIImageSampleMethod Order by SampleMethod";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageSampleMethod sm = new ImageSampleMethod();
                                {
                                    sm.SampleID = reader.GetInt32(reader.GetOrdinal("SampleID"));
                                    sm.SampleMethod = reader.GetString(reader.GetOrdinal("SampleMethod"));
                                }
                                sampleMethods.Add(sm);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Failed to load AI Image Sample Methods.";
                ShowMsgBox("DB Get AI Image Sample Methods - Failed", message, (int)_icon.Error, "OK", "", "","","","",ex.ToString());
            }

            return sampleMethods;
 
        }

        #endregion

        #region Common

        /// <summary>
        /// Display Custom Message Box
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="icon"></param>
        /// <param name="buttonText1"></param>
        /// <param name="buttonText2"></param>
        /// <param name="systemMessage"></param>
        private int ShowMsgBox(string title, string message, int icon, string buttonText1, string buttonText2 = "",
                string buttontonText3 = "", string buttonText4 = "", string buttonText5 = "", string buttonText6 = "",
                string systemMessage = "")
        {
            int result = 0;

            CustMsgBox custMsgBox = new CustMsgBox
            {
                Title           = title,
                Message         = message,
                SystemMessage   = systemMessage.Trim(),
                ButtonText1     = buttonText1,
                ButtonText2     = buttonText2,
                Icon            = (int)icon
            };

            if (string.IsNullOrEmpty(custMsgBox.SystemMessage))
            {
                // Standard Message Box
                MsgBoxUser cMsgBox = new MsgBoxUser(custMsgBox);
                cMsgBox.ShowDialog();
                result = (int)cMsgBox.Result;
                return result;
            }
            else
            {
                //  System Error Message Box
                MsgBoxSystem cMsgBox = new MsgBoxSystem(custMsgBox);
                cMsgBox.ShowDialog();
                result = (int)cMsgBox.Result;
                return result;
            }
        }

        #endregion

        #region enums
        /// <summary>
        /// Enum: Icon  Custom Messagebox Icons
        /// </summary>
        public enum _icon
        {
            Information = 1,
            Warning = 2,
            Error = 3,
            Misc = 4
        }

        #endregion


    }
}
