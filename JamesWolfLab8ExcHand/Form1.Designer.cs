namespace JamesWolfLab8ExcHand
{
    partial class Calculator
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
            this.NumberTwoTextB = new System.Windows.Forms.TextBox();
            this.NumberOneTextB = new System.Windows.Forms.TextBox();
            this.OutputCalc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdditionButton1 = new System.Windows.Forms.RadioButton();
            this.SubtractionButton2 = new System.Windows.Forms.RadioButton();
            this.MultiplyButton3 = new System.Windows.Forms.RadioButton();
            this.DivisionButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberTwoTextB
            // 
            this.NumberTwoTextB.Location = new System.Drawing.Point(467, 325);
            this.NumberTwoTextB.Name = "NumberTwoTextB";
            this.NumberTwoTextB.Size = new System.Drawing.Size(100, 35);
            this.NumberTwoTextB.TabIndex = 0;
            // 
            // NumberOneTextB
            // 
            this.NumberOneTextB.Location = new System.Drawing.Point(217, 325);
            this.NumberOneTextB.Name = "NumberOneTextB";
            this.NumberOneTextB.Size = new System.Drawing.Size(100, 35);
            this.NumberOneTextB.TabIndex = 1;
            // 
            // OutputCalc
            // 
            this.OutputCalc.AutoSize = true;
            this.OutputCalc.Location = new System.Drawing.Point(250, 146);
            this.OutputCalc.Name = "OutputCalc";
            this.OutputCalc.Size = new System.Drawing.Size(0, 29);
            this.OutputCalc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-3, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 254);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a number in each box and choose how you would like to calculate them the cl" +
    "ick calculate!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivisionButton4);
            this.groupBox1.Controls.Add(this.MultiplyButton3);
            this.groupBox1.Controls.Add(this.SubtractionButton2);
            this.groupBox1.Controls.Add(this.AdditionButton1);
            this.groupBox1.Location = new System.Drawing.Point(240, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick One";
            // 
            // AdditionButton1
            // 
            this.AdditionButton1.AutoSize = true;
            this.AdditionButton1.Location = new System.Drawing.Point(0, 34);
            this.AdditionButton1.Name = "AdditionButton1";
            this.AdditionButton1.Size = new System.Drawing.Size(132, 33);
            this.AdditionButton1.TabIndex = 0;
            this.AdditionButton1.TabStop = true;
            this.AdditionButton1.Text = "Addition";
            this.AdditionButton1.UseVisualStyleBackColor = true;
            // 
            // SubtractionButton2
            // 
            this.SubtractionButton2.AutoSize = true;
            this.SubtractionButton2.Location = new System.Drawing.Point(0, 73);
            this.SubtractionButton2.Name = "SubtractionButton2";
            this.SubtractionButton2.Size = new System.Drawing.Size(165, 33);
            this.SubtractionButton2.TabIndex = 1;
            this.SubtractionButton2.TabStop = true;
            this.SubtractionButton2.Text = "Subtraction";
            this.SubtractionButton2.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton3
            // 
            this.MultiplyButton3.AutoSize = true;
            this.MultiplyButton3.Location = new System.Drawing.Point(1, 112);
            this.MultiplyButton3.Name = "MultiplyButton3";
            this.MultiplyButton3.Size = new System.Drawing.Size(126, 33);
            this.MultiplyButton3.TabIndex = 2;
            this.MultiplyButton3.TabStop = true;
            this.MultiplyButton3.Text = "Multiply";
            this.MultiplyButton3.UseVisualStyleBackColor = true;
            // 
            // DivisionButton4
            // 
            this.DivisionButton4.AutoSize = true;
            this.DivisionButton4.Location = new System.Drawing.Point(1, 151);
            this.DivisionButton4.Name = "DivisionButton4";
            this.DivisionButton4.Size = new System.Drawing.Size(129, 33);
            this.DivisionButton4.TabIndex = 3;
            this.DivisionButton4.TabStop = true;
            this.DivisionButton4.Text = "Division";
            this.DivisionButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 143);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 946);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputCalc);
            this.Controls.Add(this.NumberOneTextB);
            this.Controls.Add(this.NumberTwoTextB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTwoTextB;
        private System.Windows.Forms.TextBox NumberOneTextB;
        private System.Windows.Forms.Label OutputCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DivisionButton4;
        private System.Windows.Forms.RadioButton MultiplyButton3;
        private System.Windows.Forms.RadioButton SubtractionButton2;
        private System.Windows.Forms.RadioButton AdditionButton1;
        private System.Windows.Forms.Button button1;
    }
}

