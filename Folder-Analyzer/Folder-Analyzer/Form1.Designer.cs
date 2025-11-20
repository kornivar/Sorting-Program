namespace Folder_Analyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PathInput = new System.Windows.Forms.TextBox();
            this.RichBox = new System.Windows.Forms.RichTextBox();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathInput
            // 
            this.PathInput.Location = new System.Drawing.Point(151, 163);
            this.PathInput.Multiline = true;
            this.PathInput.Name = "PathInput";
            this.PathInput.Size = new System.Drawing.Size(236, 31);
            this.PathInput.TabIndex = 0;
            this.PathInput.TextChanged += new System.EventHandler(this.PathInput_TextChanged);
            // 
            // RichBox
            // 
            this.RichBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RichBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.RichBox.Location = new System.Drawing.Point(12, 200);
            this.RichBox.Name = "RichBox";
            this.RichBox.Size = new System.Drawing.Size(705, 823);
            this.RichBox.TabIndex = 1;
            this.RichBox.Text = "";
            this.RichBox.TextChanged += new System.EventHandler(this.RichBox_TextChanged);
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalyzeButton.Location = new System.Drawing.Point(37, 163);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(108, 31);
            this.AnalyzeButton.TabIndex = 2;
            this.AnalyzeButton.Text = "Move all files";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 1035);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.RichBox);
            this.Controls.Add(this.PathInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathInput;
        private System.Windows.Forms.RichTextBox RichBox;
        private System.Windows.Forms.Button AnalyzeButton;
    }
}

