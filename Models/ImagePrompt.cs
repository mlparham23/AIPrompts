using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{

    //public class MyDbContext : DbContext
    //{
    //    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    //    {
    //    }

    //    public DbSet<ImagePromptClass> AIImagePrompts { get; set; }
    //}

    public class ImagePrompt
    {
       [Key] public int       promptID        { get; set; }
             public string    promptName      { get; set; } = null!;
             public string    notes           { get; set; } = "";
             public string    negativePrompt  { get; set; } = "";
             public int       rating          { get; set; } = 0;
             
             [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             public DateTime? createdDate     { get; set; }
    }    
}
