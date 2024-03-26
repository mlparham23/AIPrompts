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
            public DbSet<ImageSettings>    imageSettings       { get; set; }
            public DbSet<ImageSite>        imageSites          { get; set; }
            public DbSet<ImageStyle>       imageStyles         { get; set; }
            public DbSet<ImageLora>        imageLoras          { get; set; }
            public DbSet<ImageModel>       imageModel          { get; set; }
            public DbSet<ImageCategory>    imageCategory       { get; set; }
            public DbSet<ImagePrompt>      imagePrompt         { get; set; }
            public DbSet<ImageFeature>     imageFeature        { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            { 
                optionsBuilder.UseSqlServer("Data Source=MParham\\SQLEXPRESS;Initial Catalog=Parham;Encrypt=False;Integrated Security=True");
            }
        }

        /// <summary>
        /// Get all Loras in ascending order
        /// </summary>
        /// <returns></returns>
        public async Task<List<ImageLora>> ImageGetAllLora()
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
