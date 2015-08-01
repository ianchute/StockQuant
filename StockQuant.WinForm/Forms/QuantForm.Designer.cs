namespace StockQuant.WinForm.Forms
{
    partial class QuantForm
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.btnQuant = new System.Windows.Forms.Button();
            this.txtPlTable = new System.Windows.Forms.RichTextBox();
            this.txtBuyFees = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(20, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGross);
            this.panel1.Controls.Add(this.lblGross);
            this.panel1.Controls.Add(this.btnQuant);
            this.panel1.Controls.Add(this.txtVolume);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 142);
            this.panel1.TabIndex = 1;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(20, 48);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 13);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "Volume";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(76, 16);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(76, 45);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(141, 20);
            this.txtVolume.TabIndex = 3;
            // 
            // btnQuant
            // 
            this.btnQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuant.Location = new System.Drawing.Point(23, 100);
            this.btnQuant.Name = "btnQuant";
            this.btnQuant.Size = new System.Drawing.Size(194, 32);
            this.btnQuant.TabIndex = 5;
            this.btnQuant.Text = "Quant!";
            this.btnQuant.UseVisualStyleBackColor = true;
            this.btnQuant.Click += new System.EventHandler(this.btnQuant_Click);
            // 
            // txtPlTable
            // 
            this.txtPlTable.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlTable.Location = new System.Drawing.Point(13, 161);
            this.txtPlTable.Name = "txtPlTable";
            this.txtPlTable.Size = new System.Drawing.Size(570, 119);
            this.txtPlTable.TabIndex = 2;
            this.txtPlTable.Text = "";
            // 
            // txtBuyFees
            // 
            this.txtBuyFees.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyFees.Location = new System.Drawing.Point(261, 12);
            this.txtBuyFees.Name = "txtBuyFees";
            this.txtBuyFees.Size = new System.Drawing.Size(322, 143);
            this.txtBuyFees.TabIndex = 3;
            this.txtBuyFees.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(22, 77);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(39, 13);
            this.lblGross.TabIndex = 6;
            this.lblGross.Text = "Gross";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(76, 74);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(141, 20);
            this.txtGross.TabIndex = 7;
            // 
            // QuantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 321);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBuyFees);
            this.Controls.Add(this.txtPlTable);
            this.Controls.Add(this.panel1);
            this.Name = "QuantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuantForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtPrice;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button btnQuant;
        private System.Windows.Forms.RichTextBox txtPlTable;
        private System.Windows.Forms.RichTextBox txtBuyFees;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label lblGross;
    }
}