using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InjectorLinuxServer.Data
{
    internal class ZipDirect
    {
        Linux _Linux = new Linux();
        internal string _Path = string.Empty;
        string _Url = string.Empty;
        internal delegate void DownloadingComplate();
        internal DownloadingComplate DonwloadingComplateHandler { get; set; }

        public ZipDirect(string version, string file)
        {
            _Url = $"{_Linux._KernelSite}{version}/{file}";
            _Path = Environment.CurrentDirectory + @"\" + file;
        }

        public void Download()
        {
            if (File.Exists(_Path))
                return;

            Task task = new Task(() =>
            {
                var stream = new HttpClient().GetStreamAsync(_Url);
                var fs = new FileStream(_Path, FileMode.Create);
                stream.Result.CopyTo(fs);
                fs.Close();
            });
            task.Start();
            task.GetAwaiter().OnCompleted(() => DonwloadingComplateHandler());
        }

        public string[] GetExistsFile()
        {
            if (!File.Exists(_Path))
                return default;
            return ZipFile.Open(_Path, ZipArchiveMode.Read)
                .Entries.ToList()
                .Select(x => x.ToString()).ToArray();
        }

        public void UnZipFile(int index, string pathExct)
        {
            ZipFile.OpenRead(_Path).Entries[index].ExtractToFile(pathExct);
        }
    }
}
