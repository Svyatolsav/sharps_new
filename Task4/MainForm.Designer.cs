
namespace Task4
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
            this.Processor1Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RAM1Text = new System.Windows.Forms.Label();
            this.MHZ1Text = new System.Windows.Forms.GroupBox();
            this.PC1Create = new System.Windows.Forms.Button();
            this.RAM1 = new System.Windows.Forms.TextBox();
            this.MHZ1 = new System.Windows.Forms.TextBox();
            this.Processor1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HDD = new System.Windows.Forms.TextBox();
            this.HDDText = new System.Windows.Forms.Label();
            this.PC2Create = new System.Windows.Forms.Button();
            this.RAM2 = new System.Windows.Forms.TextBox();
            this.MHZ2 = new System.Windows.Forms.TextBox();
            this.Processor2 = new System.Windows.Forms.TextBox();
            this.Processor2Text = new System.Windows.Forms.Label();
            this.RAM2Text = new System.Windows.Forms.Label();
            this.MHZ2Text = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.MHZ1Text.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Processor1Text
            // 
            this.Processor1Text.AutoSize = true;
            this.Processor1Text.Location = new System.Drawing.Point(6, 21);
            this.Processor1Text.Name = "Processor1Text";
            this.Processor1Text.Size = new System.Drawing.Size(45, 17);
            this.Processor1Text.TabIndex = 0;
            this.Processor1Text.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MHZ";
            // 
            // RAM1Text
            // 
            this.RAM1Text.AutoSize = true;
            this.RAM1Text.Location = new System.Drawing.Point(6, 87);
            this.RAM1Text.Name = "RAM1Text";
            this.RAM1Text.Size = new System.Drawing.Size(38, 17);
            this.RAM1Text.TabIndex = 2;
            this.RAM1Text.Text = "RAM";
            // 
            // MHZ1Text
            // 
            this.MHZ1Text.Controls.Add(this.PC1Create);
            this.MHZ1Text.Controls.Add(this.RAM1);
            this.MHZ1Text.Controls.Add(this.MHZ1);
            this.MHZ1Text.Controls.Add(this.Processor1);
            this.MHZ1Text.Controls.Add(this.Processor1Text);
            this.MHZ1Text.Controls.Add(this.RAM1Text);
            this.MHZ1Text.Controls.Add(this.label2);
            this.MHZ1Text.Location = new System.Drawing.Point(12, 12);
            this.MHZ1Text.Name = "MHZ1Text";
            this.MHZ1Text.Size = new System.Drawing.Size(822, 115);
            this.MHZ1Text.TabIndex = 3;
            this.MHZ1Text.TabStop = false;
            this.MHZ1Text.Text = "Компьютер 1";
            // 
            // PC1Create
            // 
            this.PC1Create.Location = new System.Drawing.Point(728, 18);
            this.PC1Create.Name = "PC1Create";
            this.PC1Create.Size = new System.Drawing.Size(88, 86);
            this.PC1Create.TabIndex = 6;
            this.PC1Create.Text = "Создать";
            this.PC1Create.UseVisualStyleBackColor = true;
            this.PC1Create.Click += new System.EventHandler(this.PC1Create_Click);
            // 
            // RAM1
            // 
            this.RAM1.Location = new System.Drawing.Point(59, 84);
            this.RAM1.Name = "RAM1";
            this.RAM1.Size = new System.Drawing.Size(651, 22);
            this.RAM1.TabIndex = 5;
            // 
            // MHZ1
            // 
            this.MHZ1.Location = new System.Drawing.Point(59, 50);
            this.MHZ1.Name = "MHZ1";
            this.MHZ1.Size = new System.Drawing.Size(651, 22);
            this.MHZ1.TabIndex = 4;
            // 
            // Processor1
            // 
            this.Processor1.Location = new System.Drawing.Point(59, 18);
            this.Processor1.Name = "Processor1";
            this.Processor1.Size = new System.Drawing.Size(651, 22);
            this.Processor1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HDD);
            this.groupBox1.Controls.Add(this.HDDText);
            this.groupBox1.Controls.Add(this.PC2Create);
            this.groupBox1.Controls.Add(this.RAM2);
            this.groupBox1.Controls.Add(this.MHZ2);
            this.groupBox1.Controls.Add(this.Processor2);
            this.groupBox1.Controls.Add(this.Processor2Text);
            this.groupBox1.Controls.Add(this.RAM2Text);
            this.groupBox1.Controls.Add(this.MHZ2Text);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Компьютер 1";
            // 
            // HDD
            // 
            this.HDD.Location = new System.Drawing.Point(59, 113);
            this.HDD.Name = "HDD";
            this.HDD.Size = new System.Drawing.Size(651, 22);
            this.HDD.TabIndex = 8;
            // 
            // HDDText
            // 
            this.HDDText.AutoSize = true;
            this.HDDText.Location = new System.Drawing.Point(6, 116);
            this.HDDText.Name = "HDDText";
            this.HDDText.Size = new System.Drawing.Size(38, 17);
            this.HDDText.TabIndex = 7;
            this.HDDText.Text = "HDD";
            // 
            // PC2Create
            // 
            this.PC2Create.Location = new System.Drawing.Point(728, 18);
            this.PC2Create.Name = "PC2Create";
            this.PC2Create.Size = new System.Drawing.Size(88, 117);
            this.PC2Create.TabIndex = 6;
            this.PC2Create.Text = "Создать";
            this.PC2Create.UseVisualStyleBackColor = true;
            this.PC2Create.Click += new System.EventHandler(this.PC2Create_Click);
            // 
            // RAM2
            // 
            this.RAM2.Location = new System.Drawing.Point(59, 82);
            this.RAM2.Name = "RAM2";
            this.RAM2.Size = new System.Drawing.Size(651, 22);
            this.RAM2.TabIndex = 5;
            // 
            // MHZ2
            // 
            this.MHZ2.Location = new System.Drawing.Point(59, 50);
            this.MHZ2.Name = "MHZ2";
            this.MHZ2.Size = new System.Drawing.Size(651, 22);
            this.MHZ2.TabIndex = 4;
            // 
            // Processor2
            // 
            this.Processor2.Location = new System.Drawing.Point(59, 18);
            this.Processor2.Name = "Processor2";
            this.Processor2.Size = new System.Drawing.Size(651, 22);
            this.Processor2.TabIndex = 3;
            // 
            // Processor2Text
            // 
            this.Processor2Text.AutoSize = true;
            this.Processor2Text.Location = new System.Drawing.Point(6, 21);
            this.Processor2Text.Name = "Processor2Text";
            this.Processor2Text.Size = new System.Drawing.Size(45, 17);
            this.Processor2Text.TabIndex = 0;
            this.Processor2Text.Text = "Name";
            // 
            // RAM2Text
            // 
            this.RAM2Text.AutoSize = true;
            this.RAM2Text.Location = new System.Drawing.Point(6, 85);
            this.RAM2Text.Name = "RAM2Text";
            this.RAM2Text.Size = new System.Drawing.Size(38, 17);
            this.RAM2Text.TabIndex = 2;
            this.RAM2Text.Text = "RAM";
            // 
            // MHZ2Text
            // 
            this.MHZ2Text.AutoSize = true;
            this.MHZ2Text.Location = new System.Drawing.Point(6, 53);
            this.MHZ2Text.Name = "MHZ2Text";
            this.MHZ2Text.Size = new System.Drawing.Size(38, 17);
            this.MHZ2Text.TabIndex = 1;
            this.MHZ2Text.Text = "MHZ";
            // 
            // Info
            // 
            this.Info.Enabled = false;
            this.Info.Location = new System.Drawing.Point(840, 20);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(210, 271);
            this.Info.TabIndex = 5;
            this.Info.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 306);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MHZ1Text);
            this.MaximumSize = new System.Drawing.Size(1080, 353);
            this.MinimumSize = new System.Drawing.Size(1080, 353);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MHZ1Text.ResumeLayout(false);
            this.MHZ1Text.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Processor1Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RAM1Text;
        private System.Windows.Forms.GroupBox MHZ1Text;
        private System.Windows.Forms.Button PC1Create;
        private System.Windows.Forms.TextBox RAM1;
        private System.Windows.Forms.TextBox MHZ1;
        private System.Windows.Forms.TextBox Processor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HDD;
        private System.Windows.Forms.Label HDDText;
        private System.Windows.Forms.Button PC2Create;
        private System.Windows.Forms.TextBox RAM2;
        private System.Windows.Forms.TextBox MHZ2;
        private System.Windows.Forms.TextBox Processor2;
        private System.Windows.Forms.Label Processor2Text;
        private System.Windows.Forms.Label RAM2Text;
        private System.Windows.Forms.Label MHZ2Text;
        private System.Windows.Forms.RichTextBox Info;
    }
}

