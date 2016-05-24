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
            this.button3 = new System.Windows.Forms.Button();
            this.btnMatches = new System.Windows.Forms.Button();
            this.cbxLoop = new System.Windows.Forms.CheckBox();
            this.btnNewGrid = new System.Windows.Forms.Button();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.btnStableGrid = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lblStableAttempts = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.tmrFillEmpty = new System.Windows.Forms.Timer(this.components);
            this.tmrMatches = new System.Windows.Forms.Timer(this.components);
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.tmrBestMove = new System.Windows.Forms.Timer(this.components);
            this.lblTurnHero = new System.Windows.Forms.Label();
            this.lblMonsterTurn = new System.Windows.Forms.Label();
            this.ucManaPool2 = new GemFallAlpha3.ucManaPool();
            this.ucManaPool1 = new GemFallAlpha3.ucManaPool();
            this.ucUnit5 = new GemFallAlpha3.ucUnit();
            this.ucUnit6 = new GemFallAlpha3.ucUnit();
            this.ucUnit7 = new GemFallAlpha3.ucUnit();
            this.ucUnit8 = new GemFallAlpha3.ucUnit();
            this.ucUnit4 = new GemFallAlpha3.ucUnit();
            this.ucUnit3 = new GemFallAlpha3.ucUnit();
            this.ucUnit2 = new GemFallAlpha3.ucUnit();
            this.ucUnit1 = new GemFallAlpha3.ucUnit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(352, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 641);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.button3);
            this.pnlOptions.Controls.Add(this.btnMatches);
            this.pnlOptions.Controls.Add(this.cbxLoop);
            this.pnlOptions.Controls.Add(this.btnNewGrid);
            this.pnlOptions.Controls.Add(this.cbxAuto);
            this.pnlOptions.Controls.Add(this.btnStableGrid);
            this.pnlOptions.Controls.Add(this.btnFill);
            this.pnlOptions.Controls.Add(this.lblStableAttempts);
            this.pnlOptions.Controls.Add(this.btnDown);
            this.pnlOptions.Location = new System.Drawing.Point(344, 664);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(824, 136);
            this.pnlOptions.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Show Moves";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMatches
            // 
            this.btnMatches.Location = new System.Drawing.Point(8, 72);
            this.btnMatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(240, 50);
            this.btnMatches.TabIndex = 4;
            this.btnMatches.Text = "Destory Matches";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            // 
            // cbxLoop
            // 
            this.cbxLoop.AutoSize = true;
            this.cbxLoop.Checked = true;
            this.cbxLoop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLoop.Location = new System.Drawing.Point(680, 16);
            this.cbxLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLoop.Name = "cbxLoop";
            this.cbxLoop.Size = new System.Drawing.Size(117, 36);
            this.cbxLoop.TabIndex = 8;
            this.cbxLoop.Text = "Loop";
            this.cbxLoop.UseVisualStyleBackColor = true;
            // 
            // btnNewGrid
            // 
            this.btnNewGrid.Location = new System.Drawing.Point(7, 8);
            this.btnNewGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewGrid.Name = "btnNewGrid";
            this.btnNewGrid.Size = new System.Drawing.Size(121, 49);
            this.btnNewGrid.TabIndex = 1;
            this.btnNewGrid.Text = "New";
            this.btnNewGrid.UseVisualStyleBackColor = true;
            this.btnNewGrid.Click += new System.EventHandler(this.btnNewGrid_Click);
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Checked = true;
            this.cbxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAuto.Location = new System.Drawing.Point(536, 16);
            this.cbxAuto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(112, 36);
            this.cbxAuto.TabIndex = 7;
            this.cbxAuto.Text = "Auto";
            this.cbxAuto.UseVisualStyleBackColor = true;
            // 
            // btnStableGrid
            // 
            this.btnStableGrid.Location = new System.Drawing.Point(136, 8);
            this.btnStableGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStableGrid.Name = "btnStableGrid";
            this.btnStableGrid.Size = new System.Drawing.Size(121, 49);
            this.btnStableGrid.TabIndex = 2;
            this.btnStableGrid.Text = "Stable";
            this.btnStableGrid.UseVisualStyleBackColor = true;
            this.btnStableGrid.Click += new System.EventHandler(this.btnStableGrid_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(432, 72);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(168, 48);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Fill Empty";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // lblStableAttempts
            // 
            this.lblStableAttempts.AutoSize = true;
            this.lblStableAttempts.Location = new System.Drawing.Point(712, 80);
            this.lblStableAttempts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStableAttempts.Name = "lblStableAttempts";
            this.lblStableAttempts.Size = new System.Drawing.Size(99, 32);
            this.lblStableAttempts.TabIndex = 3;
            this.lblStableAttempts.Text = "[times]";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(256, 72);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(168, 49);
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
            // tmrBestMove
            // 
            this.tmrBestMove.Interval = 300;
            this.tmrBestMove.Tick += new System.EventHandler(this.tmrBestMove_Tick);
            // 
            // lblTurnHero
            // 
            this.lblTurnHero.BackColor = System.Drawing.Color.Red;
            this.lblTurnHero.Location = new System.Drawing.Point(24, 16);
            this.lblTurnHero.Name = "lblTurnHero";
            this.lblTurnHero.Size = new System.Drawing.Size(304, 24);
            this.lblTurnHero.TabIndex = 21;
            // 
            // lblMonsterTurn
            // 
            this.lblMonsterTurn.BackColor = System.Drawing.Color.Red;
            this.lblMonsterTurn.Location = new System.Drawing.Point(1080, 16);
            this.lblMonsterTurn.Name = "lblMonsterTurn";
            this.lblMonsterTurn.Size = new System.Drawing.Size(304, 24);
            this.lblMonsterTurn.TabIndex = 22;
            this.lblMonsterTurn.Visible = false;
            // 
            // ucManaPool2
            // 
            this.ucManaPool2.Location = new System.Drawing.Point(1080, 96);
            this.ucManaPool2.Name = "ucManaPool2";
            this.ucManaPool2.Size = new System.Drawing.Size(312, 68);
            this.ucManaPool2.TabIndex = 24;
            // 
            // ucManaPool1
            // 
            this.ucManaPool1.Location = new System.Drawing.Point(24, 96);
            this.ucManaPool1.Name = "ucManaPool1";
            this.ucManaPool1.Size = new System.Drawing.Size(312, 68);
            this.ucManaPool1.TabIndex = 23;
            // 
            // ucUnit5
            // 
            this.ucUnit5.BackColor = System.Drawing.Color.White;
            this.ucUnit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit5.Location = new System.Drawing.Point(1072, 512);
            this.ucUnit5.Name = "ucUnit5";
            this.ucUnit5.Size = new System.Drawing.Size(325, 104);
            this.ucUnit5.TabIndex = 18;
            // 
            // ucUnit6
            // 
            this.ucUnit6.BackColor = System.Drawing.Color.White;
            this.ucUnit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit6.Location = new System.Drawing.Point(1072, 400);
            this.ucUnit6.Name = "ucUnit6";
            this.ucUnit6.Size = new System.Drawing.Size(325, 104);
            this.ucUnit6.TabIndex = 17;
            // 
            // ucUnit7
            // 
            this.ucUnit7.BackColor = System.Drawing.Color.White;
            this.ucUnit7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit7.Location = new System.Drawing.Point(1072, 288);
            this.ucUnit7.Name = "ucUnit7";
            this.ucUnit7.Size = new System.Drawing.Size(325, 104);
            this.ucUnit7.TabIndex = 16;
            // 
            // ucUnit8
            // 
            this.ucUnit8.BackColor = System.Drawing.Color.White;
            this.ucUnit8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit8.Location = new System.Drawing.Point(1072, 176);
            this.ucUnit8.Name = "ucUnit8";
            this.ucUnit8.Size = new System.Drawing.Size(325, 104);
            this.ucUnit8.TabIndex = 15;
            // 
            // ucUnit4
            // 
            this.ucUnit4.BackColor = System.Drawing.Color.White;
            this.ucUnit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit4.Location = new System.Drawing.Point(16, 512);
            this.ucUnit4.Name = "ucUnit4";
            this.ucUnit4.Size = new System.Drawing.Size(325, 104);
            this.ucUnit4.TabIndex = 14;
            // 
            // ucUnit3
            // 
            this.ucUnit3.BackColor = System.Drawing.Color.White;
            this.ucUnit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit3.Location = new System.Drawing.Point(16, 400);
            this.ucUnit3.Name = "ucUnit3";
            this.ucUnit3.Size = new System.Drawing.Size(325, 104);
            this.ucUnit3.TabIndex = 13;
            // 
            // ucUnit2
            // 
            this.ucUnit2.BackColor = System.Drawing.Color.White;
            this.ucUnit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit2.Location = new System.Drawing.Point(16, 288);
            this.ucUnit2.Name = "ucUnit2";
            this.ucUnit2.Size = new System.Drawing.Size(325, 104);
            this.ucUnit2.TabIndex = 12;
            // 
            // ucUnit1
            // 
            this.ucUnit1.BackColor = System.Drawing.Color.White;
            this.ucUnit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucUnit1.Location = new System.Drawing.Point(16, 176);
            this.ucUnit1.Name = "ucUnit1";
            this.ucUnit1.Size = new System.Drawing.Size(325, 104);
            this.ucUnit1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 808);
            this.Controls.Add(this.ucManaPool2);
            this.Controls.Add(this.ucManaPool1);
            this.Controls.Add(this.lblMonsterTurn);
            this.Controls.Add(this.lblTurnHero);
            this.Controls.Add(this.ucUnit5);
            this.Controls.Add(this.ucUnit6);
            this.Controls.Add(this.ucUnit7);
            this.Controls.Add(this.ucUnit8);
            this.Controls.Add(this.ucUnit4);
            this.Controls.Add(this.ucUnit3);
            this.Controls.Add(this.ucUnit2);
            this.Controls.Add(this.ucUnit1);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button btnNewGrid;
        private System.Windows.Forms.CheckBox cbxAuto;
        private System.Windows.Forms.Button btnStableGrid;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label lblStableAttempts;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.Timer tmrMatches;
        private System.Windows.Forms.Timer tmrFillEmpty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer tmrBestMove;
        private ucUnit ucUnit1;
        private ucUnit ucUnit2;
        private ucUnit ucUnit3;
        private ucUnit ucUnit4;
        private ucUnit ucUnit5;
        private ucUnit ucUnit6;
        private ucUnit ucUnit7;
        private ucUnit ucUnit8;
        private System.Windows.Forms.Label lblTurnHero;
        private System.Windows.Forms.Label lblMonsterTurn;
        private ucManaPool ucManaPool1;
        private ucManaPool ucManaPool2;
    }
}

