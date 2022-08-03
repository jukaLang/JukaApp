using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukaApp.LSP
{
    internal class TOKENS
    {
        public static string FUNCTION_DEFINE = "func";
        public static string[] PRINT_STATEMENTS = { "printLine", "print" };
        public static string VARIABLE_IDENTIFIER = "var";
        public static string[] CONDITION_STATEMENTS = { "if", "else", "while", "break" };
        public static string CLASS_IDENTIFIER = "class";
    }
}
