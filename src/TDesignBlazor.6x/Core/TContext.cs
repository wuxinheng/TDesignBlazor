using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDesignBlazor._6x.Core
{
    public class TContext
    {

        public TConfig Config { get; set; }
        public int ThemeMode { get { return Config.ThemeMode; } }
    }
}
