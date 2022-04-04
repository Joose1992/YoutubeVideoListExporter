
namespace YoutubeVideoListExporter
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
            this.ExportVideoList = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewsData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportVideoList
            // 
            this.ExportVideoList.Font = new System.Drawing.Font("Lucida Console", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportVideoList.Location = new System.Drawing.Point(517, 32);
            this.ExportVideoList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportVideoList.Name = "ExportVideoList";
            this.ExportVideoList.Size = new System.Drawing.Size(215, 49);
            this.ExportVideoList.TabIndex = 0;
            this.ExportVideoList.Text = "Export Video List";
            this.ExportVideoList.UseVisualStyleBackColor = true;
            this.ExportVideoList.Click += new System.EventHandler(this.ExportVideoList_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_url.Location = new System.Drawing.Point(20, 41);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_url.Multiline = true;
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(436, 42);
            this.textBox_url.TabIndex = 1;
            this.textBox_url.Text = "Enter Channel Id";
            this.textBox_url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleData,
            this.ViewsData,
            this.DateData});
            this.dataGridView1.Location = new System.Drawing.Point(25, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 514);
            this.dataGridView1.TabIndex = 3;
            // 
            // TitleData
            // 
            this.TitleData.HeaderText = "Video Position";
            this.TitleData.MinimumWidth = 10;
            this.TitleData.Name = "TitleData";
            // 
            // ViewsData
            // 
            this.ViewsData.HeaderText = "Video Title";
            this.ViewsData.MinimumWidth = 10;
            this.ViewsData.Name = "ViewsData";
            // 
            // DateData
            // 
            this.DateData.HeaderText = "Date Published";
            this.DateData.MinimumWidth = 10;
            this.DateData.Name = "DateData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 747);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.ExportVideoList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportVideoList;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateData;
    }
}

