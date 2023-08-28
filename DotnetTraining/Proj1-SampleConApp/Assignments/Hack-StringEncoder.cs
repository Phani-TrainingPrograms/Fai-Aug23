using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Proj2_DataAccessProgram
{
    class StringEncoderHackethon
    {
        const string CODE = "the quick and brown fox jumps over the lazy dog";
        static List<string> words = CODE.Split(' ').ToList();
        static void Main(string[] args)
        {
            var code = Encode("");
            Console.WriteLine(code);
            
        }

        static string Encode(string input)
        {
            if (input == null) throw new NullReferenceException("Argument cannot be null");
            if (String.IsNullOrEmpty(input)) throw new ArgumentException("String cannot be empty"); 
            var content = "";
            foreach(var val in input.ToLower())//val is a char...
            {
                if(val == ' ')
                {
                    content = content.Substring(0, content.Length - 1);
                    content += getCode(val);
                }
                else
                {
                    content += getCode(val);
                    content += ',';
                }
            }
            return content.Substring(0, content.Length -1);            
        }

        private static string getCode(char ch)
        {
            if (ch == ' ') return "-";
            string code = string.Empty;
            foreach(var w in words){
                if (w.Contains(ch))
                {
                    code += words.IndexOf(w);
                    code += w.IndexOf(ch);
                    return code;
                }
            }
            return "";
        }
    }
}
