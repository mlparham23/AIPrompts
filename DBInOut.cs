using System;
using System.Collections.Generic;
using System.Data;
using AIPrompts.Models;
using Microsoft.Data.SqlClient;
using AIPrompts.Forms;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

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
                ShowMsgBox("DB Get GPT Categories - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Get GPT List - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Rename GPT Category - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Add GPT Prompt - Failed", message, (int)_icon.Error, "OK","", ex.ToString());
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
                ShowMsgBox("DB Add GPT Category - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Delete GPT Category - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
            }
        }
        #endregion

        #region AI Image

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
                ShowMsgBox("DB Get AI Image Loras - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Get AI Image Sites - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
            }

            return sites;
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
                ShowMsgBox("DB Get AI Image Models - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Get AI Image Categories - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Get AI Image Aspect Ratios - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
                ShowMsgBox("DB Get AI Image Sample Methods - Failed", message, (int)_icon.Error, "OK", "", ex.ToString());
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
        private void ShowMsgBox(string title, string message, int icon, string buttonText1, string buttonText2 = "",  string systemMessage = "")
        {
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
            }
            else
            {
                //  System Error Message Box
                MsgBoxSystem cMsgBox = new MsgBoxSystem(custMsgBox);
                cMsgBox.ShowDialog();
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
