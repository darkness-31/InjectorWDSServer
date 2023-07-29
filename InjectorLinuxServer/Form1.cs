using InjectorLinuxServer.Data;
using InjectorLinuxServer.Data.Until;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectorLinuxServer
{
    public partial class Form1 : Form
    {
        internal Linux _Linux = new Linux();
        internal WDS _WDS = new WDS(@"C:\RemoteInstall");
        internal string DownloadingFiles = string.Empty; 
        internal bool _LinuxCheker = false;
        internal bool _WDSCheker = false;

        internal ZipDirect _Zip;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var v = _Linux.GetKernels();
                ComboBoxRelKernel.Invoker(new Action(() =>
                {
                    ComboBoxKernels.Items.AddRange(v);
                }));
            });
        }
        private void ComboBoxKernels_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxRelKernel.Enabled = true;
            ComboBoxRelKernel.Items.Clear();
            ComboBoxRelKernel.Text = string.Empty;
            ButtonChecker.Enabled = false;

            checkPxelinux.BackColor = Color.FromArgb(255, 255, 150);
            checkVesamenu.BackColor = Color.FromArgb(255, 255, 150);
            checkChain.BackColor = Color.FromArgb(255, 255, 150);

            labelPxeLinux.Text = "?";
            labelVesamenu.Text = "?";
            labelChain.Text = "?";

            var version = ComboBoxKernels.Text;
            Task.Run(() =>
            {
                var v = _Linux.GetVersionsKernel(version);
                ComboBoxRelKernel.Invoker(new Action(() =>
                {
                    ComboBoxRelKernel.Items.AddRange(v);
                }));
            });
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            if (ComboBoxKernels.Text == string.Empty ||
                ComboBoxRelKernel.Text == string.Empty)
                return;

            if (!string.IsNullOrEmpty(DownloadingFiles))
                File.Delete(DownloadingFiles);

            var version = ComboBoxKernels.Text;
            var relise = ComboBoxRelKernel.Text;
            _Zip = new ZipDirect(version, relise);
            DownloadingFiles = _Zip._Path;

            ToolStripStatusLabel.Text = "Загрузка...";
            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;
            ComboBoxKernels.Enabled = false;
            ComboBoxRelKernel.Enabled = false;
            ButtonDownload.Enabled = false;
            ButtonChecker.Enabled = false;

            _Zip.Download();
            _Zip.DonwloadingComplateHandler += () =>
            {
                ToolStripStatusLabel.Text = "Готово";
                ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
                ComboBoxKernels.Enabled = true;
                ComboBoxRelKernel.Enabled = true;
                ButtonDownload.Enabled = true;
                ButtonChecker.Enabled = true;
            };
        }

        private void ButtonChecker_Click(object sender, EventArgs e)
        {
            var files = _Zip.GetExistsFile();
            if (files.Length == 0)
                return;

            bool answer = true;

            files.ToList().ForEach(file =>
            {
                if (labelPxeLinux.Text != "v")
                {
                    bool ans = file.Contains(LabelPxelinuxName.Text);
                    Design.LinuxChecker(ref checkPxelinux, ref labelPxeLinux, ans);
                    answer &= ans;
                }

                if (labelVesamenu.Text != "v")
                {
                    bool ans = file.Contains(LabelVesamenuName.Text);
                    Design.LinuxChecker(ref checkVesamenu, ref labelVesamenu, ans);
                    answer &= ans;
                }

                if (labelChain.Text != "v")
                {
                    bool ans = file.Contains(LabelChainName.Text);
                    Design.LinuxChecker(ref checkChain, ref labelChain, ans);
                    answer &= ans;
                }
            });
            _LinuxCheker = answer;
        }

        private void ComboBoxRelKernel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonChecker.Enabled = false;
        }

        private void ButtonFolderWDS_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextboxWDS.Text = dialog.SelectedPath;
            }

        }

        private void CheckEditx64_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckEditx86.Checked &&
                !CheckEditx64.Checked)
            {
                CheckEditx86.Checked = true;
            }
        }

        private void CheckEditx86_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckEditx64.Checked &&
                !CheckEditx86.Checked)
            {
                CheckEditx64.Checked = true;
            }
        }

        private void ButtonCheckWDS_Click(object sender, EventArgs e)
        {
            _WDS = new WDS(TextboxWDS.Text);
            var answer = _WDS.Check(CheckEditx64.Checked, CheckEditx86.Checked);
            Design.WDSChecker(ref TextboxWDS, answer);
            _WDSCheker = answer;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DownloadingFiles))
                File.Delete(DownloadingFiles);
        }

        private void ButtonInject_Click(object sender, EventArgs e)
        {
            if (!_WDSCheker && !_LinuxCheker)
            {
                MessageBox.Show("Не прошёл проверку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ComboBoxKernels.Enabled = false;
            ComboBoxRelKernel.Enabled = false;
            ButtonDownload.Enabled = false;
            ButtonChecker.Enabled = false;
            ButtonCheckWDS.Enabled = false;
            ButtonFolderWDS.Enabled = false;
            CheckEditx64.Enabled = false;
            CheckEditx86.Enabled = false;
            ToolStripProgressBar.Style = ProgressBarStyle.Marquee;

            var pathBoot = Path.Combine(TextboxWDS.Text, "Boot");

            ToolStripStatusLabel.Text = "Cоздаём папку Linux";
            Directory.CreateDirectory(Path.Combine(pathBoot, @"Linux"));
            ToolStripStatusLabel.Text = "Cоздаём папку pxelinux.cfg";
            Directory.CreateDirectory(Path.Combine(pathBoot, @"pxelinux.cfg"));

            ToolStripStatusLabel.Text = "Патчим pxeboot";
            File.Move(Path.Combine(pathBoot, "pxeboot.n12"),
                      Path.Combine(pathBoot, "pxeboot.0"));
            ToolStripStatusLabel.Text = "Патчим abortpxe";
            File.Move(Path.Combine(pathBoot, "abortpxe.com"),
                      Path.Combine(pathBoot, "abortpxe.0"));

            ToolStripStatusLabel.Text = "Создаём меню";
            _WDS.GenerateFileDefault(Path.Combine(pathBoot, @"pxelinux.cfg\default"));

            ToolStripStatusLabel.Text = "Патчим linux файлами";
            var files = _Zip.GetExistsFile();
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(LabelPxelinuxName.Text))
                {
                    _Zip.UnZipFile(i, Path.Combine(TextboxWDS.Text, @"pxelinux.0"));
                }

                if (files[i].Contains(LabelVesamenuName.Text))
                {
                    _Zip.UnZipFile(i, Path.Combine(TextboxWDS.Text, @"vesamenu.c32"));
                }

                if (files[i].Contains(LabelChainName.Text))
                {
                    _Zip.UnZipFile(i, Path.Combine(TextboxWDS.Text, @"chain.c32"));
                }
            }

            ToolStripStatusLabel.Text = "Регистрируем в системе";
            _WDS.PathcerWDS();

            ComboBoxKernels.Enabled = true;
            ComboBoxRelKernel.Enabled = true;
            ButtonDownload.Enabled = true;
            ButtonChecker.Enabled = true;
            ButtonCheckWDS.Enabled = true;
            ButtonFolderWDS.Enabled = true;
            CheckEditx64.Enabled = true;
            CheckEditx86.Enabled = true;

            ToolStripProgressBar.Style = ProgressBarStyle.Blocks;
            ToolStripStatusLabel.Text = "Готово";
        }
    }
}
