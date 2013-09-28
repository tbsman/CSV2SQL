namespace CSV2SQL
{
    partial class Form1
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.progressPanel = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.settingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.browseFileButton = new System.Windows.Forms.Button();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.layoutPanel.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Controls.Add(this.progressPanel, 0, 1);
            this.layoutPanel.Controls.Add(this.settingsPanel, 0, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(506, 261);
            this.layoutPanel.TabIndex = 0;
            // 
            // progressPanel
            // 
            this.progressPanel.ColumnCount = 1;
            this.progressPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.progressPanel.Controls.Add(this.progressBar, 0, 0);
            this.progressPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel.Location = new System.Drawing.Point(3, 123);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.RowCount = 2;
            this.progressPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.progressPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.progressPanel.Size = new System.Drawing.Size(500, 114);
            this.progressPanel.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(494, 51);
            this.progressBar.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.browseFileButton);
            this.settingsPanel.Controls.Add(this.browseFolderButton);
            this.settingsPanel.Controls.Add(this.startButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(500, 114);
            this.settingsPanel.TabIndex = 1;
            // 
            // browseFileButton
            // 
            this.browseFileButton.Location = new System.Drawing.Point(3, 3);
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(75, 23);
            this.browseFileButton.TabIndex = 1;
            this.browseFileButton.Text = "Browse File";
            this.browseFileButton.UseVisualStyleBackColor = true;
            this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Location = new System.Drawing.Point(84, 3);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(84, 23);
            this.browseFolderButton.TabIndex = 2;
            this.browseFolderButton.Text = "Browse Folder";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(174, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.layoutPanel);
            this.Name = "Form1";
            this.Text = "CSV2SQL - therealtbs.me";
            this.layoutPanel.ResumeLayout(false);
            this.progressPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.TableLayoutPanel progressPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FlowLayoutPanel settingsPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button browseFileButton;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
    }
}

