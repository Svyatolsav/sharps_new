
namespace Task6
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncyclopediaGenre = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Raiting = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.sources = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sources)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EncyclopediaType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EncyclopediaGenre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // EncyclopediaGenre
            // 
            this.EncyclopediaGenre.Location = new System.Drawing.Point(147, 43);
            this.EncyclopediaGenre.Name = "EncyclopediaGenre";
            this.EncyclopediaGenre.Size = new System.Drawing.Size(724, 22);
            this.EncyclopediaGenre.TabIndex = 4;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(147, 73);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(724, 22);
            this.NameField.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(147, 103);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(724, 22);
            this.Date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // Raiting
            // 
            this.Raiting.Location = new System.Drawing.Point(147, 131);
            this.Raiting.Name = "Raiting";
            this.Raiting.Size = new System.Drawing.Size(724, 22);
            this.Raiting.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Raiting";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(796, 174);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sources
            // 
            this.sources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sources.Location = new System.Drawing.Point(15, 223);
            this.sources.Name = "sources";
            this.sources.RowHeadersWidth = 51;
            this.sources.RowTemplate.Height = 24;
            this.sources.Size = new System.Drawing.Size(856, 301);
            this.sources.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(147, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 36);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(120, 10);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(125, 21);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Энциклопедия";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(6, 10);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(108, 21);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Справочник";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sources);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Raiting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.EncyclopediaGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(901, 583);
            this.MinimumSize = new System.Drawing.Size(901, 583);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.sources)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EncyclopediaGenre;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Raiting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView sources;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
    }
}