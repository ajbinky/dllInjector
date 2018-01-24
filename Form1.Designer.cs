namespace dllInjector
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInject = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(12, 150);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(151, 54);
            this.btnInject.TabIndex = 0;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "none";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 95);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(151, 49);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Choose dll file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(12, 68);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(151, 21);
            this.cb.TabIndex = 2;
            this.cb.Text = "Process to inject";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 50);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh processes";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 207);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(20, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "file";
            this.lblPath.Visible = false;
            // 
            // formMain
            // 
            this.AcceptButton = this.btnInject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 244);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnInject);
            this.Name = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblPath;
    }
}

