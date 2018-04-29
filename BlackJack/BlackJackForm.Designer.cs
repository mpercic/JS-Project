namespace BlackJack
{
    partial class BlackJackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.buttonDeal = new System.Windows.Forms.Button();
            this.buttonUlog1 = new System.Windows.Forms.Button();
            this.buttonUlog5 = new System.Windows.Forms.Button();
            this.buttonUlog10 = new System.Windows.Forms.Button();
            this.buttonUlog20 = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUlog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStay = new System.Windows.Forms.Button();
            this.labelIshod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeal
            // 
            this.buttonDeal.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDeal.Enabled = false;
            this.buttonDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeal.Location = new System.Drawing.Point(221, 468);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(86, 65);
            this.buttonDeal.TabIndex = 0;
            this.buttonDeal.Text = "Deal";
            this.buttonDeal.UseVisualStyleBackColor = false;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // buttonUlog1
            // 
            this.buttonUlog1.Location = new System.Drawing.Point(631, 482);
            this.buttonUlog1.Name = "buttonUlog1";
            this.buttonUlog1.Size = new System.Drawing.Size(53, 40);
            this.buttonUlog1.TabIndex = 1;
            this.buttonUlog1.Text = "1";
            this.buttonUlog1.UseVisualStyleBackColor = true;
            this.buttonUlog1.Click += new System.EventHandler(this.povecajUlog_Click);
            // 
            // buttonUlog5
            // 
            this.buttonUlog5.Location = new System.Drawing.Point(690, 483);
            this.buttonUlog5.Name = "buttonUlog5";
            this.buttonUlog5.Size = new System.Drawing.Size(53, 40);
            this.buttonUlog5.TabIndex = 2;
            this.buttonUlog5.Text = "5";
            this.buttonUlog5.UseVisualStyleBackColor = true;
            this.buttonUlog5.Click += new System.EventHandler(this.povecajUlog_Click);
            // 
            // buttonUlog10
            // 
            this.buttonUlog10.Location = new System.Drawing.Point(749, 483);
            this.buttonUlog10.Name = "buttonUlog10";
            this.buttonUlog10.Size = new System.Drawing.Size(53, 40);
            this.buttonUlog10.TabIndex = 3;
            this.buttonUlog10.Text = "10";
            this.buttonUlog10.UseVisualStyleBackColor = true;
            this.buttonUlog10.Click += new System.EventHandler(this.povecajUlog_Click);
            // 
            // buttonUlog20
            // 
            this.buttonUlog20.Location = new System.Drawing.Point(808, 483);
            this.buttonUlog20.Name = "buttonUlog20";
            this.buttonUlog20.Size = new System.Drawing.Size(53, 40);
            this.buttonUlog20.TabIndex = 4;
            this.buttonUlog20.Text = "20";
            this.buttonUlog20.UseVisualStyleBackColor = true;
            this.buttonUlog20.Click += new System.EventHandler(this.povecajUlog_Click);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Enabled = false;
            this.textBoxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMoney.Location = new System.Drawing.Point(132, 33);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(92, 29);
            this.textBoxMoney.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Balance:";
            // 
            // textBoxUlog
            // 
            this.textBoxUlog.Enabled = false;
            this.textBoxUlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUlog.Location = new System.Drawing.Point(132, 79);
            this.textBoxUlog.Name = "textBoxUlog";
            this.textBoxUlog.Size = new System.Drawing.Size(92, 29);
            this.textBoxUlog.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bet:";
            // 
            // buttonHit
            // 
            this.buttonHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHit.Location = new System.Drawing.Point(42, 394);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(76, 39);
            this.buttonHit.TabIndex = 11;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Visible = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStay
            // 
            this.buttonStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStay.Location = new System.Drawing.Point(42, 455);
            this.buttonStay.Name = "buttonStay";
            this.buttonStay.Size = new System.Drawing.Size(76, 39);
            this.buttonStay.TabIndex = 12;
            this.buttonStay.Text = "Stay";
            this.buttonStay.UseVisualStyleBackColor = true;
            this.buttonStay.Visible = false;
            this.buttonStay.Click += new System.EventHandler(this.buttonStay_Click);
            // 
            // labelIshod
            // 
            this.labelIshod.AutoSize = true;
            this.labelIshod.BackColor = System.Drawing.Color.White;
            this.labelIshod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIshod.Location = new System.Drawing.Point(362, 215);
            this.labelIshod.Name = "labelIshod";
            this.labelIshod.Size = new System.Drawing.Size(134, 37);
            this.labelIshod.TabIndex = 13;
            this.labelIshod.Text = "Pobjeda";
            this.labelIshod.Visible = false;
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 535);
            this.Controls.Add(this.labelIshod);
            this.Controls.Add(this.buttonStay);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.buttonUlog20);
            this.Controls.Add(this.buttonUlog10);
            this.Controls.Add(this.buttonUlog5);
            this.Controls.Add(this.buttonUlog1);
            this.Controls.Add(this.buttonDeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlackJackForm";
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Button buttonUlog1;
        private System.Windows.Forms.Button buttonUlog5;
        private System.Windows.Forms.Button buttonUlog10;
        private System.Windows.Forms.Button buttonUlog20;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStay;
        private System.Windows.Forms.Label labelIshod;
    }
}

