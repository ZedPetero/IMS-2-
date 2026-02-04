namespace IMS.Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxSearch = new TextBox();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxDexcription = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(425, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 450);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Program";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(29, 66);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(271, 23);
            textBoxSearch.TabIndex = 2;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(29, 136);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(271, 23);
            textBoxId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(29, 211);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(271, 23);
            textBoxName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 183);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // textBoxDexcription
            // 
            textBoxDexcription.Location = new Point(29, 292);
            textBoxDexcription.Name = "textBoxDexcription";
            textBoxDexcription.Size = new Size(271, 23);
            textBoxDexcription.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 264);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(29, 360);
            button1.Name = "button1";
            button1.Size = new Size(271, 23);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxDexcription);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxSearch;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxDexcription;
        private Label label4;
        private Button button1;
    }
}
