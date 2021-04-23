
namespace Task8
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
            try
            {
                base.Dispose(disposing);
            } catch
            {

            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBus = new System.Windows.Forms.Button();
            this.Pass1 = new System.Windows.Forms.Button();
            this.Pass2 = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AddBus
            // 
            this.AddBus.BackColor = System.Drawing.Color.Honeydew;
            this.AddBus.ForeColor = System.Drawing.Color.Purple;
            this.AddBus.Location = new System.Drawing.Point(8, 12);
            this.AddBus.Name = "AddBus";
            this.AddBus.Size = new System.Drawing.Size(153, 129);
            this.AddBus.TabIndex = 1;
            this.AddBus.Text = "Автобус";
            this.AddBus.UseVisualStyleBackColor = false;
            this.AddBus.Click += new System.EventHandler(this.AddBus_Click);
            // 
            // Pass1
            // 
            this.Pass1.BackColor = System.Drawing.Color.Honeydew;
            this.Pass1.ForeColor = System.Drawing.Color.Purple;
            this.Pass1.Location = new System.Drawing.Point(8, 284);
            this.Pass1.Name = "Pass1";
            this.Pass1.Size = new System.Drawing.Size(153, 129);
            this.Pass1.TabIndex = 2;
            this.Pass1.Text = "Пассажир I";
            this.Pass1.UseVisualStyleBackColor = false;
            this.Pass1.Click += new System.EventHandler(this.Pass1_Click);
            // 
            // Pass2
            // 
            this.Pass2.BackColor = System.Drawing.Color.Honeydew;
            this.Pass2.ForeColor = System.Drawing.Color.Purple;
            this.Pass2.Location = new System.Drawing.Point(8, 419);
            this.Pass2.Name = "Pass2";
            this.Pass2.Size = new System.Drawing.Size(153, 129);
            this.Pass2.TabIndex = 3;
            this.Pass2.Text = "Пассажир II";
            this.Pass2.UseVisualStyleBackColor = false;
            this.Pass2.Click += new System.EventHandler(this.Pass2_Click);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(167, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(600, 700);
            this.Panel.TabIndex = 0;
            this.Panel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Panel_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.AddBus);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.Pass1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBus;
        private System.Windows.Forms.Button Pass1;
        private System.Windows.Forms.Button Pass2;
        private System.Windows.Forms.Panel Panel;
    }
}

