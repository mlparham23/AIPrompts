using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class ImageFeature
    {
        [Key]   public int  featureID               { get; set; } 
                public bool randomPrompt            { get; set; } = false;
                public bool reversePrompt           { get; set; } = false;
                public bool reImaginePrompt         { get; set; } = false;
                public bool textToImage             { get; set; } = false;
                public bool imageToImage            { get; set; } = false;
                public bool textToVideo             { get; set; } = false;
                public bool imageToVideo            { get; set; } = false;
                public bool removeBackground        { get; set; } = false;
                public bool replaceBackground       { get; set; } = false;
                public bool artGallery              { get; set; } = false;
                public bool userFollowing           { get; set; } = false;
                public bool remix                   { get; set; } = false;
                public bool elements                { get; set; } = false;
                public bool alchemy                 { get; set; } = false;
                public bool imageUpscale            { get; set; } = false;
                public bool textRemover             { get; set; } = false;
                public bool adjustPictureSettings   { get; set; } = false;
                public bool generativeFill          { get; set; } = false;
                public bool sketchToArt             { get; set; } = false;
                public bool canvasEditor            { get; set; } = false;
                public bool realtimeGenerator       { get; set; } = false;
                public bool faceSwap                { get; set; } = false;
                public bool AIChat                  { get; set; } = false;
                public bool modelTraining           { get; set; } = false;
                public bool tiling                  { get; set; } = false;
                public bool API                     { get; set; } = false;
                public bool discord                 { get; set; } = false;
                public int  siteId                  { get; set; }
    }
}
