
namespace WindowsFormsApp6._2
{
    partial class Form1
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
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.AddProdButton = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.RemoveProductBtn = new System.Windows.Forms.Button();
            this.ClearListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductListBox
            // 
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.Location = new System.Drawing.Point(55, 12);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(300, 368);
            this.ProductListBox.TabIndex = 0;
            // 
            // AddProdButton
            // 
            this.AddProdButton.AutoSize = true;
            this.AddProdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProdButton.Location = new System.Drawing.Point(110, 386);
            this.AddProdButton.Name = "AddProdButton";
            this.AddProdButton.Size = new System.Drawing.Size(184, 28);
            this.AddProdButton.TabIndex = 1;
            this.AddProdButton.Text = "Add Product";
            this.AddProdButton.UseVisualStyleBackColor = true;
            this.AddProdButton.Click += new System.EventHandler(this.AddProdButton_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.AutoSize = true;
            this.EditProductBtn.Enabled = false;
            this.EditProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProductBtn.Location = new System.Drawing.Point(110, 420);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(184, 28);
            this.EditProductBtn.TabIndex = 2;
            this.EditProductBtn.Text = "Edit Product";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // RemoveProductBtn
            // 
            this.RemoveProductBtn.AutoSize = true;
            this.RemoveProductBtn.Enabled = false;
            this.RemoveProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveProductBtn.Location = new System.Drawing.Point(110, 454);
            this.RemoveProductBtn.Name = "RemoveProductBtn";
            this.RemoveProductBtn.Size = new System.Drawing.Size(184, 28);
            this.RemoveProductBtn.TabIndex = 3;
            this.RemoveProductBtn.Text = "Remove Product";
            this.RemoveProductBtn.UseVisualStyleBackColor = true;
            // 
            // ClearListBtn
            // 
            this.ClearListBtn.AutoSize = true;
            this.ClearListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearListBtn.Location = new System.Drawing.Point(110, 488);
            this.ClearListBtn.Name = "ClearListBtn";
            this.ClearListBtn.Size = new System.Drawing.Size(184, 28);
            this.ClearListBtn.TabIndex = 4;
            this.ClearListBtn.Text = "Clear List";
            this.ClearListBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(439, 524);
            this.Controls.Add(this.ClearListBtn);
            this.Controls.Add(this.RemoveProductBtn);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProdButton);
            this.Controls.Add(this.ProductListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.Button AddProdButton;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button RemoveProductBtn;
        private System.Windows.Forms.Button ClearListBtn;
    }
}

