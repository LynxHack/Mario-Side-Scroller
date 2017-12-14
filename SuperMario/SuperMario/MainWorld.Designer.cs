namespace SuperMario
{
    partial class MainWorld
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
            this.ControlsTimer = new System.Windows.Forms.Timer(this.components);
            this.Character = new System.Windows.Forms.PictureBox();
            this.MarioStateTimer = new System.Windows.Forms.Timer(this.components);
            this.SetupButton = new System.Windows.Forms.Label();
            this.GumStickReadTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PlatformTest = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlsTimer
            // 
            this.ControlsTimer.Enabled = true;
            this.ControlsTimer.Interval = 1;
            this.ControlsTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Character.ErrorImage = null;
            this.Character.InitialImage = null;
            this.Character.Location = new System.Drawing.Point(136, 95);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(33, 64);
            this.Character.TabIndex = 0;
            this.Character.TabStop = false;
            // 
            // MarioStateTimer
            // 
            this.MarioStateTimer.Enabled = true;
            this.MarioStateTimer.Interval = 25;
            this.MarioStateTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // SetupButton
            // 
            this.SetupButton.AutoSize = true;
            this.SetupButton.Location = new System.Drawing.Point(12, 9);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(124, 13);
            this.SetupButton.TabIndex = 2;
            this.SetupButton.Text = "Press Shift + F1 to Setup";
            // 
            // GumStickReadTimer
            // 
            this.GumStickReadTimer.Interval = 1;
            this.GumStickReadTimer.Tick += new System.EventHandler(this.GumStickReadTimer_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::SuperMario.Properties.Resources.cloud2;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(701, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SuperMario.Properties.Resources.cloud1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(175, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // PlatformTest
            // 
            this.PlatformTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformTest.BackColor = System.Drawing.Color.Transparent;
            this.PlatformTest.BackgroundImage = global::SuperMario.Properties.Resources.Pipe;
            this.PlatformTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlatformTest.Location = new System.Drawing.Point(827, 327);
            this.PlatformTest.Name = "PlatformTest";
            this.PlatformTest.Size = new System.Drawing.Size(78, 101);
            this.PlatformTest.TabIndex = 1;
            this.PlatformTest.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SuperMario.Properties.Resources.Mario_Floor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 351);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SuperMario.Properties.Resources.Mario_Floor;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(539, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 351);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MainWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(839, 449);
            this.Controls.Add(this.SetupButton);
            this.Controls.Add(this.PlatformTest);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainWorld";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlatformTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.Timer ControlsTimer;
        private System.Windows.Forms.PictureBox PlatformTest;
        private System.Windows.Forms.Timer MarioStateTimer;
        private System.Windows.Forms.Label SetupButton;
        private System.Windows.Forms.Timer GumStickReadTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

