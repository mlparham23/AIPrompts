using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ChatCategoryClass
    {
        
        [Key]   public int      categoryID  { get; set; }
                public string?  category    { get; set; } = null!;
    }
}
