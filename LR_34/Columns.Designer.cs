namespace LR_34
{
    partial class Columns
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
            this.columnsDataGridView = new System.Windows.Forms.DataGridView();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.В_корзину = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.columnsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // columnsDataGridView
            // 
            this.columnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код,
            this.Название,
            this.Цена,
            this.В_корзину});
            this.columnsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.columnsDataGridView.Name = "columnsDataGridView";
            this.columnsDataGridView.Size = new System.Drawing.Size(343, 276);
            this.columnsDataGridView.TabIndex = 0;
            this.columnsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Код
            // 
            this.Код.HeaderText = "Код";
            this.Код.Name = "Код";
            this.Код.Visible = false;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            // 
            // В_корзину
            // 
            this.В_корзину.HeaderText = "В корзину";
            this.В_корзину.Name = "В_корзину";
            // 
            // Columns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 276);
            this.Controls.Add(this.columnsDataGridView);
            this.Name = "Columns";
            this.Text = "Columns";
            this.Load += new System.EventHandler(this.Columns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columnsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView columnsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewCheckBoxColumn В_корзину;
    }
}