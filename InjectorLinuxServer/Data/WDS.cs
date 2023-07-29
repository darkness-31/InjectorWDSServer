using System.IO;
using System.Text;

namespace InjectorLinuxServer.Data
{
    internal class WDS
    {
        public string _Path { get; set; }
        public WDS(string path)
        {
            _Path = path;
        }

        public bool Check(bool x64, bool x86)
        {
            var path = Path.Combine(_Path, "Boot");
            bool ans = false;

            if (Directory.Exists(path))
            {
                if (x64)
                {
                    ans = ans && File.Exists(Path.Combine(path, @"x64\pxeboot.n12"));
                    ans = ans && File.Exists(Path.Combine(path, @"x64\abortpxe.com"));
                }
                if (x86)
                {
                    ans = ans && File.Exists(Path.Combine(path, @"x86\pxeboot.n12"));
                    ans = ans && File.Exists(Path.Combine(path, @"x86\abortpxe.com"));
                }
            }

            return ans;
        }

        public void PathcerWDS()
        {
            string bootPath86 = "wdsutil /set-server /bootprogram:boot\\x86\\pxelinux.com /architecture:x86 && wdsutil /set-server /N12bootprogram:boot\\x86\\pxelinux.com /architecture:x86";
            string bootPath64 = "wdsutil /set-server /bootprogram:boot\\x64\\pxelinux.com /architecture:x64 && wdsutil /set-server /N12bootprogram:boot\\x64\\pxelinux.com /architecture:x64";
            try
            {
                System.Diagnostics.Process.Start("CMD.exe", bootPath86);
                System.Diagnostics.Process.Start("CMD.exe", bootPath64);
            } catch { }
        }

        public void GenerateFileDefault(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            string text = "DEFAULT      vesamenu.c32\r\nPROMPT       0\r\nMENU TITLE PXE Boot Menu (x86)\r\nMENU INCLUDE pxelinux.cfg/graphics.conf\r\nMENU AUTOBOOT Starting Local System in 8 seconds\r\n# Option 1 - Exit PXE Linux & boot normally\r\nLABEL bootlocal\r\nmenu label ^Boot Normally\r\nmenu default\r\nlocalboot 0\r\ntimeout 80\r\nTOTALTIMEOUT 9000\r\n# Option 2 - Run WDS\r\nLABEL wds\r\nMENU LABEL ^Windows Deployment Services\r\nKERNEL pxeboot.0\r\n# Option 3 - Exit PXE Linux\r\nLABEL Abort\r\nMENU LABEL E^xit\r\nKERNEL abortpxe.0";
            fs.Write(Encoding.ASCII.GetBytes(text), 0, 1024);
            fs.Close();
        }
    }
}
