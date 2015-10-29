namespace Black_jack
{
    partial class blackJack
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWinMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWinMessage
            // 
            this.lblWinMessage.AutoSize = true;
            this.lblWinMessage.BackColor = System.Drawing.Color.Silver;
            this.lblWinMessage.Font = new System.Drawing.Font("Headline One", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinMessage.ForeColor = System.Drawing.Color.Black;
            this.lblWinMessage.Location = new System.Drawing.Point(435, 79);
            this.lblWinMessage.Name = "lblWinMessage";
            this.lblWinMessage.Size = new System.Drawing.Size(133, 60);
            this.lblWinMessage.TabIndex = 0;
            this.lblWinMessage.Text = "Label";
            // 
            // blackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 511);
            this.Controls.Add(this.lblWinMessage);
            this.Name = "blackJack";
            this.Text = "BLACK JACK!!!";
            this.Load += new System.EventHandler(this.blackJack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWinMessage;
    }
}

