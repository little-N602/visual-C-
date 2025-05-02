
namespace tip__tax_and_total
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
            this.charges = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.chargetxt = new System.Windows.Forms.MaskedTextBox();
            this.labletip = new System.Windows.Forms.Label();
            this.labletex = new System.Windows.Forms.Label();
            this.labletotal = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // charges
            // 
            this.charges.AutoSize = true;
            this.charges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charges.Location = new System.Drawing.Point(6, 73);
            this.charges.Name = "charges";
            this.charges.Size = new System.Drawing.Size(119, 20);
            this.charges.TabIndex = 0;
            this.charges.Text = "Food charges";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.Location = new System.Drawing.Point(80, 114);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(29, 20);
            this.tip.TabIndex = 1;
            this.tip.Text = "tip";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(80, 147);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(33, 20);
            this.tax.TabIndex = 2;
            this.tax.Text = "tax";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(80, 180);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(45, 20);
            this.total.TabIndex = 3;
            this.total.Text = "total";
            // 
            // chargetxt
            // 
            this.chargetxt.Location = new System.Drawing.Point(146, 73);
            this.chargetxt.Name = "chargetxt";
            this.chargetxt.Size = new System.Drawing.Size(100, 20);
            this.chargetxt.TabIndex = 7;
            // 
            // labletip
            // 
            this.labletip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labletip.Location = new System.Drawing.Point(143, 111);
            this.labletip.Name = "labletip";
            this.labletip.Size = new System.Drawing.Size(103, 23);
            this.labletip.TabIndex = 8;
            // 
            // labletex
            // 
            this.labletex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labletex.Location = new System.Drawing.Point(143, 149);
            this.labletex.Name = "labletex";
            this.labletex.Size = new System.Drawing.Size(103, 24);
            this.labletex.TabIndex = 9;
            // 
            // labletotal
            // 
            this.labletotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labletotal.Location = new System.Drawing.Point(143, 182);
            this.labletotal.Name = "labletotal";
            this.labletotal.Size = new System.Drawing.Size(103, 23);
            this.labletotal.TabIndex = 10;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(50, 249);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(237, 249);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 371);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.labletotal);
            this.Controls.Add(this.labletex);
            this.Controls.Add(this.labletip);
            this.Controls.Add(this.chargetxt);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.charges);
            this.Name = "Form1";
            this.Text = "tip, tax, total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charges;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.MaskedTextBox chargetxt;
        private System.Windows.Forms.Label labletip;
        private System.Windows.Forms.Label labletex;
        private System.Windows.Forms.Label labletotal;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button exit;
    }
}

