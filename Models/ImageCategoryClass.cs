using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageCategoryClass
    {
       [Key]    public int       catID       { get; set; }           //  Primary Key
                public string    category    { get; set; }  = null!; //  Category Name

                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public DateTime? createdDate { get; set; }
    }
}
