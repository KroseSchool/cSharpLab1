namespace lab1KevinRose
{
    partial class lab1KevinRose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab1KevinRose));
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstPictureLabel = new System.Windows.Forms.Label();
            this.secondPictureLabel = new System.Windows.Forms.Label();
            this.thirdPictureLabel = new System.Windows.Forms.Label();
            this.fourthPictureLabel = new System.Windows.Forms.Label();
            this.fifthPictureLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fourthPictureBox = new System.Windows.Forms.PictureBox();
            this.fifthPictureBox = new System.Windows.Forms.PictureBox();
            this.firstPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdPictureBox = new System.Windows.Forms.PictureBox();
            this.secondPictureBox = new System.Windows.Forms.PictureBox();
            this.globalToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fourthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(237, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(327, 43);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Picture Boxes!";
            this.globalToolTip.SetToolTip(this.titleLabel, "This is a Title Label!");
            // 
            // firstPictureLabel
            // 
            this.firstPictureLabel.AutoSize = true;
            this.firstPictureLabel.Location = new System.Drawing.Point(77, 260);
            this.firstPictureLabel.Name = "firstPictureLabel";
            this.firstPictureLabel.Size = new System.Drawing.Size(54, 13);
            this.firstPictureLabel.TabIndex = 6;
            this.firstPictureLabel.Tag = "";
            this.firstPictureLabel.Text = "Press Me!";
            this.globalToolTip.SetToolTip(this.firstPictureLabel, "Picture One Label");
            this.firstPictureLabel.Click += new System.EventHandler(this.fristPictureLabel_Click);
            // 
            // secondPictureLabel
            // 
            this.secondPictureLabel.AutoSize = true;
            this.secondPictureLabel.Location = new System.Drawing.Point(225, 260);
            this.secondPictureLabel.Name = "secondPictureLabel";
            this.secondPictureLabel.Size = new System.Drawing.Size(54, 13);
            this.secondPictureLabel.TabIndex = 7;
            this.secondPictureLabel.Text = "Press Me!";
            this.globalToolTip.SetToolTip(this.secondPictureLabel, "Picture Two Label!");
            this.secondPictureLabel.Click += new System.EventHandler(this.secondPictureLabel_Click);
            // 
            // thirdPictureLabel
            // 
            this.thirdPictureLabel.AutoSize = true;
            this.thirdPictureLabel.Location = new System.Drawing.Point(373, 260);
            this.thirdPictureLabel.Name = "thirdPictureLabel";
            this.thirdPictureLabel.Size = new System.Drawing.Size(54, 13);
            this.thirdPictureLabel.TabIndex = 8;
            this.thirdPictureLabel.Text = "Press Me!";
            this.globalToolTip.SetToolTip(this.thirdPictureLabel, "Picture Three Label!");
            this.thirdPictureLabel.Click += new System.EventHandler(this.thirdPictureLabel_Click);
            // 
            // fourthPictureLabel
            // 
            this.fourthPictureLabel.AutoSize = true;
            this.fourthPictureLabel.Location = new System.Drawing.Point(521, 260);
            this.fourthPictureLabel.Name = "fourthPictureLabel";
            this.fourthPictureLabel.Size = new System.Drawing.Size(54, 13);
            this.fourthPictureLabel.TabIndex = 9;
            this.fourthPictureLabel.Text = "Press Me!";
            this.globalToolTip.SetToolTip(this.fourthPictureLabel, "Picture Four Label!");
            this.fourthPictureLabel.Click += new System.EventHandler(this.fourthPictureLabel_Click);
            // 
            // fifthPictureLabel
            // 
            this.fifthPictureLabel.AutoSize = true;
            this.fifthPictureLabel.Location = new System.Drawing.Point(669, 260);
            this.fifthPictureLabel.Name = "fifthPictureLabel";
            this.fifthPictureLabel.Size = new System.Drawing.Size(54, 13);
            this.fifthPictureLabel.TabIndex = 10;
            this.fifthPictureLabel.Text = "Press Me!";
            this.globalToolTip.SetToolTip(this.fifthPictureLabel, "Picture Five Label!");
            this.fifthPictureLabel.Click += new System.EventHandler(this.fifthPictureLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(215, 349);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "&Clear";
            this.globalToolTip.SetToolTip(this.clearButton, "Press this button to clear the pictures.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(511, 349);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "e&Xit";
            this.globalToolTip.SetToolTip(this.exitButton, "This button will Terminate the program after showing a dialogue box");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fourthPictureBox
            // 
            this.fourthPictureBox.Image = global::lab1KevinRose.Properties.Resources.bigfour;
            this.fourthPictureBox.Location = new System.Drawing.Point(506, 131);
            this.fourthPictureBox.Name = "fourthPictureBox";
            this.fourthPictureBox.Size = new System.Drawing.Size(84, 114);
            this.fourthPictureBox.TabIndex = 4;
            this.fourthPictureBox.TabStop = false;
            this.globalToolTip.SetToolTip(this.fourthPictureBox, "Picture Four!");
            this.fourthPictureBox.Visible = false;
            // 
            // fifthPictureBox
            // 
            this.fifthPictureBox.Image = global::lab1KevinRose.Properties.Resources.bigfive;
            this.fifthPictureBox.Location = new System.Drawing.Point(654, 131);
            this.fifthPictureBox.Name = "fifthPictureBox";
            this.fifthPictureBox.Size = new System.Drawing.Size(84, 114);
            this.fifthPictureBox.TabIndex = 3;
            this.fifthPictureBox.TabStop = false;
            this.globalToolTip.SetToolTip(this.fifthPictureBox, "Picture Five!");
            this.fifthPictureBox.Visible = false;
            // 
            // firstPictureBox
            // 
            this.firstPictureBox.Image = global::lab1KevinRose.Properties.Resources.bigone;
            this.firstPictureBox.Location = new System.Drawing.Point(62, 131);
            this.firstPictureBox.Name = "firstPictureBox";
            this.firstPictureBox.Size = new System.Drawing.Size(84, 114);
            this.firstPictureBox.TabIndex = 2;
            this.firstPictureBox.TabStop = false;
            this.globalToolTip.SetToolTip(this.firstPictureBox, "Picture One!");
            this.firstPictureBox.Visible = false;
            // 
            // thirdPictureBox
            // 
            this.thirdPictureBox.Image = global::lab1KevinRose.Properties.Resources.bigthree;
            this.thirdPictureBox.Location = new System.Drawing.Point(358, 131);
            this.thirdPictureBox.Name = "thirdPictureBox";
            this.thirdPictureBox.Size = new System.Drawing.Size(84, 114);
            this.thirdPictureBox.TabIndex = 1;
            this.thirdPictureBox.TabStop = false;
            this.globalToolTip.SetToolTip(this.thirdPictureBox, "Picture Three!");
            this.thirdPictureBox.Visible = false;
            // 
            // secondPictureBox
            // 
            this.secondPictureBox.Image = global::lab1KevinRose.Properties.Resources.bigtwo;
            this.secondPictureBox.Location = new System.Drawing.Point(210, 131);
            this.secondPictureBox.Name = "secondPictureBox";
            this.secondPictureBox.Size = new System.Drawing.Size(84, 114);
            this.secondPictureBox.TabIndex = 0;
            this.secondPictureBox.TabStop = false;
            this.globalToolTip.SetToolTip(this.secondPictureBox, "Picture Two!");
            this.secondPictureBox.Visible = false;
            // 
            // myPictureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fifthPictureLabel);
            this.Controls.Add(this.fourthPictureLabel);
            this.Controls.Add(this.thirdPictureLabel);
            this.Controls.Add(this.secondPictureLabel);
            this.Controls.Add(this.firstPictureLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.fourthPictureBox);
            this.Controls.Add(this.fifthPictureBox);
            this.Controls.Add(this.firstPictureBox);
            this.Controls.Add(this.thirdPictureBox);
            this.Controls.Add(this.secondPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myPictureBoxForm";
            this.Text = "Picture Box Program";
            ((System.ComponentModel.ISupportInitialize)(this.fourthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox secondPictureBox;
        private System.Windows.Forms.PictureBox thirdPictureBox;
        private System.Windows.Forms.PictureBox firstPictureBox;
        private System.Windows.Forms.PictureBox fifthPictureBox;
        private System.Windows.Forms.PictureBox fourthPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstPictureLabel;
        private System.Windows.Forms.Label secondPictureLabel;
        private System.Windows.Forms.Label thirdPictureLabel;
        private System.Windows.Forms.Label fourthPictureLabel;
        private System.Windows.Forms.Label fifthPictureLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip globalToolTip;
    }
}

