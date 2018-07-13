using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace MAC_Address_Tool
{
    public class CleanUpMethods
    {
        internal string RegexString(string list)
        {
            Regex regex = new Regex(@"[:]"); //Targes :
            list = regex.Replace(list, ""); //Replaces 
             
            return list;
        }

    }
}
