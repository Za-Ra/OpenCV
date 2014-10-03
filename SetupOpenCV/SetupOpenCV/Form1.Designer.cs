namespace SetupOpenCV
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_CvPath = new System.Windows.Forms.Button();
            this.button_PrjPath = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_CVPath = new System.Windows.Forms.TextBox();
            this.textBox_PrjPath = new System.Windows.Forms.TextBox();
            this.openFileDialog_CVPath = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_PrjPath = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_CVPath = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            this.groupBox_OSDefault = new System.Windows.Forms.GroupBox();
            this.comboBox_SelectOS = new System.Windows.Forms.ComboBox();
            this.label_DefaultSelect = new System.Windows.Forms.Label();
            this.groupBox_GetCVPath = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox_VSVer = new System.Windows.Forms.GroupBox();
            this.label_VSVer = new System.Windows.Forms.Label();
            this.comboBox_VSVer = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_WhatsThis = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_What_Howtouse = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_What_About = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_OSDefault.SuspendLayout();
            this.groupBox_GetCVPath.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_VSVer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CvPath
            // 
            this.button_CvPath.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_CvPath.Location = new System.Drawing.Point(566, 43);
            this.button_CvPath.Name = "button_CvPath";
            this.button_CvPath.Size = new System.Drawing.Size(183, 73);
            this.button_CvPath.TabIndex = 0;
            this.button_CvPath.Text = "CV Path";
            this.button_CvPath.UseVisualStyleBackColor = true;
            this.button_CvPath.Click += new System.EventHandler(this.button_CvPath_Click);
            // 
            // button_PrjPath
            // 
            this.button_PrjPath.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_PrjPath.Location = new System.Drawing.Point(566, 39);
            this.button_PrjPath.Name = "button_PrjPath";
            this.button_PrjPath.Size = new System.Drawing.Size(183, 73);
            this.button_PrjPath.TabIndex = 1;
            this.button_PrjPath.Text = "Project File";
            this.button_PrjPath.UseVisualStyleBackColor = true;
            this.button_PrjPath.Click += new System.EventHandler(this.button_PrjPath_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Start.Location = new System.Drawing.Point(177, 374);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(183, 73);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Close
            // 
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Close.Location = new System.Drawing.Point(464, 374);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(183, 73);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_CVPath
            // 
            this.textBox_CVPath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_CVPath.Location = new System.Drawing.Point(6, 43);
            this.textBox_CVPath.Multiline = true;
            this.textBox_CVPath.Name = "textBox_CVPath";
            this.textBox_CVPath.Size = new System.Drawing.Size(554, 73);
            this.textBox_CVPath.TabIndex = 4;
            // 
            // textBox_PrjPath
            // 
            this.textBox_PrjPath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_PrjPath.Location = new System.Drawing.Point(6, 39);
            this.textBox_PrjPath.Multiline = true;
            this.textBox_PrjPath.Name = "textBox_PrjPath";
            this.textBox_PrjPath.Size = new System.Drawing.Size(554, 73);
            this.textBox_PrjPath.TabIndex = 5;
            // 
            // openFileDialog_CVPath
            // 
            this.openFileDialog_CVPath.FileName = "openFileDialog_CVPath";
            // 
            // openFileDialog_PrjPath
            // 
            this.openFileDialog_PrjPath.FileName = "openFileDialog_PrjPath";
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Debug.Location = new System.Drawing.Point(12, 453);
            this.textBox_Debug.Multiline = true;
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Debug.Size = new System.Drawing.Size(749, 87);
            this.textBox_Debug.TabIndex = 6;
            // 
            // groupBox_OSDefault
            // 
            this.groupBox_OSDefault.Controls.Add(this.comboBox_SelectOS);
            this.groupBox_OSDefault.Controls.Add(this.label_DefaultSelect);
            this.groupBox_OSDefault.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_OSDefault.Location = new System.Drawing.Point(12, 36);
            this.groupBox_OSDefault.Name = "groupBox_OSDefault";
            this.groupBox_OSDefault.Size = new System.Drawing.Size(348, 70);
            this.groupBox_OSDefault.TabIndex = 7;
            this.groupBox_OSDefault.TabStop = false;
            this.groupBox_OSDefault.Text = "1. System OS is :";
            // 
            // comboBox_SelectOS
            // 
            this.comboBox_SelectOS.FormattingEnabled = true;
            this.comboBox_SelectOS.Items.AddRange(new object[] {
            "x86 (32bit)",
            "x64 (64bit)"});
            this.comboBox_SelectOS.Location = new System.Drawing.Point(192, 25);
            this.comboBox_SelectOS.Name = "comboBox_SelectOS";
            this.comboBox_SelectOS.Size = new System.Drawing.Size(136, 32);
            this.comboBox_SelectOS.TabIndex = 1;
            this.comboBox_SelectOS.SelectedIndexChanged += new System.EventHandler(this.OS_Select_index_Chenge);
            // 
            // label_DefaultSelect
            // 
            this.label_DefaultSelect.AutoSize = true;
            this.label_DefaultSelect.Location = new System.Drawing.Point(7, 33);
            this.label_DefaultSelect.Name = "label_DefaultSelect";
            this.label_DefaultSelect.Size = new System.Drawing.Size(179, 24);
            this.label_DefaultSelect.TabIndex = 0;
            this.label_DefaultSelect.Text = "You wand to Add : ";
            // 
            // groupBox_GetCVPath
            // 
            this.groupBox_GetCVPath.Controls.Add(this.textBox_CVPath);
            this.groupBox_GetCVPath.Controls.Add(this.button_CvPath);
            this.groupBox_GetCVPath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_GetCVPath.Location = new System.Drawing.Point(12, 112);
            this.groupBox_GetCVPath.Name = "groupBox_GetCVPath";
            this.groupBox_GetCVPath.Size = new System.Drawing.Size(755, 122);
            this.groupBox_GetCVPath.TabIndex = 8;
            this.groupBox_GetCVPath.TabStop = false;
            this.groupBox_GetCVPath.Text = "3. Where is the OpenCV Folder ? (Untial see \"Build\" Folder)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_PrjPath);
            this.groupBox2.Controls.Add(this.button_PrjPath);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "4. Which C project need to add CV\'s path ( *.vcxproj)";
            // 
            // groupBox_VSVer
            // 
            this.groupBox_VSVer.Controls.Add(this.label_VSVer);
            this.groupBox_VSVer.Controls.Add(this.comboBox_VSVer);
            this.groupBox_VSVer.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_VSVer.Location = new System.Drawing.Point(367, 36);
            this.groupBox_VSVer.Name = "groupBox_VSVer";
            this.groupBox_VSVer.Size = new System.Drawing.Size(400, 70);
            this.groupBox_VSVer.TabIndex = 10;
            this.groupBox_VSVer.TabStop = false;
            this.groupBox_VSVer.Text = "2. Your Visual Studio Ver is :";
            // 
            // label_VSVer
            // 
            this.label_VSVer.AutoSize = true;
            this.label_VSVer.Location = new System.Drawing.Point(6, 36);
            this.label_VSVer.Name = "label_VSVer";
            this.label_VSVer.Size = new System.Drawing.Size(63, 24);
            this.label_VSVer.TabIndex = 1;
            this.label_VSVer.Text = "VsVer";
            // 
            // comboBox_VSVer
            // 
            this.comboBox_VSVer.FormattingEnabled = true;
            this.comboBox_VSVer.Items.AddRange(new object[] {
            "VS2008",
            "VS2010",
            "VS2012",
            "VS2013"});
            this.comboBox_VSVer.Location = new System.Drawing.Point(273, 33);
            this.comboBox_VSVer.Name = "comboBox_VSVer";
            this.comboBox_VSVer.Size = new System.Drawing.Size(121, 32);
            this.comboBox_VSVer.TabIndex = 0;
            this.comboBox_VSVer.SelectedIndexChanged += new System.EventHandler(this.Check_comboBox_VsVer_Change);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_WhatsThis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_WhatsThis
            // 
            this.toolStripMenuItem_WhatsThis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_What_Howtouse,
            this.ToolStripMenuItem_What_About});
            this.toolStripMenuItem_WhatsThis.Name = "toolStripMenuItem_WhatsThis";
            this.toolStripMenuItem_WhatsThis.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem_WhatsThis.Text = "What\'s this";
            // 
            // ToolStripMenuItem_What_Howtouse
            // 
            this.ToolStripMenuItem_What_Howtouse.Name = "ToolStripMenuItem_What_Howtouse";
            this.ToolStripMenuItem_What_Howtouse.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_What_Howtouse.Text = "How To Use";
            this.ToolStripMenuItem_What_Howtouse.Click += new System.EventHandler(this.ToolStripMenuItem_What_Howtouse_Click);
            // 
            // ToolStripMenuItem_What_About
            // 
            this.ToolStripMenuItem_What_About.Name = "ToolStripMenuItem_What_About";
            this.ToolStripMenuItem_What_About.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_What_About.Text = "About";
            this.ToolStripMenuItem_What_About.Click += new System.EventHandler(this.ToolStripMenuItem_What_About_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox_VSVer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_GetCVPath);
            this.Controls.Add(this.groupBox_OSDefault);
            this.Controls.Add(this.textBox_Debug);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Setup OpenCV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox_OSDefault.ResumeLayout(false);
            this.groupBox_OSDefault.PerformLayout();
            this.groupBox_GetCVPath.ResumeLayout(false);
            this.groupBox_GetCVPath.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_VSVer.ResumeLayout(false);
            this.groupBox_VSVer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CvPath;
        private System.Windows.Forms.Button button_PrjPath;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_CVPath;
        private System.Windows.Forms.TextBox textBox_PrjPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog_CVPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PrjPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_CVPath;
        private System.Windows.Forms.TextBox textBox_Debug;
        private System.Windows.Forms.GroupBox groupBox_OSDefault;
        private System.Windows.Forms.ComboBox comboBox_SelectOS;
        private System.Windows.Forms.Label label_DefaultSelect;
        private System.Windows.Forms.GroupBox groupBox_GetCVPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_VSVer;
        private System.Windows.Forms.ComboBox comboBox_VSVer;
        private System.Windows.Forms.Label label_VSVer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_WhatsThis;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_What_Howtouse;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_What_About;
    }
}

