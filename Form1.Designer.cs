namespace Activity_7
{
    partial class approximatePI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(approximatePI));
            this.titleLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.piLabel = new System.Windows.Forms.Label();
            this.piBox = new System.Windows.Forms.TextBox();
            this.termBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(453, 117);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(391, 69);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Approximate PI";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calcButton
            // 
            this.calcButton.Enabled = false;
            this.calcButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcButton.Location = new System.Drawing.Point(889, 222);
            this.calcButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(206, 54);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter number of terms:";
            // 
            // piLabel
            // 
            this.piLabel.AutoSize = true;
            this.piLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.piLabel.Location = new System.Drawing.Point(320, 372);
            this.piLabel.Name = "piLabel";
            this.piLabel.Size = new System.Drawing.Size(625, 46);
            this.piLabel.TabIndex = 5;
            this.piLabel.Text = "Approximate value of PI after 0 terms =";
            // 
            // piBox
            // 
            this.piBox.BackColor = System.Drawing.Color.RosyBrown;
            this.piBox.Enabled = false;
            this.piBox.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.piBox.ForeColor = System.Drawing.Color.White;
            this.piBox.Location = new System.Drawing.Point(337, 451);
            this.piBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.piBox.Name = "piBox";
            this.piBox.Size = new System.Drawing.Size(571, 53);
            this.piBox.TabIndex = 6;
            // 
            // termBox
            // 
            this.termBox.BackColor = System.Drawing.Color.RosyBrown;
            this.termBox.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.termBox.Location = new System.Drawing.Point(533, 222);
            this.termBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(331, 53);
            this.termBox.TabIndex = 7;
            this.termBox.TextChanged += new System.EventHandler(this.termBox_TextChanged);
            // 
            // approximatePI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Activity_7.Properties.Resources.frame_6636243_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.termBox);
            this.Controls.Add(this.piBox);
            this.Controls.Add(this.piLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "approximatePI";
            this.Text = "Approximate PI";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label titleLabel;
        private Button calcButton;
        private Label label2;
        private Label piLabel;
        private TextBox piBox;
        private TextBox termBox;
    }
}