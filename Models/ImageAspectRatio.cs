using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageAspectRatio
    {
        [Key]   public int      ARID        { get; set; }           //  Primary Key
                public string   AspectRatio { get; set; } = null!;  //  Aspect Ratio
    }
}
