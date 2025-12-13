namespace Calculator
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPlus = new Button();
            buttonRest = new Button();
            buttonMulti = new Button();
            buttonMinus = new Button();
            buttonCosinus = new Button();
            buttonDivide = new Button();
            buttonSin = new Button();
            buttonPow = new Button();
            buttonCeil = new Button();
            buttonFloor = new Button();
            buttonSquare = new Button();
            buttonClear = new Button();
            buttonEqual = new Button();
            buttonMPlus = new Button();
            buttonMMinus = new Button();
            textBox = new TextBox();
            buttonMC = new Button();
            buttonMR = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 83);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 83);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumber_Click;
            // 
            // button3
            // 
            button3.Location = new Point(213, 83);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 118);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(113, 118);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(213, 118);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(13, 153);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(113, 153);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(213, 153);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNumber_Click;
            // 
            // button0
            // 
            button0.Location = new Point(113, 188);
            button0.Name = "button0";
            button0.Size = new Size(94, 29);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonNumber_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(315, 83);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(94, 29);
            buttonPlus.TabIndex = 10;
            buttonPlus.Tag = "+";
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonBinary_Click;
            // 
            // buttonRest
            // 
            buttonRest.Location = new Point(415, 153);
            buttonRest.Name = "buttonRest";
            buttonRest.Size = new Size(94, 29);
            buttonRest.TabIndex = 11;
            buttonRest.Tag = "r";
            buttonRest.Text = "ост от /";
            buttonRest.UseVisualStyleBackColor = true;
            buttonRest.Click += buttonBinary_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(315, 118);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(94, 29);
            buttonMulti.TabIndex = 12;
            buttonMulti.Tag = "*";
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonBinary_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(415, 83);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(94, 29);
            buttonMinus.TabIndex = 13;
            buttonMinus.Tag = "-";
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonBinary_Click;
            // 
            // buttonCosinus
            // 
            buttonCosinus.Location = new Point(315, 48);
            buttonCosinus.Name = "buttonCosinus";
            buttonCosinus.Size = new Size(94, 29);
            buttonCosinus.TabIndex = 14;
            buttonCosinus.Tag = "cos";
            buttonCosinus.Text = "cos()";
            buttonCosinus.UseVisualStyleBackColor = true;
            buttonCosinus.Click += buttonSingle_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(415, 118);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(94, 29);
            buttonDivide.TabIndex = 15;
            buttonDivide.Tag = "/";
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonBinary_Click;
            // 
            // buttonSin
            // 
            buttonSin.Location = new Point(12, 48);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(94, 29);
            buttonSin.TabIndex = 16;
            buttonSin.Tag = "sin";
            buttonSin.Text = "sin()";
            buttonSin.UseVisualStyleBackColor = true;
            buttonSin.Click += buttonSingle_Click;
            // 
            // buttonPow
            // 
            buttonPow.Location = new Point(315, 153);
            buttonPow.Name = "buttonPow";
            buttonPow.Size = new Size(94, 29);
            buttonPow.TabIndex = 17;
            buttonPow.Tag = "^";
            buttonPow.Text = "^";
            buttonPow.UseVisualStyleBackColor = true;
            buttonPow.Click += buttonBinary_Click;
            // 
            // buttonCeil
            // 
            buttonCeil.Location = new Point(213, 48);
            buttonCeil.Name = "buttonCeil";
            buttonCeil.Size = new Size(94, 29);
            buttonCeil.TabIndex = 18;
            buttonCeil.Tag = "ceil";
            buttonCeil.Text = "ceil()";
            buttonCeil.UseVisualStyleBackColor = true;
            buttonCeil.Click += buttonSingle_Click;
            // 
            // buttonFloor
            // 
            buttonFloor.Location = new Point(415, 48);
            buttonFloor.Name = "buttonFloor";
            buttonFloor.Size = new Size(94, 29);
            buttonFloor.TabIndex = 19;
            buttonFloor.Tag = "floor";
            buttonFloor.Text = "floor()";
            buttonFloor.UseVisualStyleBackColor = true;
            buttonFloor.Click += buttonSingle_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.Location = new Point(113, 48);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(94, 29);
            buttonSquare.TabIndex = 20;
            buttonSquare.Tag = "square";
            buttonSquare.Text = "^(1/2)";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonSingle_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(14, 188);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "CA";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(213, 188);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(94, 29);
            buttonEqual.TabIndex = 22;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonMPlus
            // 
            buttonMPlus.Location = new Point(415, 188);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.Size = new Size(43, 29);
            buttonMPlus.TabIndex = 23;
            buttonMPlus.Tag = "MP";
            buttonMPlus.Text = "M+";
            buttonMPlus.UseVisualStyleBackColor = true;
            buttonMPlus.Click += buttonM_Click;
            // 
            // buttonMMinus
            // 
            buttonMMinus.Location = new Point(464, 188);
            buttonMMinus.Name = "buttonMMinus";
            buttonMMinus.Size = new Size(45, 29);
            buttonMMinus.TabIndex = 25;
            buttonMMinus.Tag = "MM";
            buttonMMinus.Text = "M-";
            buttonMMinus.UseVisualStyleBackColor = true;
            buttonMMinus.Click += buttonM_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(14, 15);
            textBox.Name = "textBox";
            textBox.RightToLeft = RightToLeft.Yes;
            textBox.Size = new Size(495, 27);
            textBox.TabIndex = 26;
            // 
            // buttonMC
            // 
            buttonMC.Location = new Point(364, 188);
            buttonMC.Name = "buttonMC";
            buttonMC.Size = new Size(45, 29);
            buttonMC.TabIndex = 28;
            buttonMC.Tag = "MC";
            buttonMC.Text = "MC";
            buttonMC.UseVisualStyleBackColor = true;
            buttonMC.Click += buttonM_Click;
            // 
            // buttonMR
            // 
            buttonMR.Location = new Point(315, 188);
            buttonMR.Name = "buttonMR";
            buttonMR.Size = new Size(43, 29);
            buttonMR.TabIndex = 27;
            buttonMR.Tag = "MR";
            buttonMR.Text = "MR";
            buttonMR.UseVisualStyleBackColor = true;
            buttonMR.Click += buttonM_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 231);
            Controls.Add(buttonMC);
            Controls.Add(buttonMR);
            Controls.Add(textBox);
            Controls.Add(buttonMMinus);
            Controls.Add(buttonMPlus);
            Controls.Add(buttonEqual);
            Controls.Add(buttonClear);
            Controls.Add(buttonSquare);
            Controls.Add(buttonFloor);
            Controls.Add(buttonCeil);
            Controls.Add(buttonPow);
            Controls.Add(buttonSin);
            Controls.Add(buttonDivide);
            Controls.Add(buttonCosinus);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMulti);
            Controls.Add(buttonRest);
            Controls.Add(buttonPlus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPlus;
        private Button buttonRest;
        private Button buttonMulti;
        private Button buttonMinus;
        private Button buttonCosinus;
        private Button buttonDivide;
        private Button buttonSin;
        private Button buttonPow;
        private Button buttonCeil;
        private Button buttonFloor;
        private Button buttonSquare;
        private Button buttonClear;
        private Button buttonEqual;
        private Button buttonMPlus;
        private Button buttonMMinus;
        private TextBox textBox;
        private Button buttonMC;
        private Button buttonMR;
    }
}
