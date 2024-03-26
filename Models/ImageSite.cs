using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageSite
    {
     [Key]   public int      siteID      { get; set; }
             public string   siteName    { get; set; } = null!;
             public string   siteUrl     { get; set; } = "";
             public string   userName    { get; set; } = "";
             public string   password    { get; set; } = "";
             public bool     NSFW        { get; set; } = false;
             public string   eMail       { get; set; } = "";
             public string   notes       { get; set; } = "";
             
             [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             public DateTime? createdDate { get; set; }
    }
}
