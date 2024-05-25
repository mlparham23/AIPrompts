using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageArtist
    {
        [Key]   public int      artistID    { get; set; }
                public string   artistName  { get; set; } = null!;
                public string   artistStyle { get; set; } = "";

                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
                public DateTime? createdDate { get; set; }
    }
}
