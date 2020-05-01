namespace HeadsOrTails
{
    partial class FormCoinToss
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
            this.buttonHeads = new System.Windows.Forms.Button();
            this.buttonTails = new System.Windows.Forms.Button();
            this.pictureBoxHeads = new System.Windows.Forms.PictureBox();
            this.pictureBoxTails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHeads
            // 
            this.buttonHeads.Location = new System.Drawing.Point(46, 248);
            this.buttonHeads.Name = "buttonHeads";
            this.buttonHeads.Size = new System.Drawing.Size(166, 23);
            this.buttonHeads.TabIndex = 0;
            this.buttonHeads.Text = "Show Heads";
            this.buttonHeads.UseVisualStyleBackColor = true;
            this.buttonHeads.Click += new System.EventHandler(this.buttonHeads_Click);
            // 
            // buttonTails
            // 
            this.buttonTails.Location = new System.Drawing.Point(234, 248);
            this.buttonTails.Name = "buttonTails";
            this.buttonTails.Size = new System.Drawing.Size(166, 23);
            this.buttonTails.TabIndex = 1;
            this.buttonTails.Text = "Show Tails";
            this.buttonTails.UseVisualStyleBackColor = true;
            this.buttonTails.Click += new System.EventHandler(this.buttonTails_Click);
            // 
            // pictureBoxHeads
            // 
            this.pictureBoxHeads.Image = global::HeadsOrTails.Properties.Resources.Heads1;
            this.pictureBoxHeads.Location = new System.Drawing.Point(46, 70);
            this.pictureBoxHeads.Name = "pictureBoxHeads";
            this.pictureBoxHeads.Size = new System.Drawing.Size(166, 156);
            this.pictureBoxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeads.TabIndex = 2;
            this.pictureBoxHeads.TabStop = false;
            this.pictureBoxHeads.Visible = false;
            // 
            // pictureBoxTails
            // 
            this.pictureBoxTails.Image = global::HeadsOrTails.Properties.Resources.Tails1;
            this.pictureBoxTails.Location = new System.Drawing.Point(234, 70);
            this.pictureBoxTails.Name = "pictureBoxTails";
            this.pictureBoxTails.Size = new System.Drawing.Size(166, 156);
            this.pictureBoxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTails.TabIndex = 3;
            this.pictureBoxTails.TabStop = false;
            this.pictureBoxTails.Visible = false;
            // 
            // FormCoinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 327);
            this.Controls.Add(this.pictureBoxTails);
            this.Controls.Add(this.pictureBoxHeads);
            this.Controls.Add(this.buttonTails);
            this.Controls.Add(this.buttonHeads);
            this.Name = "FormCoinToss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHeads;
        private System.Windows.Forms.Button buttonTails;
        private System.Windows.Forms.PictureBox pictureBoxHeads;
        private System.Windows.Forms.PictureBox pictureBoxTails;
    }
}

