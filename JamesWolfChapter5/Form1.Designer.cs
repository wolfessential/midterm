namespace JamesWolfChapter5
{
    partial class AreaCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AreaOfCylinder = new System.Windows.Forms.RadioButton();
            this.AreaOfCircle = new System.Windows.Forms.RadioButton();
            this.AreaOfRectangle = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.RadiusData = new System.Windows.Forms.TextBox();
            this.LengthData = new System.Windows.Forms.TextBox();
            this.WidthData = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HeightData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AreaOfCylinder);
            this.groupBox1.Controls.Add(this.AreaOfCircle);
            this.groupBox1.Controls.Add(this.AreaOfRectangle);
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a shape to calculate";
            // 
            // AreaOfCylinder
            // 
            this.AreaOfCylinder.AutoSize = true;
            this.AreaOfCylinder.Location = new System.Drawing.Point(24, 247);
            this.AreaOfCylinder.Name = "AreaOfCylinder";
            this.AreaOfCylinder.Size = new System.Drawing.Size(234, 33);
            this.AreaOfCylinder.TabIndex = 3;
            this.AreaOfCylinder.Text = "Area of a Cylinder";
            this.AreaOfCylinder.UseVisualStyleBackColor = true;
            this.AreaOfCylinder.CheckedChanged += new System.EventHandler(this.AreaOfCylinder_CheckedChanged);
            // 
            // AreaOfCircle
            // 
            this.AreaOfCircle.AutoSize = true;
            this.AreaOfCircle.Checked = true;
            this.AreaOfCircle.Location = new System.Drawing.Point(24, 92);
            this.AreaOfCircle.Name = "AreaOfCircle";
            this.AreaOfCircle.Size = new System.Drawing.Size(208, 33);
            this.AreaOfCircle.TabIndex = 1;
            this.AreaOfCircle.TabStop = true;
            this.AreaOfCircle.Text = "Area of a Circle";
            this.AreaOfCircle.UseVisualStyleBackColor = true;
            this.AreaOfCircle.CheckedChanged += new System.EventHandler(this.AreaOfCircle_CheckedChanged);
            // 
            // AreaOfRectangle
            // 
            this.AreaOfRectangle.AutoSize = true;
            this.AreaOfRectangle.Location = new System.Drawing.Point(24, 167);
            this.AreaOfRectangle.Name = "AreaOfRectangle";
            this.AreaOfRectangle.Size = new System.Drawing.Size(254, 33);
            this.AreaOfRectangle.TabIndex = 2;
            this.AreaOfRectangle.Text = "Area of a Rectangle";
            this.AreaOfRectangle.UseVisualStyleBackColor = true;
            this.AreaOfRectangle.CheckedChanged += new System.EventHandler(this.AreaOfRectangle_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(47, 328);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(305, 111);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // RadiusData
            // 
            this.RadiusData.Location = new System.Drawing.Point(47, 75);
            this.RadiusData.Name = "RadiusData";
            this.RadiusData.Size = new System.Drawing.Size(305, 35);
            this.RadiusData.TabIndex = 2;
            this.RadiusData.Text = "Enter the Radius";
            this.RadiusData.Visible = false;
            
            // 
            // LengthData
            // 
            this.LengthData.Location = new System.Drawing.Point(47, 203);
            this.LengthData.Name = "LengthData";
            this.LengthData.Size = new System.Drawing.Size(305, 35);
            this.LengthData.TabIndex = 3;
            this.LengthData.Text = "Enter the Length";
            this.LengthData.Visible = false;
            // 
            // WidthData
            // 
            this.WidthData.Location = new System.Drawing.Point(47, 264);
            this.WidthData.Name = "WidthData";
            this.WidthData.Size = new System.Drawing.Size(305, 35);
            this.WidthData.TabIndex = 4;
            this.WidthData.Text = "Enter the Width";
            this.WidthData.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 704);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 35);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Area of your shape is...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HeightData);
            this.groupBox2.Controls.Add(this.RadiusData);
            this.groupBox2.Controls.Add(this.WidthData);
            this.groupBox2.Controls.Add(this.CalculateButton);
            this.groupBox2.Controls.Add(this.LengthData);
            this.groupBox2.Location = new System.Drawing.Point(871, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 560);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter your data";
            // 
            // HeightData
            // 
            this.HeightData.Location = new System.Drawing.Point(47, 139);
            this.HeightData.Name = "HeightData";
            this.HeightData.Size = new System.Drawing.Size(305, 35);
            this.HeightData.TabIndex = 5;
            this.HeightData.Text = "Enter the Height";
            this.HeightData.Visible = false;
            // 
            // AreaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 895);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreaCalculator";
            this.Text = "AreaCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AreaOfCylinder;
        private System.Windows.Forms.RadioButton AreaOfCircle;
        private System.Windows.Forms.RadioButton AreaOfRectangle;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox RadiusData;
        private System.Windows.Forms.TextBox LengthData;
        private System.Windows.Forms.TextBox WidthData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox HeightData;
    }
}

