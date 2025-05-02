
namespace production_worker_employee
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
            this.exit = new System.Windows.Forms.Button();
            this.show_employee = new System.Windows.Forms.Button();
            this.Hour_pay_rate = new System.Windows.Forms.TextBox();
            this.SNumber = new System.Windows.Forms.TextBox();
            this.EName = new System.Windows.Forms.TextBox();
            this.ENumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(456, 135);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // show_employee
            // 
            this.show_employee.Location = new System.Drawing.Point(456, 85);
            this.show_employee.Name = "show_employee";
            this.show_employee.Size = new System.Drawing.Size(75, 44);
            this.show_employee.TabIndex = 1;
            this.show_employee.Text = "show employee";
            this.show_employee.UseVisualStyleBackColor = true;
            this.show_employee.Click += new System.EventHandler(this.show_employee_Click);
            // 
            // Hour_pay_rate
            // 
            this.Hour_pay_rate.Location = new System.Drawing.Point(311, 173);
            this.Hour_pay_rate.Name = "Hour_pay_rate";
            this.Hour_pay_rate.Size = new System.Drawing.Size(100, 20);
            this.Hour_pay_rate.TabIndex = 2;
            // 
            // SNumber
            // 
            this.SNumber.Location = new System.Drawing.Point(311, 137);
            this.SNumber.Name = "SNumber";
            this.SNumber.Size = new System.Drawing.Size(100, 20);
            this.SNumber.TabIndex = 3;
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(311, 85);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(100, 20);
            this.EName.TabIndex = 4;
            // 
            // ENumber
            // 
            this.ENumber.Location = new System.Drawing.Point(311, 111);
            this.ENumber.Name = "ENumber";
            this.ENumber.Size = new System.Drawing.Size(100, 20);
            this.ENumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "employee name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "employee number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "shift number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hour pay rate";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(236, 223);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(252, 105);
            this.result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ENumber);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.SNumber);
            this.Controls.Add(this.Hour_pay_rate);
            this.Controls.Add(this.show_employee);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button show_employee;
        private System.Windows.Forms.TextBox Hour_pay_rate;
        private System.Windows.Forms.TextBox SNumber;
        private System.Windows.Forms.TextBox EName;
        private System.Windows.Forms.TextBox ENumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result;
    }
}

