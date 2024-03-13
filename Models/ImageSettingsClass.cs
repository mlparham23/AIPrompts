using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageSettingsClass
    {
        [Key] public int      setID                       { get; set; }
              public int      seed                        { get; set; } = -1;
              public int      CGFScale                    { get; set; } = 0;
              public string   imageMode                   { get; set; } = "";
              public string   imageSize                   { get; set; } = "";
              public int      promptID                    { get; set; }
              public int      modelID                     { get; set; }
              public int      steps                       { get; set; }
              public int      scheduler                   { get; set; }
              public int      DPMSolverGuidanceScale      { get; set; } = 4;
              public int      DPMSolverInterferenceSteps  { get; set; } = 14;
              public int      SASolverGuidanceScale       { get; set; } = 3;
              public int      SASolverInterferenceSteps   { get; set; } = 25;
              public string   samplingMethod              { get; set; } = "";
              public string   tags                        { get; set; } = "";

              [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
              public DateTime? createdDate { get; set; }
    }
}
