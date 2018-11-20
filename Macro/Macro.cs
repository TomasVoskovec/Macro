using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro
{
    class MacroScript
    {
        public string Name { get; set; }
        public string Script { get; set; }

        public MacroScript(string name, string script)
        {
            this.Name = name;
            this.Script = script;
        }
    }
}
