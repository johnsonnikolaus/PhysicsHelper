namespace PhysicsHelper
{
    partial class VelocityCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.NumericUpDown();
            this.initialPosField = new System.Windows.Forms.NumericUpDown();
            this.finalPosField = new System.Windows.Forms.NumericUpDown();
            this.deltaField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unitDropDown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeUnit = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPosField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalPosField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Δposition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial position";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Final position";
            // 
            // timeField
            // 
            this.timeField.DecimalPlaces = 2;
            this.timeField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeField.Location = new System.Drawing.Point(137, 25);
            this.timeField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeField.Name = "timeField";
            this.timeField.Size = new System.Drawing.Size(59, 20);
            this.timeField.TabIndex = 6;
            this.timeField.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // initialPosField
            // 
            this.initialPosField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.initialPosField.Location = new System.Drawing.Point(15, 25);
            this.initialPosField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.initialPosField.Name = "initialPosField";
            this.initialPosField.Size = new System.Drawing.Size(52, 20);
            this.initialPosField.TabIndex = 7;
            this.initialPosField.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // finalPosField
            // 
            this.finalPosField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.finalPosField.Location = new System.Drawing.Point(15, 64);
            this.finalPosField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.finalPosField.Name = "finalPosField";
            this.finalPosField.Size = new System.Drawing.Size(52, 20);
            this.finalPosField.TabIndex = 8;
            this.finalPosField.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // deltaField
            // 
            this.deltaField.DecimalPlaces = 2;
            this.deltaField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.deltaField.Location = new System.Drawing.Point(75, 25);
            this.deltaField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.deltaField.Name = "deltaField";
            this.deltaField.Size = new System.Drawing.Size(56, 20);
            this.deltaField.TabIndex = 9;
            this.deltaField.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Velocity =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unit";
            // 
            // unitDropDown
            // 
            this.unitDropDown.FormattingEnabled = true;
            this.unitDropDown.Items.AddRange(new object[] {
            "cm",
            "in",
            "m",
            "mm"});
            this.unitDropDown.Location = new System.Drawing.Point(75, 64);
            this.unitDropDown.Name = "unitDropDown";
            this.unitDropDown.Size = new System.Drawing.Size(56, 21);
            this.unitDropDown.TabIndex = 12;
            this.unitDropDown.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unit";
            // 
            // timeUnit
            // 
            this.timeUnit.FormattingEnabled = true;
            this.timeUnit.Items.AddRange(new object[] {
            "sec",
            "min",
            "hour"});
            this.timeUnit.Location = new System.Drawing.Point(137, 64);
            this.timeUnit.Name = "timeUnit";
            this.timeUnit.Size = new System.Drawing.Size(59, 21);
            this.timeUnit.TabIndex = 14;
            this.timeUnit.Text = "sec";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(72, 98);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Result";
            // 
            // VelocityCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 128);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.timeUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unitDropDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deltaField);
            this.Controls.Add(this.finalPosField);
            this.Controls.Add(this.initialPosField);
            this.Controls.Add(this.timeField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VelocityCalculator";
            this.Text = "Velocity Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.timeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPosField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalPosField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown timeField;
        private System.Windows.Forms.NumericUpDown initialPosField;
        private System.Windows.Forms.NumericUpDown finalPosField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox unitDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox timeUnit;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.NumericUpDown deltaField;
    }
}