using System.Drawing;
using System.Windows.Forms;

namespace InjectorLinuxServer.Data
{
    internal static class Design
    {
        internal static void LinuxChecker(ref Panel pan, ref Label lab, bool ans)
        {
            if (ans)
            {
                pan.BackColor = Color.LimeGreen;
                lab.Text = "v";
            }
            else
            {
                pan.BackColor = Color.Red;
                lab.Text = "x";
            }
        }
        internal static void WDSChecker(ref TextBox tb, bool active)
        {
            if (active)
            {
                tb.BackColor = Color.LimeGreen;
                tb.ForeColor = Color.White;
            }
            else
            {
                tb.BackColor = Color.Red;
                tb.ForeColor = Color.White;
            }
        }
    }
}
