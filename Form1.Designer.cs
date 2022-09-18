namespace Prog_Lab_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barLengthLabel = new System.Windows.Forms.Label();
            this.edgeLengthLabel1 = new System.Windows.Forms.Label();
            this.edgeLengthLabel2 = new System.Windows.Forms.Label();
            this.cylinderLengthLabel = new System.Windows.Forms.Label();
            this.cylinderRadiusLabel = new System.Windows.Forms.Label();
            this.barLengthTB = new System.Windows.Forms.TextBox();
            this.edgeLengthTB1 = new System.Windows.Forms.TextBox();
            this.edgeLengthTB2 = new System.Windows.Forms.TextBox();
            this.cylinderRadiusTB = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.vBarLabel = new System.Windows.Forms.Label();
            this.vCylinderLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.cylinderLengthTB = new System.Windows.Forms.TextBox();
            this.vCylinderTB = new System.Windows.Forms.TextBox();
            this.vBarTB = new System.Windows.Forms.TextBox();
            this.percentTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // barLengthLabel
            // 
            this.barLengthLabel.AutoSize = true;
            this.barLengthLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barLengthLabel.Location = new System.Drawing.Point(12, 5);
            this.barLengthLabel.Name = "barLengthLabel";
            this.barLengthLabel.Size = new System.Drawing.Size(129, 15);
            this.barLengthLabel.TabIndex = 0;
            this.barLengthLabel.Text = "Введите длину бруска";
            // 
            // edgeLengthLabel1
            // 
            this.edgeLengthLabel1.AutoSize = true;
            this.edgeLengthLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edgeLengthLabel1.Location = new System.Drawing.Point(183, 5);
            this.edgeLengthLabel1.Name = "edgeLengthLabel1";
            this.edgeLengthLabel1.Size = new System.Drawing.Size(148, 15);
            this.edgeLengthLabel1.TabIndex = 1;
            this.edgeLengthLabel1.Text = "Введите длину 1-го ребра";
            // 
            // edgeLengthLabel2
            // 
            this.edgeLengthLabel2.AutoSize = true;
            this.edgeLengthLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edgeLengthLabel2.Location = new System.Drawing.Point(364, 5);
            this.edgeLengthLabel2.Name = "edgeLengthLabel2";
            this.edgeLengthLabel2.Size = new System.Drawing.Size(148, 15);
            this.edgeLengthLabel2.TabIndex = 2;
            this.edgeLengthLabel2.Text = "Введите длину 2-го ребра";
            // 
            // cylinderLengthLabel
            // 
            this.cylinderLengthLabel.AutoSize = true;
            this.cylinderLengthLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cylinderLengthLabel.Location = new System.Drawing.Point(12, 75);
            this.cylinderLengthLabel.Name = "cylinderLengthLabel";
            this.cylinderLengthLabel.Size = new System.Drawing.Size(146, 15);
            this.cylinderLengthLabel.TabIndex = 3;
            this.cylinderLengthLabel.Text = "Введите длину цилиндра ";
            // 
            // cylinderRadiusLabel
            // 
            this.cylinderRadiusLabel.AutoSize = true;
            this.cylinderRadiusLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cylinderRadiusLabel.Location = new System.Drawing.Point(183, 75);
            this.cylinderRadiusLabel.Name = "cylinderRadiusLabel";
            this.cylinderRadiusLabel.Size = new System.Drawing.Size(152, 15);
            this.cylinderRadiusLabel.TabIndex = 4;
            this.cylinderRadiusLabel.Text = "Введите радиус цилиндра ";
            // 
            // barLengthTB
            // 
            this.barLengthTB.Location = new System.Drawing.Point(12, 28);
            this.barLengthTB.Name = "barLengthTB";
            this.barLengthTB.Size = new System.Drawing.Size(146, 23);
            this.barLengthTB.TabIndex = 5;
            this.barLengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barLengthTB_KeyPress);
            // 
            // edgeLengthTB1
            // 
            this.edgeLengthTB1.Location = new System.Drawing.Point(183, 28);
            this.edgeLengthTB1.Name = "edgeLengthTB1";
            this.edgeLengthTB1.Size = new System.Drawing.Size(146, 23);
            this.edgeLengthTB1.TabIndex = 6;
            this.edgeLengthTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barLengthTB_KeyPress);
            // 
            // edgeLengthTB2
            // 
            this.edgeLengthTB2.Location = new System.Drawing.Point(364, 28);
            this.edgeLengthTB2.Name = "edgeLengthTB2";
            this.edgeLengthTB2.Size = new System.Drawing.Size(146, 23);
            this.edgeLengthTB2.TabIndex = 7;
            this.edgeLengthTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barLengthTB_KeyPress);
            // 
            // cylinderRadiusTB
            // 
            this.cylinderRadiusTB.Location = new System.Drawing.Point(185, 93);
            this.cylinderRadiusTB.Name = "cylinderRadiusTB";
            this.cylinderRadiusTB.Size = new System.Drawing.Size(144, 23);
            this.cylinderRadiusTB.TabIndex = 9;
            this.cylinderRadiusTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barLengthTB_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(12, 142);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(317, 44);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(361, 142);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(151, 44);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Очистить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 212);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(117, 24);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "Результаты";
            // 
            // vBarLabel
            // 
            this.vBarLabel.AutoSize = true;
            this.vBarLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vBarLabel.Location = new System.Drawing.Point(12, 305);
            this.vBarLabel.Name = "vBarLabel";
            this.vBarLabel.Size = new System.Drawing.Size(105, 19);
            this.vBarLabel.TabIndex = 13;
            this.vBarLabel.Text = "Объём бруска:";
            // 
            // vCylinderLabel
            // 
            this.vCylinderLabel.AutoSize = true;
            this.vCylinderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vCylinderLabel.Location = new System.Drawing.Point(12, 255);
            this.vCylinderLabel.Name = "vCylinderLabel";
            this.vCylinderLabel.Size = new System.Drawing.Size(128, 19);
            this.vCylinderLabel.TabIndex = 14;
            this.vCylinderLabel.Text = "Объём цилиндра:";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentLabel.Location = new System.Drawing.Point(12, 343);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(150, 38);
            this.percentLabel.TabIndex = 15;
            this.percentLabel.Text = "Процент материала, \r\nушедшего в отходы:";
            // 
            // cylinderLengthTB
            // 
            this.cylinderLengthTB.Location = new System.Drawing.Point(12, 93);
            this.cylinderLengthTB.Name = "cylinderLengthTB";
            this.cylinderLengthTB.Size = new System.Drawing.Size(146, 23);
            this.cylinderLengthTB.TabIndex = 16;
            this.cylinderLengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barLengthTB_KeyPress);
            // 
            // vCylinderTB
            // 
            this.vCylinderTB.Location = new System.Drawing.Point(168, 305);
            this.vCylinderTB.Name = "vCylinderTB";
            this.vCylinderTB.ReadOnly = true;
            this.vCylinderTB.Size = new System.Drawing.Size(146, 23);
            this.vCylinderTB.TabIndex = 18;
            this.vCylinderTB.TextChanged += new System.EventHandler(this.vCylinderTB_TextChanged);
            // 
            // vBarTB
            // 
            this.vBarTB.Location = new System.Drawing.Point(168, 255);
            this.vBarTB.Name = "vBarTB";
            this.vBarTB.ReadOnly = true;
            this.vBarTB.Size = new System.Drawing.Size(146, 23);
            this.vBarTB.TabIndex = 19;
            // 
            // percentTB
            // 
            this.percentTB.Location = new System.Drawing.Point(168, 358);
            this.percentTB.Name = "percentTB";
            this.percentTB.ReadOnly = true;
            this.percentTB.Size = new System.Drawing.Size(146, 23);
            this.percentTB.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 402);
            this.Controls.Add(this.percentTB);
            this.Controls.Add(this.vBarTB);
            this.Controls.Add(this.vCylinderTB);
            this.Controls.Add(this.cylinderLengthTB);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.vCylinderLabel);
            this.Controls.Add(this.vBarLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.cylinderRadiusTB);
            this.Controls.Add(this.edgeLengthTB2);
            this.Controls.Add(this.edgeLengthTB1);
            this.Controls.Add(this.barLengthTB);
            this.Controls.Add(this.cylinderRadiusLabel);
            this.Controls.Add(this.cylinderLengthLabel);
            this.Controls.Add(this.edgeLengthLabel2);
            this.Controls.Add(this.edgeLengthLabel1);
            this.Controls.Add(this.barLengthLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label barLengthLabel;
        private Label edgeLengthLabel1;
        private Label edgeLengthLabel2;
        private Label cylinderLengthLabel;
        private Label cylinderRadiusLabel;
        private TextBox barLengthTB;
        private TextBox edgeLengthTB1;
        private TextBox edgeLengthTB2;
        private TextBox cylinderRadiusTB;
        private Button calculateButton;
        private Button resetButton;
        private Label resultLabel;
        private Label vBarLabel;
        private Label vCylinderLabel;
        private Label percentLabel;
        private TextBox cylinderLengthTB;
        private TextBox vCylinderTB;
        private TextBox vBarTB;
        private TextBox percentTB;
    }
}