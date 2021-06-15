
namespace WindowsFormsApp6._2
{
    partial class Form2
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
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.OriginCountryLbl = new System.Windows.Forms.Label();
            this.ProductCostLbl = new System.Windows.Forms.Label();
            this.ProductNameTxtB = new System.Windows.Forms.TextBox();
            this.OriginCountryTxtB = new System.Windows.Forms.TextBox();
            this.ProductCostTxtB = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.CANCELbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductNameLbl.Location = new System.Drawing.Point(29, 36);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(116, 18);
            this.ProductNameLbl.TabIndex = 0;
            this.ProductNameLbl.Text = "Product Name";
            // 
            // OriginCountryLbl
            // 
            this.OriginCountryLbl.AutoSize = true;
            this.OriginCountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginCountryLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OriginCountryLbl.Location = new System.Drawing.Point(29, 120);
            this.OriginCountryLbl.Name = "OriginCountryLbl";
            this.OriginCountryLbl.Size = new System.Drawing.Size(117, 18);
            this.OriginCountryLbl.TabIndex = 1;
            this.OriginCountryLbl.Text = "Origin Country";
            // 
            // ProductCostLbl
            // 
            this.ProductCostLbl.AutoSize = true;
            this.ProductCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductCostLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductCostLbl.Location = new System.Drawing.Point(29, 219);
            this.ProductCostLbl.Name = "ProductCostLbl";
            this.ProductCostLbl.Size = new System.Drawing.Size(108, 18);
            this.ProductCostLbl.TabIndex = 2;
            this.ProductCostLbl.Text = "Product Cost";
            // 
            // ProductNameTxtB
            // 
            this.ProductNameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameTxtB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ProductNameTxtB.Location = new System.Drawing.Point(32, 68);
            this.ProductNameTxtB.Name = "ProductNameTxtB";
            this.ProductNameTxtB.Size = new System.Drawing.Size(198, 29);
            this.ProductNameTxtB.TabIndex = 3;
            // 
            // OriginCountryTxtB
            // 
            this.OriginCountryTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginCountryTxtB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.OriginCountryTxtB.Location = new System.Drawing.Point(32, 159);
            this.OriginCountryTxtB.Name = "OriginCountryTxtB";
            this.OriginCountryTxtB.Size = new System.Drawing.Size(198, 29);
            this.OriginCountryTxtB.TabIndex = 4;
            // 
            // ProductCostTxtB
            // 
            this.ProductCostTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductCostTxtB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ProductCostTxtB.Location = new System.Drawing.Point(32, 260);
            this.ProductCostTxtB.Name = "ProductCostTxtB";
            this.ProductCostTxtB.Size = new System.Drawing.Size(198, 29);
            this.ProductCostTxtB.TabIndex = 5;
            // 
            // OKbtn
            // 
            this.OKbtn.AutoSize = true;
            this.OKbtn.Location = new System.Drawing.Point(32, 321);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 6;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // CANCELbtn
            // 
            this.CANCELbtn.AutoSize = true;
            this.CANCELbtn.Location = new System.Drawing.Point(155, 321);
            this.CANCELbtn.Name = "CANCELbtn";
            this.CANCELbtn.Size = new System.Drawing.Size(75, 23);
            this.CANCELbtn.TabIndex = 7;
            this.CANCELbtn.Text = "Cancel";
            this.CANCELbtn.UseVisualStyleBackColor = true;
            this.CANCELbtn.Click += new System.EventHandler(this.CANCELbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(343, 372);
            this.Controls.Add(this.CANCELbtn);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.ProductCostTxtB);
            this.Controls.Add(this.OriginCountryTxtB);
            this.Controls.Add(this.ProductNameTxtB);
            this.Controls.Add(this.ProductCostLbl);
            this.Controls.Add(this.OriginCountryLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label OriginCountryLbl;
        private System.Windows.Forms.Label ProductCostLbl;
        private System.Windows.Forms.TextBox ProductNameTxtB;
        private System.Windows.Forms.TextBox OriginCountryTxtB;
        private System.Windows.Forms.TextBox ProductCostTxtB;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button CANCELbtn;
    }
}