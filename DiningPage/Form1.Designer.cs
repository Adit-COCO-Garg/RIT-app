namespace DiningPage
{
    partial class diningForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diningLabel = new System.Windows.Forms.Label();
            this.tigerLabel = new System.Windows.Forms.Label();
            this.swipeLabel = new System.Windows.Forms.Label();
            this.exchangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(132, 302);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dining Dollars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiger Bucks";
            // 
            // diningLabel
            // 
            this.diningLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diningLabel.AutoSize = true;
            this.diningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diningLabel.Location = new System.Drawing.Point(54, 68);
            this.diningLabel.Name = "diningLabel";
            this.diningLabel.Size = new System.Drawing.Size(226, 55);
            this.diningLabel.TabIndex = 3;
            this.diningLabel.Text = "$2000.25";
            this.diningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diningLabel.Click += new System.EventHandler(this.DiningLabel_Click);
            // 
            // tigerLabel
            // 
            this.tigerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tigerLabel.AutoSize = true;
            this.tigerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tigerLabel.Location = new System.Drawing.Point(101, 156);
            this.tigerLabel.Name = "tigerLabel";
            this.tigerLabel.Size = new System.Drawing.Size(132, 55);
            this.tigerLabel.TabIndex = 4;
            this.tigerLabel.Text = "$500";
            this.tigerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // swipeLabel
            // 
            this.swipeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swipeLabel.AutoSize = true;
            this.swipeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swipeLabel.Location = new System.Drawing.Point(91, 230);
            this.swipeLabel.Name = "swipeLabel";
            this.swipeLabel.Size = new System.Drawing.Size(153, 20);
            this.swipeLabel.TabIndex = 5;
            this.swipeLabel.Text = "n Swipes Remaining";
            this.swipeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exchangeLabel
            // 
            this.exchangeLabel.AutoSize = true;
            this.exchangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeLabel.Location = new System.Drawing.Point(75, 264);
            this.exchangeLabel.Name = "exchangeLabel";
            this.exchangeLabel.Size = new System.Drawing.Size(181, 20);
            this.exchangeLabel.TabIndex = 6;
            this.exchangeLabel.Text = "n Exchanges Remaining";
            // 
            // diningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 354);
            this.ControlBox = false;
            this.Controls.Add(this.exchangeLabel);
            this.Controls.Add(this.swipeLabel);
            this.Controls.Add(this.tigerLabel);
            this.Controls.Add(this.diningLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Name = "diningForm";
            this.Text = "Dining";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label diningLabel;
        private System.Windows.Forms.Label tigerLabel;
        private System.Windows.Forms.Label swipeLabel;
        private System.Windows.Forms.Label exchangeLabel;
    }
}

