namespace MoveByEquationForms
{
    partial class AddEquationForm
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
            this.firstFunctionTextBox = new System.Windows.Forms.TextBox();
            this.firstFunctionLabel = new System.Windows.Forms.Label();
            this.secondFunctionLabel = new System.Windows.Forms.Label();
            this.secondFunctionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.polarRadio = new System.Windows.Forms.RadioButton();
            this.parametricRadio = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstFunctionTextBox
            // 
            this.firstFunctionTextBox.Location = new System.Drawing.Point(45, 116);
            this.firstFunctionTextBox.Name = "firstFunctionTextBox";
            this.firstFunctionTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstFunctionTextBox.TabIndex = 0;
            // 
            // firstFunctionLabel
            // 
            this.firstFunctionLabel.AutoSize = true;
            this.firstFunctionLabel.Location = new System.Drawing.Point(11, 119);
            this.firstFunctionLabel.Name = "firstFunctionLabel";
            this.firstFunctionLabel.Size = new System.Drawing.Size(28, 13);
            this.firstFunctionLabel.TabIndex = 1;
            this.firstFunctionLabel.Text = "f(t) =";
            // 
            // secondFunctionLabel
            // 
            this.secondFunctionLabel.AutoSize = true;
            this.secondFunctionLabel.Location = new System.Drawing.Point(11, 150);
            this.secondFunctionLabel.Name = "secondFunctionLabel";
            this.secondFunctionLabel.Size = new System.Drawing.Size(21, 13);
            this.secondFunctionLabel.TabIndex = 2;
            this.secondFunctionLabel.Text = "y =";
            // 
            // secondFunctionTextBox
            // 
            this.secondFunctionTextBox.Location = new System.Drawing.Point(45, 150);
            this.secondFunctionTextBox.Name = "secondFunctionTextBox";
            this.secondFunctionTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondFunctionTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(45, 188);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // polarRadio
            // 
            this.polarRadio.AutoSize = true;
            this.polarRadio.Location = new System.Drawing.Point(235, 115);
            this.polarRadio.Name = "polarRadio";
            this.polarRadio.Size = new System.Drawing.Size(49, 17);
            this.polarRadio.TabIndex = 5;
            this.polarRadio.Text = "Polar";
            this.polarRadio.UseVisualStyleBackColor = true;
            this.polarRadio.CheckedChanged += new System.EventHandler(this.polarRadio_CheckedChanged);
            // 
            // parametricRadio
            // 
            this.parametricRadio.AutoSize = true;
            this.parametricRadio.Location = new System.Drawing.Point(235, 138);
            this.parametricRadio.Name = "parametricRadio";
            this.parametricRadio.Size = new System.Drawing.Size(75, 17);
            this.parametricRadio.TabIndex = 6;
            this.parametricRadio.Text = "Parametric";
            this.parametricRadio.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(66, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // AddEquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 277);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.parametricRadio);
            this.Controls.Add(this.polarRadio);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondFunctionTextBox);
            this.Controls.Add(this.secondFunctionLabel);
            this.Controls.Add(this.firstFunctionLabel);
            this.Controls.Add(this.firstFunctionTextBox);
            this.Name = "AddEquationForm";
            this.Text = "AddEquationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstFunctionTextBox;
        private System.Windows.Forms.Label firstFunctionLabel;
        private System.Windows.Forms.Label secondFunctionLabel;
        private System.Windows.Forms.TextBox secondFunctionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton polarRadio;
        private System.Windows.Forms.RadioButton parametricRadio;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}