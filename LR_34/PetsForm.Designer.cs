namespace LR_34
{
    partial class PetsForm
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
            this.petsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.petsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // petsDataGridView
            // 
            this.petsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.petsDataGridView.Name = "petsDataGridView";
            this.petsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.petsDataGridView.TabIndex = 0;
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.petsDataGridView);
            this.Name = "PetsForm";
            this.Text = "PetsForm";
            this.Load += new System.EventHandler(this.PetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView petsDataGridView;
    }
}