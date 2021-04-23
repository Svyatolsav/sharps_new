
namespace Task2
{
    partial class MainForm
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
            this.WorkingPath = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputLabelN = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.InputN = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.OutputLabelR = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WorkingPath
            // 
            this.WorkingPath.Enabled = false;
            this.WorkingPath.Location = new System.Drawing.Point(126, 13);
            this.WorkingPath.Name = "WorkingPath";
            this.WorkingPath.Size = new System.Drawing.Size(884, 22);
            this.WorkingPath.TabIndex = 0;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(12, 12);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(108, 23);
            this.SelectFolder.TabIndex = 1;
            this.SelectFolder.Text = "Select Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(77, 54);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(43, 17);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "Input:";
            // 
            // InputLabelN
            // 
            this.InputLabelN.AutoSize = true;
            this.InputLabelN.Location = new System.Drawing.Point(98, 91);
            this.InputLabelN.Name = "InputLabelN";
            this.InputLabelN.Size = new System.Drawing.Size(22, 17);
            this.InputLabelN.TabIndex = 3;
            this.InputLabelN.Text = "N:";
            // 
            // Input
            // 
            this.Input.Enabled = false;
            this.Input.Location = new System.Drawing.Point(126, 51);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(884, 22);
            this.Input.TabIndex = 4;
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(126, 88);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(884, 22);
            this.InputN.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 162);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(108, 43);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // OutputLabelR
            // 
            this.OutputLabelR.AutoSize = true;
            this.OutputLabelR.Location = new System.Drawing.Point(55, 125);
            this.OutputLabelR.Name = "OutputLabelR";
            this.OutputLabelR.Size = new System.Drawing.Size(65, 17);
            this.OutputLabelR.TabIndex = 8;
            this.OutputLabelR.Text = "OutputR:";
            // 
            // OutputR
            // 
            this.Output.Enabled = false;
            this.Output.Location = new System.Drawing.Point(126, 122);
            this.Output.Name = "OutputR";
            this.Output.Size = new System.Drawing.Size(884, 22);
            this.Output.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 217);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OutputLabelR);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.InputLabelN);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.WorkingPath);
            this.MaximumSize = new System.Drawing.Size(1040, 264);
            this.MinimumSize = new System.Drawing.Size(1040, 264);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WorkingPath;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label InputLabelN;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox InputN;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label OutputLabelR;
        private System.Windows.Forms.TextBox Output;
    }
}

