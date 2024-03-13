using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AIPrompts.Models;
using Microsoft.EntityFrameworkCore;

namespace AIPrompts
{
    public class SQLAccess
    {
        #region Class variables
        public string connectionString = "Data Source=MParham\\SQLEXPRESS;Initial Catalog=Parham;Encrypt=False;Integrated Security=True";
       

        #endregion  

        #region ChatGPT

        public class MyDbContext : DbContext
        {
            public DbSet<ChatGPTClass>          chatChatGPTs        { get; set; }
            public DbSet<ChatCategoryClass>     chatCategories      { get; set; }
            public DbSet<ChatGPTPrompt>         chatGPTPrompts      { get; set; }
            public DbSet<ImageSettingsClass>    imageSettings       { get; set; }
            public DbSet<ImageSiteClass>        imageSites          { get; set; }
            public DbSet<ImageStyleClass>       imageStyles         { get; set; }
            public DbSet<ImageLoraClass>        imageLoras          { get; set; }
            public DbSet<ImageModelClass>       imageModel          { get; set; }
            public DbSet<ImageCategoryClass>    imageCategory       { get; set; }
            public DbSet<ImagePromptClass>      imagePrompt         { get; set; }
            public DbSet<ImageFeatureClass>     imageFeature        { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            { 
                optionsBuilder.UseSqlServer("Data Source=MParham\\SQLEXPRESS;Initial Catalog=Parham;Encrypt=False;Integrated Security=True");
            }
        }

        /// <summary>
        /// Get all Loras in ascending order
        /// </summary>
        /// <returns></returns>
        public async Task<List<ImageLoraClass>> ImageGetAllLora()
        {
            using (var context = new MyDbContext())
            { 
                var loraSet = context.imageLoras;
                var query = from l in loraSet   
                            orderby l.lora ascending
                            select l;
                var results = query.ToList();

                return results;
            }
        }

        /// <summary>
        /// Get all Chat Categories
        /// </summary>
        /// <returns></returns>
        public async Task<List<ChatCategoryClass>> chatGetAllCategory()
        {
            using (var context = new MyDbContext())
            {
                var catSet = context.chatCategories;
                var query = from c in catSet
                            orderby c.category ascending
                            select c;
                var results = query.ToList();

                return results;
            }
        }

        #endregion

        #region AI Images


        #endregion
    }
}
