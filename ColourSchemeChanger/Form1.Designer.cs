namespace ColourSchemeChanger
{
    partial class Form1
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
            btnDark = new Button();
            BtnTestColour = new Button();
            btnBlue = new Button();
            btnLight = new Button();
            pnlTest = new Panel();
            SuspendLayout();
            // 
            // btnDark
            // 
            btnDark.Location = new Point(47, 68);
            btnDark.Name = "btnDark";
            btnDark.Size = new Size(141, 58);
            btnDark.TabIndex = 0;
            btnDark.Text = "Dark Mode";
            btnDark.UseVisualStyleBackColor = true;
            btnDark.Click += btnDark_Click;
            // 
            // BtnTestColour
            // 
            BtnTestColour.Location = new Point(573, 245);
            BtnTestColour.Name = "BtnTestColour";
            BtnTestColour.Size = new Size(75, 23);
            BtnTestColour.TabIndex = 1;
            BtnTestColour.Text = "Dark Mode";
            BtnTestColour.UseVisualStyleBackColor = true;
            // 
            // btnBlue
            // 
            btnBlue.Location = new Point(380, 68);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(137, 58);
            btnBlue.TabIndex = 2;
            btnBlue.Text = "Blue Mode";
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnLight
            // 
            btnLight.BackgroundImageLayout = ImageLayout.Center;
            btnLight.Location = new Point(216, 68);
            btnLight.Name = "btnLight";
            btnLight.Size = new Size(158, 58);
            btnLight.TabIndex = 3;
            btnLight.Text = "Light Mode";
            btnLight.UseVisualStyleBackColor = true;
            btnLight.Click += btnLight_Click;
            // 
            // pnlTest
            // 
            pnlTest.BackColor = SystemColors.ControlDark;
            pnlTest.Location = new Point(216, 264);
            pnlTest.Name = "pnlTest";
            pnlTest.Size = new Size(259, 125);
            pnlTest.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnTestColour);
            Controls.Add(pnlTest);
            Controls.Add(btnLight);
            Controls.Add(btnBlue);
            Controls.Add(btnDark);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDark;
        private Button BtnTestColour;
        private Button btnBlue;
        private Button btnLight;
        private Panel pnlTest;
    }
}
