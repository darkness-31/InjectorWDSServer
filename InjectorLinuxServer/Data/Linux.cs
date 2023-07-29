using InjectorLinuxServer.Data.Until;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InjectorLinuxServer.Data
{
    internal class Linux
    {
        public readonly string _KernelSite = @"https://mirrors.edge.kernel.org/pub/linux/utils/boot/syslinux/Testing/";

        public string[] GetKernels() 
        {
            var ker = GetNod(_KernelSite).ToList();
            ker.RemoveAt(0);
            ker.RemoveAt(ker.Count-1);
            return ker.ToArray();
        }

        public string[] GetVersionsKernel(string kernel)
        {
            var ker = GetNod($"{_KernelSite}{kernel}/").ToList();
            ker.RemoveAt(0);
            ker.RemoveAt(0);
            return ker.Where(x => x.Contains(".zip") && !x.Contains(".sign")).ToArray();
        }

        private string[] GetNod(string site)
        {
            Html html = new Html(site);
            var kernels = html.GetNode("//a").ToList();
            return kernels.Select(x => x.TrimEnd('/')).ToArray();
        }
    }
}
