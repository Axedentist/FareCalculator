namespace FareCalculator
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
            this.ListBoxDestination = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonCalc = new System.Windows.Forms.Button();
            this.RadioButtonOneWay = new System.Windows.Forms.RadioButton();
            this.RadioButtonRoundTrip = new System.Windows.Forms.RadioButton();
            this.TextBoxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxDestination
            // 
            this.ListBoxDestination.FormattingEnabled = true;
            this.ListBoxDestination.Location = new System.Drawing.Point(46, 60);
            this.ListBoxDestination.Name = "ListBoxDestination";
            this.ListBoxDestination.Size = new System.Drawing.Size(120, 95);
            this.ListBoxDestination.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Destination";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(138, 187);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 2;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonCalc
            // 
            this.ButtonCalc.Location = new System.Drawing.Point(46, 187);
            this.ButtonCalc.Name = "ButtonCalc";
            this.ButtonCalc.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalc.TabIndex = 3;
            this.ButtonCalc.Text = "Calculate";
            this.ButtonCalc.UseVisualStyleBackColor = true;
            this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // RadioButtonOneWay
            // 
            this.RadioButtonOneWay.AutoSize = true;
            this.RadioButtonOneWay.Location = new System.Drawing.Point(172, 96);
            this.RadioButtonOneWay.Name = "RadioButtonOneWay";
            this.RadioButtonOneWay.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonOneWay.TabIndex = 4;
            this.RadioButtonOneWay.TabStop = true;
            this.RadioButtonOneWay.Text = "One Way";
            this.RadioButtonOneWay.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRoundTrip
            // 
            this.RadioButtonRoundTrip.AutoSize = true;
            this.RadioButtonRoundTrip.Location = new System.Drawing.Point(172, 60);
            this.RadioButtonRoundTrip.Name = "RadioButtonRoundTrip";
            this.RadioButtonRoundTrip.Size = new System.Drawing.Size(72, 30);
            this.RadioButtonRoundTrip.TabIndex = 5;
            this.RadioButtonRoundTrip.TabStop = true;
            this.RadioButtonRoundTrip.Text = "Round \r\nTrip (10%)";
            this.RadioButtonRoundTrip.UseVisualStyleBackColor = true;
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.Location = new System.Drawing.Point(170, 161);
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.Size = new System.Drawing.Size(43, 20);
            this.TextBoxNum.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Tickets (1-9)";
            // 
            // LabelOutput
            // 
            this.LabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelOutput.Location = new System.Drawing.Point(46, 228);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(167, 35);
            this.LabelOutput.TabIndex = 8;
            this.LabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fare Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNum);
            this.Controls.Add(this.RadioButtonRoundTrip);
            this.Controls.Add(this.RadioButtonOneWay);
            this.Controls.Add(this.ButtonCalc);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxDestination);
            this.Name = "Form1";
            this.Text = "Fare Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonCalc;
        private System.Windows.Forms.RadioButton RadioButtonOneWay;
        private System.Windows.Forms.RadioButton RadioButtonRoundTrip;
        private System.Windows.Forms.TextBox TextBoxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Label label3;
    }
}

