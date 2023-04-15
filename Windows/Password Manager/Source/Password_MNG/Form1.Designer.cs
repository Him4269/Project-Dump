namespace Password_MNG
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Heading = new System.Windows.Forms.Label();
            this.Error_Text = new System.Windows.Forms.Label();
            this.Load_TEST = new System.Windows.Forms.Button();
            this.Tima_Text = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Pass_Gen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.Font = new System.Drawing.Font("ROG Fonts", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Heading.ForeColor = System.Drawing.Color.White;
            this.Heading.Location = new System.Drawing.Point(2, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(306, 25);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Password Manager";
            // 
            // Error_Text
            // 
            this.Error_Text.AutoEllipsis = true;
            this.Error_Text.BackColor = System.Drawing.Color.Maroon;
            this.Error_Text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Error_Text.ForeColor = System.Drawing.Color.Transparent;
            this.Error_Text.Location = new System.Drawing.Point(2, 43);
            this.Error_Text.Name = "Error_Text";
            this.Error_Text.Size = new System.Drawing.Size(306, 47);
            this.Error_Text.TabIndex = 1;
            this.Error_Text.Text = "Error: password.txt doesnt exits in current directory. Creating file...";
            this.Error_Text.Visible = false;
            // 
            // Load_TEST
            // 
            this.Load_TEST.Location = new System.Drawing.Point(177, 93);
            this.Load_TEST.Name = "Load_TEST";
            this.Load_TEST.Size = new System.Drawing.Size(122, 23);
            this.Load_TEST.TabIndex = 2;
            this.Load_TEST.Text = "Load Passwords";
            this.Load_TEST.UseVisualStyleBackColor = true;
            this.Load_TEST.Click += new System.EventHandler(this.Load_TEST_Click);
            // 
            // Tima_Text
            // 
            this.Tima_Text.AutoSize = true;
            this.Tima_Text.BackColor = System.Drawing.Color.Black;
            this.Tima_Text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tima_Text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Tima_Text.Location = new System.Drawing.Point(12, 97);
            this.Tima_Text.Name = "Tima_Text";
            this.Tima_Text.Size = new System.Drawing.Size(66, 21);
            this.Tima_Text.TabIndex = 3;
            this.Tima_Text.Text = "Timer: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Pass_Gen
            // 
            this.Pass_Gen.Location = new System.Drawing.Point(2, 339);
            this.Pass_Gen.Name = "Pass_Gen";
            this.Pass_Gen.Size = new System.Drawing.Size(126, 23);
            this.Pass_Gen.TabIndex = 4;
            this.Pass_Gen.Text = "Generate Password";
            this.Pass_Gen.UseVisualStyleBackColor = true;
            this.Pass_Gen.Click += new System.EventHandler(this.Pass_Gen_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 364);
            this.Controls.Add(this.Pass_Gen);
            this.Controls.Add(this.Tima_Text);
            this.Controls.Add(this.Load_TEST);
            this.Controls.Add(this.Error_Text);
            this.Controls.Add(this.Heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Manager";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Heading;
        private Label Error_Text;
        private Button Load_TEST;
        private Label Tima_Text;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button Pass_Gen;
    }
}