namespace SantaGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moon = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.hutDown = new System.Windows.Forms.PictureBox();
            this.treeDown = new System.Windows.Forms.PictureBox();
            this.santaSleigh = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.snowFlake = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hutDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaSleigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).BeginInit();
            this.SuspendLayout();
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(0, 0);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(120, 104);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 0;
            this.moon.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(1, 374);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(512, 78);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // hutDown
            // 
            this.hutDown.Image = ((System.Drawing.Image)(resources.GetObject("hutDown.Image")));
            this.hutDown.Location = new System.Drawing.Point(160, 299);
            this.hutDown.Name = "hutDown";
            this.hutDown.Size = new System.Drawing.Size(98, 95);
            this.hutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hutDown.TabIndex = 2;
            this.hutDown.TabStop = false;
            // 
            // treeDown
            // 
            this.treeDown.Image = ((System.Drawing.Image)(resources.GetObject("treeDown.Image")));
            this.treeDown.Location = new System.Drawing.Point(379, 299);
            this.treeDown.Name = "treeDown";
            this.treeDown.Size = new System.Drawing.Size(66, 88);
            this.treeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treeDown.TabIndex = 3;
            this.treeDown.TabStop = false;
            // 
            // santaSleigh
            // 
            this.santaSleigh.Image = ((System.Drawing.Image)(resources.GetObject("santaSleigh.Image")));
            this.santaSleigh.Location = new System.Drawing.Point(12, 189);
            this.santaSleigh.Name = "santaSleigh";
            this.santaSleigh.Size = new System.Drawing.Size(78, 44);
            this.santaSleigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santaSleigh.TabIndex = 4;
            this.santaSleigh.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(146, 51);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(155, 50);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // snowFlake
            // 
            this.snowFlake.Image = ((System.Drawing.Image)(resources.GetObject("snowFlake.Image")));
            this.snowFlake.Location = new System.Drawing.Point(336, 362);
            this.snowFlake.Name = "snowFlake";
            this.snowFlake.Size = new System.Drawing.Size(37, 32);
            this.snowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowFlake.TabIndex = 6;
            this.snowFlake.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(178, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 128);
            this.button1.TabIndex = 7;
            this.button1.Text = "PLAY AGAIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.snowFlake);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.santaSleigh);
            this.Controls.Add(this.treeDown);
            this.Controls.Add(this.hutDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.moon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hutDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santaSleigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowFlake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox hutDown;
        private System.Windows.Forms.PictureBox treeDown;
        private System.Windows.Forms.PictureBox santaSleigh;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox snowFlake;
        private System.Windows.Forms.Button button1;
    }
}

