using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AIPrompts.Models;
using Microsoft.Data.SqlClient;

namespace AIPrompts
{
    internal class DBInOut
    {
        string connectionString = "Data Source=MParham\\SQLEXPRESS;Initial Catalog=Parham;Encrypt=False;Integrated Security=True";

        public DBInOut()
        {

        }

        #region GPT

        /// <summary>
        /// Get all Chat Categories in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ChatCategoryClass> chatGetAllCategory()
        {
            //  Variables
            List<ChatCategoryClass> _chatCategory = new List<ChatCategoryClass>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Categories  Order by CategoryName";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChatCategoryClass _tmp = new ChatCategoryClass();
                    _tmp.category = (string)reader["CategoryName"];
                    _tmp.categoryID = (int)reader["CategoryID"];

                    _chatCategory.Add(_tmp);
                }
            }
            return _chatCategory;
        }

        /// <summary>
        /// Get all GPTs in ascending order
        /// </summary>
        /// <returns></returns>
        public List<ChatGPTClass> getChatGPT()
        {
            //  Variables
            List<ChatGPTClass> _chatGPT = new List<ChatGPTClass>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "Select * from GPT Order BY VersionName";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChatGPTClass _tmp = new ChatGPTClass();
                    _tmp.GPTID = (int)reader["GPTID"];
                    _tmp.versionName = (string)reader["VersionName"];
                    _chatGPT.Add(_tmp);
                }
            }
            return _chatGPT;
        }

        /// <summary>
        /// Post GPT Prompt
        /// </summary>
        public void addGPTPrompt(ChatGPTPrompt gPTPrompt)
        {
            try
            {
                string sql = "INSERT INTO GPTPrompt (Ranking, Category1, Category2, Category3, PromptTitle, Prompt, GPTVersion, NSFW) " +
                    "VALUES (@Rank, @Category1, @Category2, @Category3, @PromptTitle, Prompt, NSFW)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Ranking", gPTPrompt.Rank);
                    command.Parameters.AddWithValue("@Category1", gPTPrompt.Category1);
                    command.Parameters.AddWithValue("@Category2", gPTPrompt.Category2);
                    command.Parameters.AddWithValue("@Category3", gPTPrompt.Category3);
                    command.Parameters.AddWithValue("@PromptTitle", gPTPrompt.PromptTitle);
                    command.Parameters.AddWithValue("@Prompt", gPTPrompt.Prompt);
                    command.Parameters.AddWithValue("@GPTVersion", gPTPrompt.GPTVersion);
                    command.Parameters.AddWithValue("@NSFW", gPTPrompt.NSFW);

                    //  Open cponnection
                    connection.Open();

                    //  Execute
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if rows were affected
                    if (rowsAffected > 0)
                    {


                    }
                    else
                    {


                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region AI Image



        #endregion

        #region Common


        #endregion



    }
}
