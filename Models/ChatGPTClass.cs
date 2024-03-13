using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ChatGPTClass
    {
       [Key]    public int      GPTID       { get; set; }
                public string   versionName { get; set; } = "";
    }
}
