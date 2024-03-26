using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageStyle
    {
     [Key]   public int       styleID     { get; set; }
             public string    styleName   { get; set; } = null!;
             public string    notes       { get; set; } = "";
             
             [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             public DateTime? createdDate { get; set; }
    }
}
