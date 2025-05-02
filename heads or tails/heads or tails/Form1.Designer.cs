
namespace heads_or_tails
{
    partial class heads_or_tails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(heads_or_tails));
            this.heads_coin = new System.Windows.Forms.PictureBox();
            this.tails_coin = new System.Windows.Forms.PictureBox();
            this.show_heads = new System.Windows.Forms.Button();
            this.show_tails = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heads_coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tails_coin)).BeginInit();
            this.SuspendLayout();
            // 
            // heads_coin
            // 
            this.heads_coin.Image = ((System.Drawing.Image)(resources.GetObject("heads_coin.Image")));
            this.heads_coin.Location = new System.Drawing.Point(35, 52);
            this.heads_coin.Name = "heads_coin";
            this.heads_coin.Size = new System.Drawing.Size(169, 144);
            this.heads_coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heads_coin.TabIndex = 0;
            this.heads_coin.TabStop = false;
            // 
            // tails_coin
            // 
            this.tails_coin.Image = ((System.Drawing.Image)(resources.GetObject("tails_coin.Image")));
            this.tails_coin.Location = new System.Drawing.Point(554, 53);
            this.tails_coin.Name = "tails_coin";
            this.tails_coin.Size = new System.Drawing.Size(169, 143);
            this.tails_coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tails_coin.TabIndex = 1;
            this.tails_coin.TabStop = false;
            // 
            // show_heads
            // 
            this.show_heads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_heads.ForeColor = System.Drawing.Color.Black;
            this.show_heads.Location = new System.Drawing.Point(26, 241);
            this.show_heads.Name = "show_heads";
            this.show_heads.Size = new System.Drawing.Size(190, 65);
            this.show_heads.TabIndex = 2;
            this.show_heads.Text = "show heads ";
            this.show_heads.UseVisualStyleBackColor = true;
            this.show_heads.Click += new System.EventHandler(this.show_heads_Click);
            // 
            // show_tails
            // 
            this.show_tails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_tails.Location = new System.Drawing.Point(554, 241);
            this.show_tails.Name = "show_tails";
            this.show_tails.Size = new System.Drawing.Size(189, 65);
            this.show_tails.TabIndex = 3;
            this.show_tails.Text = "show tails";
            this.show_tails.UseVisualStyleBackColor = true;
            this.show_tails.Click += new System.EventHandler(this.show_tails_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(294, 241);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(189, 64);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // heads_or_tails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.show_tails);
            this.Controls.Add(this.show_heads);
            this.Controls.Add(this.tails_coin);
            this.Controls.Add(this.heads_coin);
            this.Name = "heads_or_tails";
            this.Text = "head_or_tails";
            ((System.ComponentModel.ISupportInitialize)(this.heads_coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tails_coin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox heads_coin;
        private System.Windows.Forms.PictureBox tails_coin;
        private System.Windows.Forms.Button show_heads;
        private System.Windows.Forms.Button show_tails;
        private System.Windows.Forms.Button Exit;
    }
}

