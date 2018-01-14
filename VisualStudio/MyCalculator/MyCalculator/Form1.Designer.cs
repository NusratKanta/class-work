namespace MyCalculator
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
            this.display = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.clear1char = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.bin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(589, 161);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(15, 229);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(113, 86);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(134, 229);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(113, 86);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(372, 229);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(113, 86);
            this.mul.TabIndex = 4;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(253, 229);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(113, 86);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(491, 229);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(113, 86);
            this.div.TabIndex = 5;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(492, 413);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(113, 178);
            this.clear.TabIndex = 10;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(372, 321);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(113, 86);
            this.sub.TabIndex = 9;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(253, 321);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(113, 86);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(134, 321);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(113, 86);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(15, 321);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(113, 86);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(372, 413);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 178);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(253, 413);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(113, 86);
            this.three.TabIndex = 13;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(134, 413);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(113, 86);
            this.two.TabIndex = 12;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(15, 413);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(113, 86);
            this.one.TabIndex = 11;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(253, 505);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(113, 86);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(134, 505);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(113, 86);
            this.point.TabIndex = 17;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(15, 505);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(113, 86);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // clear1char
            // 
            this.clear1char.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear1char.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear1char.Location = new System.Drawing.Point(491, 321);
            this.clear1char.Name = "clear1char";
            this.clear1char.Size = new System.Drawing.Size(113, 86);
            this.clear1char.TabIndex = 19;
            this.clear1char.Text = "x";
            this.clear1char.UseVisualStyleBackColor = false;
            this.clear1char.Click += new System.EventHandler(this.clear1char_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.root.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root.Location = new System.Drawing.Point(15, 179);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(113, 43);
            this.root.TabIndex = 20;
            this.root.Text = "root";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // percentage
            // 
            this.percentage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.Location = new System.Drawing.Point(134, 179);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(113, 43);
            this.percentage.TabIndex = 21;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = false;
            this.percentage.Click += new System.EventHandler(this.percentage_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(253, 179);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(113, 43);
            this.square.TabIndex = 22;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // bin
            // 
            this.bin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin.Location = new System.Drawing.Point(372, 179);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(113, 43);
            this.bin.TabIndex = 23;
            this.bin.Text = "BIN";
            this.bin.UseVisualStyleBackColor = false;
            this.bin.Click += new System.EventHandler(this.bin_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 601);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.square);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.root);
            this.Controls.Add(this.clear1char);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.display);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button clear1char;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button bin;
    }
}

