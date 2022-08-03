using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukaApp.LSP.lib
{
    internal class parser
    {
        public static void PARSER(string data)
        {
            var lines = data.Split(new string[]
            {
                Environment.NewLine
            },
                StringSplitOptions.RemoveEmptyEntries
            );

        }
    }
}
