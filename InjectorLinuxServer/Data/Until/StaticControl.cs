using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectorLinuxServer.Data.Until
{
    internal static class StaticControl
    {
        internal static void Invoker(this Control contr, Action action)
        {
            if (contr.InvokeRequired)
            {
                contr.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
