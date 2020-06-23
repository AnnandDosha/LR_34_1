namespace LR_34
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
            this.columnsButton = new System.Windows.Forms.Button();
            this.petsButton = new System.Windows.Forms.Button();
            this.tablsqrtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnsButton
            // 
            this.columnsButton.Location = new System.Drawing.Point(148, 62);
            this.columnsButton.Name = "columnsButton";
            this.columnsButton.Size = new System.Drawing.Size(75, 23);
            this.columnsButton.TabIndex = 0;
            this.columnsButton.Text = "5.1";
            this.columnsButton.UseVisualStyleBackColor = true;
            this.columnsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // petsButton
            // 
            this.petsButton.Location = new System.Drawing.Point(148, 116);
            this.petsButton.Name = "petsButton";
            this.petsButton.Size = new System.Drawing.Size(75, 23);
            this.petsButton.TabIndex = 1;
            this.petsButton.Text = "5.2";
            this.petsButton.UseVisualStyleBackColor = true;
            this.petsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablsqrtButton
            // 
            this.tablsqrtButton.Location = new System.Drawing.Point(148, 171);
            this.tablsqrtButton.Name = "tablsqrtButton";
            this.tablsqrtButton.Size = new System.Drawing.Size(75, 23);
            this.tablsqrtButton.TabIndex = 2;
            this.tablsqrtButton.Text = "5.3";
            this.tablsqrtButton.UseVisualStyleBackColor = true;
            this.tablsqrtButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.Controls.Add(this.tablsqrtButton);
            this.Controls.Add(this.petsButton);
            this.Controls.Add(this.columnsButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button columnsButton;
        private System.Windows.Forms.Button petsButton;
        private System.Windows.Forms.Button tablsqrtButton;
    }
}

