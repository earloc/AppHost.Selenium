namespace AppHost.Selenium.WinForms.Playground {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._btnLoadInternetEplorer = new System.Windows.Forms.Button();
            this._btnLoadChromt = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._ChromeHost = new AppHost.Selenium.WinForms.SeleniumHost();
            this._InternetExplorerHost = new AppHost.Selenium.WinForms.SeleniumHost();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._btnLoadInternetEplorer);
            this.splitContainer1.Panel1.Controls.Add(this._btnLoadChromt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 613);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // _btnLoadInternetEplorer
            // 
            this._btnLoadInternetEplorer.Location = new System.Drawing.Point(12, 41);
            this._btnLoadInternetEplorer.Name = "_btnLoadInternetEplorer";
            this._btnLoadInternetEplorer.Size = new System.Drawing.Size(111, 23);
            this._btnLoadInternetEplorer.TabIndex = 1;
            this._btnLoadInternetEplorer.Text = "Load IE";
            this._btnLoadInternetEplorer.UseVisualStyleBackColor = true;
            this._btnLoadInternetEplorer.Click += new System.EventHandler(this._btnLoadInternetExplorer_Click);
            // 
            // _btnLoadChromt
            // 
            this._btnLoadChromt.Location = new System.Drawing.Point(12, 12);
            this._btnLoadChromt.Name = "_btnLoadChromt";
            this._btnLoadChromt.Size = new System.Drawing.Size(111, 23);
            this._btnLoadChromt.TabIndex = 0;
            this._btnLoadChromt.Text = "Load Chrome";
            this._btnLoadChromt.UseVisualStyleBackColor = true;
            this._btnLoadChromt.Click += new System.EventHandler(this._btnLoadChromt_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._ChromeHost);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._InternetExplorerHost);
            this.splitContainer2.Size = new System.Drawing.Size(723, 613);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // _ChromeHost
            // 
            this._ChromeHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ChromeHost.DriverService = null;
            this._ChromeHost.Location = new System.Drawing.Point(0, 0);
            this._ChromeHost.Name = "_ChromeHost";
            this._ChromeHost.Size = new System.Drawing.Size(723, 300);
            this._ChromeHost.TabIndex = 0;
            // 
            // _InternetExplorerHost
            // 
            this._InternetExplorerHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this._InternetExplorerHost.DriverService = null;
            this._InternetExplorerHost.Location = new System.Drawing.Point(0, 0);
            this._InternetExplorerHost.Name = "_InternetExplorerHost";
            this._InternetExplorerHost.Size = new System.Drawing.Size(723, 309);
            this._InternetExplorerHost.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 613);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button _btnLoadInternetEplorer;
        private System.Windows.Forms.Button _btnLoadChromt;
        private SeleniumHost _ChromeHost;
        private SeleniumHost _InternetExplorerHost;
    }
}

