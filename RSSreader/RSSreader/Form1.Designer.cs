namespace RSSreader
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Url_textBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Rss_list = new System.Windows.Forms.ListView();
            this.Description_webBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Url_textBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RefreshButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rss_list, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description_webBrowser, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882522F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.11748F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Url_textBox
            // 
            this.Url_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Url_textBox.Location = new System.Drawing.Point(3, 3);
            this.Url_textBox.Name = "Url_textBox";
            this.Url_textBox.Size = new System.Drawing.Size(211, 20);
            this.Url_textBox.TabIndex = 0;
            this.Url_textBox.UseWaitCursor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.Location = new System.Drawing.Point(220, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(212, 25);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Rss_list
            // 
            this.Rss_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rss_list.Location = new System.Drawing.Point(3, 34);
            this.Rss_list.Name = "Rss_list";
            this.Rss_list.ShowItemToolTips = true;
            this.Rss_list.Size = new System.Drawing.Size(211, 312);
            this.Rss_list.TabIndex = 2;
            this.Rss_list.UseCompatibleStateImageBehavior = false;
            this.Rss_list.View = System.Windows.Forms.View.Tile;
            this.Rss_list.SelectedIndexChanged += new System.EventHandler(this.Rss_list_SelectedIndexChanged);
            this.Rss_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Rss_list_MouseDoubleClick);
            // 
            // Description_webBrowser
            // 
            this.Description_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_webBrowser.Location = new System.Drawing.Point(220, 34);
            this.Description_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Description_webBrowser.Name = "Description_webBrowser";
            this.Description_webBrowser.ScriptErrorsSuppressed = true;
            this.Description_webBrowser.Size = new System.Drawing.Size(212, 312);
            this.Description_webBrowser.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Url_textBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListView Rss_list;
        private System.Windows.Forms.WebBrowser Description_webBrowser;
    }
}

