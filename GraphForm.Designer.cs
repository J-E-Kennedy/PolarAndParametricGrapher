namespace MoveByEquationForms
{
    partial class moveBoxEquationForm
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
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.timerT = new System.Windows.Forms.Timer(this.components);
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.tTimeTextBox = new System.Windows.Forms.TextBox();
            this.timestepLabel = new System.Windows.Forms.Label();
            this.tickRateLabel = new System.Windows.Forms.Label();
            this.tickTextBox = new System.Windows.Forms.TextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.elaspedTimeLabel = new System.Windows.Forms.Label();
            this.currentTLabel = new System.Windows.Forms.Label();
            this.curveRadio = new System.Windows.Forms.RadioButton();
            this.lineRadio = new System.Windows.Forms.RadioButton();
            this.drawModeGroupBox = new System.Windows.Forms.GroupBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.defineNewButton = new System.Windows.Forms.Button();
            this.trailLengthLabel = new System.Windows.Forms.Label();
            this.trailLengthTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.drawModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BackColor = System.Drawing.Color.White;
            this.graphPictureBox.Location = new System.Drawing.Point(0, 0);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(1000, 1000);
            this.graphPictureBox.TabIndex = 0;
            this.graphPictureBox.TabStop = false;
            // 
            // timerT
            // 
            this.timerT.Enabled = true;
            this.timerT.Interval = 10;
            this.timerT.Tick += new System.EventHandler(this.timerT_Tick);
            // 
            // functionComboBox
            // 
            this.functionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Location = new System.Drawing.Point(1006, 12);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(156, 21);
            this.functionComboBox.TabIndex = 1;
            this.functionComboBox.SelectedIndexChanged += new System.EventHandler(this.functionComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1006, 68);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tTimeTextBox
            // 
            this.tTimeTextBox.Location = new System.Drawing.Point(1006, 164);
            this.tTimeTextBox.Name = "tTimeTextBox";
            this.tTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tTimeTextBox.TabIndex = 4;
            this.tTimeTextBox.Text = "0.1";
            this.tTimeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTimeTextBox_KeyDown);
            // 
            // timestepLabel
            // 
            this.timestepLabel.AutoSize = true;
            this.timestepLabel.Location = new System.Drawing.Point(1006, 145);
            this.timestepLabel.Name = "timestepLabel";
            this.timestepLabel.Size = new System.Drawing.Size(103, 13);
            this.timestepLabel.TabIndex = 5;
            this.timestepLabel.Text = "Change in T per tick";
            // 
            // tickRateLabel
            // 
            this.tickRateLabel.AutoSize = true;
            this.tickRateLabel.Location = new System.Drawing.Point(1006, 187);
            this.tickRateLabel.Name = "tickRateLabel";
            this.tickRateLabel.Size = new System.Drawing.Size(116, 13);
            this.tickRateLabel.TabIndex = 6;
            this.tickRateLabel.Text = "Rate of ticks (seconds)";
            // 
            // tickTextBox
            // 
            this.tickTextBox.Location = new System.Drawing.Point(1006, 203);
            this.tickTextBox.Name = "tickTextBox";
            this.tickTextBox.Size = new System.Drawing.Size(100, 20);
            this.tickTextBox.TabIndex = 7;
            this.tickTextBox.Text = "0.01";
            this.tickTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tickTextBox_KeyDown);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1087, 68);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // elaspedTimeLabel
            // 
            this.elaspedTimeLabel.AutoSize = true;
            this.elaspedTimeLabel.Location = new System.Drawing.Point(1007, 94);
            this.elaspedTimeLabel.Name = "elaspedTimeLabel";
            this.elaspedTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.elaspedTimeLabel.TabIndex = 9;
            this.elaspedTimeLabel.Text = "Elapsed Time:";
            // 
            // currentTLabel
            // 
            this.currentTLabel.AutoSize = true;
            this.currentTLabel.Location = new System.Drawing.Point(1027, 117);
            this.currentTLabel.Name = "currentTLabel";
            this.currentTLabel.Size = new System.Drawing.Size(54, 13);
            this.currentTLabel.TabIndex = 10;
            this.currentTLabel.Text = "Current T:";
            // 
            // curveRadio
            // 
            this.curveRadio.AutoSize = true;
            this.curveRadio.Checked = true;
            this.curveRadio.Location = new System.Drawing.Point(6, 19);
            this.curveRadio.Name = "curveRadio";
            this.curveRadio.Size = new System.Drawing.Size(53, 17);
            this.curveRadio.TabIndex = 11;
            this.curveRadio.TabStop = true;
            this.curveRadio.Text = "Curve";
            this.curveRadio.UseVisualStyleBackColor = true;
            this.curveRadio.CheckedChanged += new System.EventHandler(this.curveRadio_CheckedChanged);
            // 
            // lineRadio
            // 
            this.lineRadio.AutoSize = true;
            this.lineRadio.Location = new System.Drawing.Point(6, 42);
            this.lineRadio.Name = "lineRadio";
            this.lineRadio.Size = new System.Drawing.Size(45, 17);
            this.lineRadio.TabIndex = 12;
            this.lineRadio.Text = "Line";
            this.lineRadio.UseVisualStyleBackColor = true;
            this.lineRadio.CheckedChanged += new System.EventHandler(this.lineRadio_CheckedChanged);
            // 
            // drawModeGroupBox
            // 
            this.drawModeGroupBox.Controls.Add(this.curveRadio);
            this.drawModeGroupBox.Controls.Add(this.lineRadio);
            this.drawModeGroupBox.Location = new System.Drawing.Point(1015, 319);
            this.drawModeGroupBox.Name = "drawModeGroupBox";
            this.drawModeGroupBox.Size = new System.Drawing.Size(107, 100);
            this.drawModeGroupBox.TabIndex = 13;
            this.drawModeGroupBox.TabStop = false;
            this.drawModeGroupBox.Text = "Draw Mode";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(1007, 226);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(34, 13);
            this.scaleLabel.TabIndex = 14;
            this.scaleLabel.Text = "Scale";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(1006, 242);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(100, 20);
            this.scaleTextBox.TabIndex = 15;
            this.scaleTextBox.Text = "1";
            this.scaleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scaleTextBox_KeyDown);
            // 
            // defineNewButton
            // 
            this.defineNewButton.Location = new System.Drawing.Point(1009, 39);
            this.defineNewButton.Name = "defineNewButton";
            this.defineNewButton.Size = new System.Drawing.Size(153, 23);
            this.defineNewButton.TabIndex = 16;
            this.defineNewButton.Text = "Define New";
            this.defineNewButton.UseVisualStyleBackColor = true;
            this.defineNewButton.Click += new System.EventHandler(this.defineNewButton_Click);
            // 
            // trailLengthLabel
            // 
            this.trailLengthLabel.AutoSize = true;
            this.trailLengthLabel.Location = new System.Drawing.Point(1007, 265);
            this.trailLengthLabel.Name = "trailLengthLabel";
            this.trailLengthLabel.Size = new System.Drawing.Size(63, 13);
            this.trailLengthLabel.TabIndex = 14;
            this.trailLengthLabel.Text = "Trail Length";
            // 
            // trailLengthTextBox
            // 
            this.trailLengthTextBox.Location = new System.Drawing.Point(1006, 281);
            this.trailLengthTextBox.Name = "trailLengthTextBox";
            this.trailLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.trailLengthTextBox.TabIndex = 15;
            this.trailLengthTextBox.Text = "100";
            this.trailLengthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trailLengthTextBox_KeyDown);
            // 
            // moveBoxEquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1000);
            this.Controls.Add(this.defineNewButton);
            this.Controls.Add(this.trailLengthTextBox);
            this.Controls.Add(this.scaleTextBox);
            this.Controls.Add(this.trailLengthLabel);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.drawModeGroupBox);
            this.Controls.Add(this.currentTLabel);
            this.Controls.Add(this.elaspedTimeLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.tickTextBox);
            this.Controls.Add(this.tickRateLabel);
            this.Controls.Add(this.timestepLabel);
            this.Controls.Add(this.tTimeTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(this.graphPictureBox);
            this.Name = "moveBoxEquationForm";
            this.Text = "Move By Equation";
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.drawModeGroupBox.ResumeLayout(false);
            this.drawModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Timer timerT;
        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox tTimeTextBox;
        private System.Windows.Forms.Label timestepLabel;
        private System.Windows.Forms.Label tickRateLabel;
        private System.Windows.Forms.TextBox tickTextBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label elaspedTimeLabel;
        private System.Windows.Forms.Label currentTLabel;
        private System.Windows.Forms.RadioButton curveRadio;
        private System.Windows.Forms.RadioButton lineRadio;
        private System.Windows.Forms.GroupBox drawModeGroupBox;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Button defineNewButton;
        private System.Windows.Forms.Label trailLengthLabel;
        private System.Windows.Forms.TextBox trailLengthTextBox;
    }
}

