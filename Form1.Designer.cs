namespace Monitoring_of_retail_outlets
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
            this.List_Of_Outlets_LB = new System.Windows.Forms.ListBox();
            this.Add_Outlets_Button = new System.Windows.Forms.Button();
            this.Information_Outlets_DGV = new System.Windows.Forms.DataGridView();
            this.Outlets_Name_TB = new System.Windows.Forms.TextBox();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Config_Outlets_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Information_Outlets_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // List_Of_Outlets_LB
            // 
            this.List_Of_Outlets_LB.FormattingEnabled = true;
            this.List_Of_Outlets_LB.Location = new System.Drawing.Point(13, 13);
            this.List_Of_Outlets_LB.Name = "List_Of_Outlets_LB";
            this.List_Of_Outlets_LB.Size = new System.Drawing.Size(126, 264);
            this.List_Of_Outlets_LB.TabIndex = 0;
            // 
            // Add_Outlets_Button
            // 
            this.Add_Outlets_Button.Location = new System.Drawing.Point(13, 310);
            this.Add_Outlets_Button.Name = "Add_Outlets_Button";
            this.Add_Outlets_Button.Size = new System.Drawing.Size(126, 23);
            this.Add_Outlets_Button.TabIndex = 1;
            this.Add_Outlets_Button.Text = "button1";
            this.Add_Outlets_Button.UseVisualStyleBackColor = true;
            this.Add_Outlets_Button.Click += new System.EventHandler(this.Add_Outlets_Button_Click);
            // 
            // Information_Outlets_DGV
            // 
            this.Information_Outlets_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Information_Outlets_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Price_Product,
            this.Number_Product});
            this.Information_Outlets_DGV.Location = new System.Drawing.Point(146, 45);
            this.Information_Outlets_DGV.Name = "Information_Outlets_DGV";
            this.Information_Outlets_DGV.Size = new System.Drawing.Size(414, 258);
            this.Information_Outlets_DGV.TabIndex = 2;
            // 
            // Outlets_Name_TB
            // 
            this.Outlets_Name_TB.Location = new System.Drawing.Point(13, 284);
            this.Outlets_Name_TB.Name = "Outlets_Name_TB";
            this.Outlets_Name_TB.Size = new System.Drawing.Size(126, 20);
            this.Outlets_Name_TB.TabIndex = 3;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Товар";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Price_Product
            // 
            this.Price_Product.HeaderText = "Ціна";
            this.Price_Product.Name = "Price_Product";
            this.Price_Product.ReadOnly = true;
            // 
            // Number_Product
            // 
            this.Number_Product.HeaderText = "Кількість";
            this.Number_Product.Name = "Number_Product";
            this.Number_Product.ReadOnly = true;
            // 
            // Config_Outlets_Button
            // 
            this.Config_Outlets_Button.Location = new System.Drawing.Point(567, 45);
            this.Config_Outlets_Button.Name = "Config_Outlets_Button";
            this.Config_Outlets_Button.Size = new System.Drawing.Size(75, 23);
            this.Config_Outlets_Button.TabIndex = 4;
            this.Config_Outlets_Button.Text = "Config_Outlets_Button";
            this.Config_Outlets_Button.UseVisualStyleBackColor = true;
            this.Config_Outlets_Button.Click += new System.EventHandler(this.Config_Outlets_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 342);
            this.Controls.Add(this.Config_Outlets_Button);
            this.Controls.Add(this.Outlets_Name_TB);
            this.Controls.Add(this.Information_Outlets_DGV);
            this.Controls.Add(this.Add_Outlets_Button);
            this.Controls.Add(this.List_Of_Outlets_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Information_Outlets_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Of_Outlets_LB;
        private System.Windows.Forms.Button Add_Outlets_Button;
        private System.Windows.Forms.DataGridView Information_Outlets_DGV;
        private System.Windows.Forms.TextBox Outlets_Name_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Product;
        private System.Windows.Forms.Button Config_Outlets_Button;
    }
}

