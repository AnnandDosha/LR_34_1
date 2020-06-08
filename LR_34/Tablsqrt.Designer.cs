namespace LR_34
{
    partial class Tablsqrt
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
            this.sqrtDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sqrtDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqrtDataGridView
            // 
            this.sqrtDataGridView.AllowUserToAddRows = false;
            this.sqrtDataGridView.AllowUserToDeleteRows = false;
            this.sqrtDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sqrtDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sqrtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqrtDataGridView.Location = new System.Drawing.Point(27, 31);
            this.sqrtDataGridView.Name = "sqrtDataGridView";
            this.sqrtDataGridView.ReadOnly = true;
            this.sqrtDataGridView.Size = new System.Drawing.Size(480, 385);
            this.sqrtDataGridView.TabIndex = 0;
            this.sqrtDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sqrtDataGridView_CellContentClick);
            // 
            // Tablsqrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sqrtDataGridView);
            this.Name = "Tablsqrt";
            this.Text = "Tablsqrt";
            this.Load += new System.EventHandler(this.Tablsqrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqrtDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sqrtDataGridView;
    }
}