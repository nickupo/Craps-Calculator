namespace craps
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Horn = new System.Windows.Forms.Button();
            this.label_Output = new System.Windows.Forms.Label();
            this.btn_HornHS = new System.Windows.Forms.Button();
            this.btn_twoWayH = new System.Windows.Forms.Button();
            this.btn_twoWayL = new System.Windows.Forms.Button();
            this.btn_threeWayH = new System.Windows.Forms.Button();
            this.btn_threeWayL = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Horn
            // 
            this.btn_Horn.Location = new System.Drawing.Point(12, 160);
            this.btn_Horn.Name = "btn_Horn";
            this.btn_Horn.Size = new System.Drawing.Size(155, 55);
            this.btn_Horn.TabIndex = 1;
            this.btn_Horn.Text = "Horn (Low Side)";
            this.btn_Horn.UseVisualStyleBackColor = true;
            this.btn_Horn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Location = new System.Drawing.Point(426, 671);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(66, 20);
            this.label_Output.TabIndex = 2;
            this.label_Output.Text = "Payout: ";
            // 
            // btn_HornHS
            // 
            this.btn_HornHS.Location = new System.Drawing.Point(12, 234);
            this.btn_HornHS.Name = "btn_HornHS";
            this.btn_HornHS.Size = new System.Drawing.Size(155, 55);
            this.btn_HornHS.TabIndex = 3;
            this.btn_HornHS.Text = "Horn (High Side)";
            this.btn_HornHS.UseVisualStyleBackColor = true;
            this.btn_HornHS.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_twoWayH
            // 
            this.btn_twoWayH.Location = new System.Drawing.Point(12, 312);
            this.btn_twoWayH.Name = "btn_twoWayH";
            this.btn_twoWayH.Size = new System.Drawing.Size(155, 55);
            this.btn_twoWayH.TabIndex = 4;
            this.btn_twoWayH.Text = "Two Way Split (High)";
            this.btn_twoWayH.UseVisualStyleBackColor = true;
            this.btn_twoWayH.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_twoWayL
            // 
            this.btn_twoWayL.Location = new System.Drawing.Point(12, 395);
            this.btn_twoWayL.Name = "btn_twoWayL";
            this.btn_twoWayL.Size = new System.Drawing.Size(155, 55);
            this.btn_twoWayL.TabIndex = 5;
            this.btn_twoWayL.Text = "Two Way Split (Low)";
            this.btn_twoWayL.UseVisualStyleBackColor = true;
            this.btn_twoWayL.Click += new System.EventHandler(this.btn_twoWayL_Click);
            // 
            // btn_threeWayH
            // 
            this.btn_threeWayH.Location = new System.Drawing.Point(12, 480);
            this.btn_threeWayH.Name = "btn_threeWayH";
            this.btn_threeWayH.Size = new System.Drawing.Size(155, 55);
            this.btn_threeWayH.TabIndex = 6;
            this.btn_threeWayH.Text = "3 Way Split (High)";
            this.btn_threeWayH.UseVisualStyleBackColor = true;
            this.btn_threeWayH.Click += new System.EventHandler(this.btn_threeWayH_Click);
            // 
            // btn_threeWayL
            // 
            this.btn_threeWayL.Location = new System.Drawing.Point(12, 562);
            this.btn_threeWayL.Name = "btn_threeWayL";
            this.btn_threeWayL.Size = new System.Drawing.Size(155, 55);
            this.btn_threeWayL.TabIndex = 7;
            this.btn_threeWayL.Text = "3 Way Split (Low)";
            this.btn_threeWayL.UseVisualStyleBackColor = true;
            this.btn_threeWayL.Click += new System.EventHandler(this.btn_threeWayL_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(244, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 55);
            this.button6.TabIndex = 8;
            this.button6.Text = "Eleven / Ace-Deuce";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(244, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 55);
            this.button7.TabIndex = 9;
            this.button7.Text = "Twelve / Two";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(430, 480);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(155, 55);
            this.button8.TabIndex = 10;
            this.button8.Text = "Hop The Red";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(244, 480);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(155, 55);
            this.button9.TabIndex = 11;
            this.button9.Text = "High/Low";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ET / Aces-Ace Deuce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Two Way Splits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Generic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "3 Way Splits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "3 Way Craps";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Two / Twelve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 55);
            this.button2.TabIndex = 18;
            this.button2.Text = "Ace-Deuce";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bet Amount:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 54);
            this.button3.TabIndex = 20;
            this.button3.Text = "Six/Eight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(766, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 54);
            this.button4.TabIndex = 21;
            this.button4.Text = "Five/Nine";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(766, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 54);
            this.button5.TabIndex = 22;
            this.button5.Text = "Four/Ten";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Place Bets";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(766, 480);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 55);
            this.button10.TabIndex = 24;
            this.button10.Text = "Four/Ten";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(811, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Buy Bets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 762);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_threeWayL);
            this.Controls.Add(this.btn_threeWayH);
            this.Controls.Add(this.btn_twoWayL);
            this.Controls.Add(this.btn_twoWayH);
            this.Controls.Add(this.btn_HornHS);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.btn_Horn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Horn;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Button btn_HornHS;
        private System.Windows.Forms.Button btn_twoWayH;
        private System.Windows.Forms.Button btn_twoWayL;
        private System.Windows.Forms.Button btn_threeWayH;
        private System.Windows.Forms.Button btn_threeWayL;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label8;
    }
}

