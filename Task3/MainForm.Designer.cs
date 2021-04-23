
namespace Task3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AppendBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.HeaderBtn = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(998, 201);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // AppendBtn
            // 
            this.AppendBtn.Location = new System.Drawing.Point(13, 220);
            this.AppendBtn.Name = "AppendBtn";
            this.AppendBtn.Size = new System.Drawing.Size(210, 63);
            this.AppendBtn.TabIndex = 1;
            this.AppendBtn.Text = "Дополнить текст";
            this.AppendBtn.UseVisualStyleBackColor = true;
            this.AppendBtn.Click += new System.EventHandler(this.AppendBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(401, 220);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(210, 63);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "Вывести текст";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // HeaderBtn
            // 
            this.HeaderBtn.Location = new System.Drawing.Point(801, 220);
            this.HeaderBtn.Name = "HeaderBtn";
            this.HeaderBtn.Size = new System.Drawing.Size(210, 63);
            this.HeaderBtn.TabIndex = 3;
            this.HeaderBtn.Text = "Заголовок текста";
            this.HeaderBtn.UseVisualStyleBackColor = true;
            this.HeaderBtn.Click += new System.EventHandler(this.HeaderBtn_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 301);
            this.Header.MaximumSize = new System.Drawing.Size(1041, 100);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(0, 46);
            this.Header.TabIndex = 4;
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.Location = new System.Drawing.Point(12, 363);
            this.Text.MaximumSize = new System.Drawing.Size(1041, 300);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(0, 25);
            this.Text.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 587);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.HeaderBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.AppendBtn);
            this.Controls.Add(this.richTextBox1);
            this.MaximumSize = new System.Drawing.Size(1041, 634);
            this.MinimumSize = new System.Drawing.Size(1041, 634);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AppendBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button HeaderBtn;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Text;
    }
}

