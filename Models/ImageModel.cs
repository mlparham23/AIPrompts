using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageModel
    {
       [Key] public int      modelID     { get; set; }
             public string   modelName   { get; set; } = null!;
             public bool     NSFW        { get; set; } = false;
             public string   notes       { get; set; } = "";

             [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             public DateTime createDate  { get; set; }
    }
}
