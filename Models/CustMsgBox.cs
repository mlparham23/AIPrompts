using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrompts.Models
{
    public class CustMsgBox
    {
        public string Title         { get; set; } = "";
        public string Message       { get; set; } = "";
        public string SystemMessage { get; set; } = "";
        public string ButtonText1   { get; set; } = "";
        public string ButtonText2   { get; set; } = "";
        public string ButtonText3   { get; set; } = "";
        public string ButtonText4   { get; set; } = "";
        public string ButtonText5   { get; set; } = "";
        public string ButtonText6   { get; set; } = "";
        public int    Icon          { get; set; } = 0;
    }
}
