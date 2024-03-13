using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ChatGPTPrompt
    {

        [Key]   public int      PromptID    { get; set; }
                public int      Rank        { get; set; } = 1;
                public int      Category1   { get; set; } = 1;
                public int      Category2   { get; set; } = 1;
                public int      Category3   { get; set; } = 1;
                public int      GPTVersion  { get; set; } = 1;
                public int      NSFW        { get; set; } = 1;
                public string   PromptTitle { get; set; } = null!;
                public string   Prompt      { get; set; } = null!;

                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public DateTime createDate  { get; set;}
    }
}
