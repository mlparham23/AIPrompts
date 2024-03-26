using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageSampleMethod
    {
        [Key]   public int      SampleID        { get; set; }           //  Primary Key
                public string   SampleMethod    { get; set; } = null!;  //  Sample Method
    }
}
