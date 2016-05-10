namespace GemFallAlpha3
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnMatches = new System.Windows.Forms.Button();
            this.cbxLoop = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lblStableAttempts = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.tmrFillEmpty = new System.Windows.Forms.Timer(this.components);
            this.tmrMatches = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.tmrBestMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 414);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.button3);
            this.pnlOptions.Controls.Add(this.btnMatches);
            this.pnlOptions.Controls.Add(this.cbxLoop);
            this.pnlOptions.Controls.Add(this.button1);
            this.pnlOptions.Controls.Add(this.cbxAuto);
            this.pnlOptions.Controls.Add(this.button2);
            this.pnlOptions.Controls.Add(this.btnFill);
            this.pnlOptions.Controls.Add(this.lblStableAttempts);
            this.pnlOptions.Controls.Add(this.btnDown);
            this.pnlOptions.Location = new System.Drawing.Point(416, 11);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(202, 428);
            this.pnlOptions.TabIndex = 10;
            // 
            // btnMatches
            // 
            this.btnMatches.Location = new System.Drawing.Point(9, 268);
            this.btnMatches.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(176, 46);
            this.btnMatches.TabIndex = 4;
            this.btnMatches.Text = "Destory Matches";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            // 
            // cbxLoop
            // 
            this.cbxLoop.AutoSize = true;
            this.cbxLoop.Location = new System.Drawing.Point(90, 243);
            this.cbxLoop.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLoop.Name = "cbxLoop";
            this.cbxLoop.Size = new System.Drawing.Size(71, 24);
            this.cbxLoop.TabIndex = 8;
            this.cbxLoop.Text = "Loop";
            this.cbxLoop.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Location = new System.Drawing.Point(9, 243);
            this.cbxAuto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(69, 24);
            this.cbxAuto.TabIndex = 7;
            this.cbxAuto.Text = "Auto";
            this.cbxAuto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Stable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(9, 372);
            this.btnFill.Margin = new System.Windows.Forms.Padding(2);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(176, 46);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Fill Empty";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // lblStableAttempts
            // 
            this.lblStableAttempts.AutoSize = true;
            this.lblStableAttempts.Location = new System.Drawing.Point(14, 108);
            this.lblStableAttempts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStableAttempts.Name = "lblStableAttempts";
            this.lblStableAttempts.Size = new System.Drawing.Size(55, 20);
            this.lblStableAttempts.TabIndex = 3;
            this.lblStableAttempts.Text = "[times]";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(9, 320);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(176, 46);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Drop Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // tmrFillEmpty
            // 
            this.tmrFillEmpty.Interval = 300;
            this.tmrFillEmpty.Tick += new System.EventHandler(this.tmrFillEmpty_Tick);
            // 
            // tmrMatches
            // 
            this.tmrMatches.Interval = 300;
            this.tmrMatches.Tick += new System.EventHandler(this.tmrMatches_Tick);
            // 
            // tmrDown
            // 
            this.tmrDown.Interval = 300;
            this.tmrDown.Tick += new System.EventHandler(this.tmrDown_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 139);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 46);
            this.button3.TabIndex = 9;
            this.button3.Text = "Show Moves";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tmrBestMove
            // 
            this.tmrBestMove.Interval = 300;
            this.tmrBestMove.Tick += new System.EventHandler(this.tmrBestMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 456);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.CheckBox cbxLoop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxAuto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label lblStableAttempts;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.Timer tmrMatches;
        private System.Windows.Forms.Timer tmrFillEmpty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer tmrBestMove;
    }
}

