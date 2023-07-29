namespace InjectorLinuxServer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBoxKernels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxRelKernel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.checkChain = new System.Windows.Forms.Panel();
            this.labelChain = new System.Windows.Forms.Label();
            this.checkVesamenu = new System.Windows.Forms.Panel();
            this.labelVesamenu = new System.Windows.Forms.Label();
            this.checkPxelinux = new System.Windows.Forms.Panel();
            this.labelPxeLinux = new System.Windows.Forms.Label();
            this.LabelChainName = new System.Windows.Forms.Label();
            this.LabelVesamenuName = new System.Windows.Forms.Label();
            this.LabelPxelinuxName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonChecker = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonCheckWDS = new System.Windows.Forms.Button();
            this.CheckEditx86 = new System.Windows.Forms.CheckBox();
            this.CheckEditx64 = new System.Windows.Forms.CheckBox();
            this.ButtonFolderWDS = new System.Windows.Forms.Button();
            this.TextboxWDS = new System.Windows.Forms.TextBox();
            this.ButtonInject = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.checkChain.SuspendLayout();
            this.checkVesamenu.SuspendLayout();
            this.checkPxelinux.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxKernels
            // 
            this.ComboBoxKernels.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxKernels.FormattingEnabled = true;
            this.ComboBoxKernels.Location = new System.Drawing.Point(56, 19);
            this.ComboBoxKernels.Name = "ComboBoxKernels";
            this.ComboBoxKernels.Size = new System.Drawing.Size(94, 21);
            this.ComboBoxKernels.Sorted = true;
            this.ComboBoxKernels.TabIndex = 0;
            this.ComboBoxKernels.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKernels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Версия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Релиз";
            // 
            // ComboBoxRelKernel
            // 
            this.ComboBoxRelKernel.Enabled = false;
            this.ComboBoxRelKernel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxRelKernel.FormattingEnabled = true;
            this.ComboBoxRelKernel.Location = new System.Drawing.Point(56, 49);
            this.ComboBoxRelKernel.Name = "ComboBoxRelKernel";
            this.ComboBoxRelKernel.Size = new System.Drawing.Size(179, 21);
            this.ComboBoxRelKernel.Sorted = true;
            this.ComboBoxRelKernel.TabIndex = 0;
            this.ComboBoxRelKernel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelKernel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonDownload);
            this.groupBox1.Controls.Add(this.checkChain);
            this.groupBox1.Controls.Add(this.checkVesamenu);
            this.groupBox1.Controls.Add(this.checkPxelinux);
            this.groupBox1.Controls.Add(this.LabelChainName);
            this.groupBox1.Controls.Add(this.LabelVesamenuName);
            this.groupBox1.Controls.Add(this.LabelPxelinuxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ButtonChecker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBoxKernels);
            this.groupBox1.Controls.Add(this.ComboBoxRelKernel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linux ядро";
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDownload.Location = new System.Drawing.Point(9, 76);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(226, 20);
            this.ButtonDownload.TabIndex = 6;
            this.ButtonDownload.Text = "Скачать";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // checkChain
            // 
            this.checkChain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.checkChain.Controls.Add(this.labelChain);
            this.checkChain.Location = new System.Drawing.Point(11, 146);
            this.checkChain.Name = "checkChain";
            this.checkChain.Size = new System.Drawing.Size(15, 15);
            this.checkChain.TabIndex = 5;
            // 
            // labelChain
            // 
            this.labelChain.AutoSize = true;
            this.labelChain.BackColor = System.Drawing.Color.Transparent;
            this.labelChain.Location = new System.Drawing.Point(2, 0);
            this.labelChain.Name = "labelChain";
            this.labelChain.Size = new System.Drawing.Size(13, 13);
            this.labelChain.TabIndex = 0;
            this.labelChain.Text = "?";
            // 
            // checkVesamenu
            // 
            this.checkVesamenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.checkVesamenu.Controls.Add(this.labelVesamenu);
            this.checkVesamenu.Location = new System.Drawing.Point(11, 123);
            this.checkVesamenu.Name = "checkVesamenu";
            this.checkVesamenu.Size = new System.Drawing.Size(15, 15);
            this.checkVesamenu.TabIndex = 5;
            // 
            // labelVesamenu
            // 
            this.labelVesamenu.AutoSize = true;
            this.labelVesamenu.BackColor = System.Drawing.Color.Transparent;
            this.labelVesamenu.Location = new System.Drawing.Point(2, 2);
            this.labelVesamenu.Name = "labelVesamenu";
            this.labelVesamenu.Size = new System.Drawing.Size(13, 13);
            this.labelVesamenu.TabIndex = 0;
            this.labelVesamenu.Text = "?";
            // 
            // checkPxelinux
            // 
            this.checkPxelinux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.checkPxelinux.Controls.Add(this.labelPxeLinux);
            this.checkPxelinux.Location = new System.Drawing.Point(11, 102);
            this.checkPxelinux.Name = "checkPxelinux";
            this.checkPxelinux.Size = new System.Drawing.Size(15, 15);
            this.checkPxelinux.TabIndex = 5;
            // 
            // labelPxeLinux
            // 
            this.labelPxeLinux.AutoSize = true;
            this.labelPxeLinux.BackColor = System.Drawing.Color.Transparent;
            this.labelPxeLinux.Location = new System.Drawing.Point(2, 0);
            this.labelPxeLinux.Name = "labelPxeLinux";
            this.labelPxeLinux.Size = new System.Drawing.Size(13, 13);
            this.labelPxeLinux.TabIndex = 0;
            this.labelPxeLinux.Text = "?";
            // 
            // LabelChainName
            // 
            this.LabelChainName.AutoSize = true;
            this.LabelChainName.Location = new System.Drawing.Point(35, 146);
            this.LabelChainName.Name = "LabelChainName";
            this.LabelChainName.Size = new System.Drawing.Size(54, 13);
            this.LabelChainName.TabIndex = 4;
            this.LabelChainName.Text = "chain.c32";
            // 
            // LabelVesamenuName
            // 
            this.LabelVesamenuName.AutoSize = true;
            this.LabelVesamenuName.Location = new System.Drawing.Point(35, 123);
            this.LabelVesamenuName.Name = "LabelVesamenuName";
            this.LabelVesamenuName.Size = new System.Drawing.Size(77, 13);
            this.LabelVesamenuName.TabIndex = 4;
            this.LabelVesamenuName.Text = "vesamenu.c32";
            // 
            // LabelPxelinuxName
            // 
            this.LabelPxelinuxName.AutoSize = true;
            this.LabelPxelinuxName.Location = new System.Drawing.Point(35, 102);
            this.LabelPxelinuxName.Name = "LabelPxelinuxName";
            this.LabelPxelinuxName.Size = new System.Drawing.Size(54, 13);
            this.LabelPxelinuxName.TabIndex = 4;
            this.LabelPxelinuxName.Text = "pxelinux.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(156, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Рекомендация\r\n4.00 pre-9";
            // 
            // ButtonChecker
            // 
            this.ButtonChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChecker.Enabled = false;
            this.ButtonChecker.Location = new System.Drawing.Point(9, 173);
            this.ButtonChecker.Name = "ButtonChecker";
            this.ButtonChecker.Size = new System.Drawing.Size(75, 23);
            this.ButtonChecker.TabIndex = 2;
            this.ButtonChecker.Text = "Проверить";
            this.ButtonChecker.UseVisualStyleBackColor = true;
            this.ButtonChecker.Click += new System.EventHandler(this.ButtonChecker_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonCheckWDS);
            this.groupBox2.Controls.Add(this.CheckEditx86);
            this.groupBox2.Controls.Add(this.CheckEditx64);
            this.groupBox2.Controls.Add(this.ButtonFolderWDS);
            this.groupBox2.Controls.Add(this.TextboxWDS);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WDS";
            // 
            // ButtonCheckWDS
            // 
            this.ButtonCheckWDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCheckWDS.Location = new System.Drawing.Point(119, 47);
            this.ButtonCheckWDS.Name = "ButtonCheckWDS";
            this.ButtonCheckWDS.Size = new System.Drawing.Size(75, 23);
            this.ButtonCheckWDS.TabIndex = 5;
            this.ButtonCheckWDS.Text = "Проверить";
            this.ButtonCheckWDS.UseVisualStyleBackColor = true;
            this.ButtonCheckWDS.Click += new System.EventHandler(this.ButtonCheckWDS_Click);
            // 
            // CheckEditx86
            // 
            this.CheckEditx86.AutoSize = true;
            this.CheckEditx86.Checked = true;
            this.CheckEditx86.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckEditx86.Location = new System.Drawing.Point(57, 51);
            this.CheckEditx86.Name = "CheckEditx86";
            this.CheckEditx86.Size = new System.Drawing.Size(43, 17);
            this.CheckEditx86.TabIndex = 2;
            this.CheckEditx86.Text = "x86";
            this.CheckEditx86.UseVisualStyleBackColor = true;
            this.CheckEditx86.CheckedChanged += new System.EventHandler(this.CheckEditx86_CheckedChanged);
            // 
            // CheckEditx64
            // 
            this.CheckEditx64.AutoSize = true;
            this.CheckEditx64.Checked = true;
            this.CheckEditx64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckEditx64.Location = new System.Drawing.Point(8, 51);
            this.CheckEditx64.Name = "CheckEditx64";
            this.CheckEditx64.Size = new System.Drawing.Size(43, 17);
            this.CheckEditx64.TabIndex = 2;
            this.CheckEditx64.Text = "x64";
            this.CheckEditx64.UseVisualStyleBackColor = true;
            this.CheckEditx64.CheckedChanged += new System.EventHandler(this.CheckEditx64_CheckedChanged);
            // 
            // ButtonFolderWDS
            // 
            this.ButtonFolderWDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFolderWDS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFolderWDS.Image = global::InjectorLinuxServer.Properties.Resources.folder_type_linux_icon_129907;
            this.ButtonFolderWDS.Location = new System.Drawing.Point(171, 20);
            this.ButtonFolderWDS.Name = "ButtonFolderWDS";
            this.ButtonFolderWDS.Size = new System.Drawing.Size(23, 23);
            this.ButtonFolderWDS.TabIndex = 1;
            this.ButtonFolderWDS.UseVisualStyleBackColor = true;
            this.ButtonFolderWDS.Click += new System.EventHandler(this.ButtonFolderWDS_Click);
            // 
            // TextboxWDS
            // 
            this.TextboxWDS.Location = new System.Drawing.Point(8, 21);
            this.TextboxWDS.Name = "TextboxWDS";
            this.TextboxWDS.ReadOnly = true;
            this.TextboxWDS.Size = new System.Drawing.Size(157, 20);
            this.TextboxWDS.TabIndex = 0;
            this.TextboxWDS.Text = "C:\\RemoteInstall";
            // 
            // ButtonInject
            // 
            this.ButtonInject.Location = new System.Drawing.Point(259, 191);
            this.ButtonInject.Name = "ButtonInject";
            this.ButtonInject.Size = new System.Drawing.Size(200, 23);
            this.ButtonInject.TabIndex = 4;
            this.ButtonInject.Text = "Inject";
            this.ButtonInject.UseVisualStyleBackColor = true;
            this.ButtonInject.Click += new System.EventHandler(this.ButtonInject_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar,
            this.ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 218);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.ToolStripStatusLabel.Text = "Готово";
            this.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ToolStripProgressBar.Size = new System.Drawing.Size(260, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 240);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonInject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Injector Linux для WDS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.checkChain.ResumeLayout(false);
            this.checkChain.PerformLayout();
            this.checkVesamenu.ResumeLayout(false);
            this.checkVesamenu.PerformLayout();
            this.checkPxelinux.ResumeLayout(false);
            this.checkPxelinux.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxKernels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxRelKernel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonChecker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelChainName;
        private System.Windows.Forms.Label LabelVesamenuName;
        private System.Windows.Forms.Label LabelPxelinuxName;
        private System.Windows.Forms.Panel checkChain;
        private System.Windows.Forms.Panel checkVesamenu;
        private System.Windows.Forms.Panel checkPxelinux;
        private System.Windows.Forms.Label labelChain;
        private System.Windows.Forms.Label labelVesamenu;
        private System.Windows.Forms.Label labelPxeLinux;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.TextBox TextboxWDS;
        private System.Windows.Forms.Button ButtonFolderWDS;
        private System.Windows.Forms.Button ButtonInject;
        private System.Windows.Forms.CheckBox CheckEditx64;
        private System.Windows.Forms.CheckBox CheckEditx86;
        private System.Windows.Forms.Button ButtonCheckWDS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}

