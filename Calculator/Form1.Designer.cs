namespace Calculator
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnPutoff = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSquared = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnMultiplicate = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.MaxLength = 21;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(284, 39);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSix.Location = new System.Drawing.Point(114, 159);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(45, 45);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.addnumber);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFive.Location = new System.Drawing.Point(63, 159);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(45, 45);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.addnumber);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFour.Location = new System.Drawing.Point(12, 159);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(45, 45);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.addnumber);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNine.Location = new System.Drawing.Point(114, 108);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(45, 45);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.addnumber);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEight.Location = new System.Drawing.Point(63, 108);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(45, 45);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.addnumber);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeven.Location = new System.Drawing.Point(12, 108);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(45, 45);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.addnumber);
            // 
            // btnPutoff
            // 
            this.btnPutoff.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPutoff.Location = new System.Drawing.Point(114, 57);
            this.btnPutoff.Name = "btnPutoff";
            this.btnPutoff.Size = new System.Drawing.Size(45, 45);
            this.btnPutoff.TabIndex = 12;
            this.btnPutoff.Text = "<-";
            this.btnPutoff.UseVisualStyleBackColor = true;
            this.btnPutoff.Click += new System.EventHandler(this.btnPutoff_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAll.Location = new System.Drawing.Point(63, 57);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(45, 45);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "C";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(12, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "CE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSquared
            // 
            this.btnSquared.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquared.Location = new System.Drawing.Point(251, 57);
            this.btnSquared.Name = "btnSquared";
            this.btnSquared.Size = new System.Drawing.Size(45, 45);
            this.btnSquared.TabIndex = 14;
            this.btnSquared.Tag = "²";
            this.btnSquared.Text = "x²";
            this.btnSquared.UseVisualStyleBackColor = true;
            this.btnSquared.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquare.Location = new System.Drawing.Point(200, 57);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(45, 45);
            this.btnSquare.TabIndex = 13;
            this.btnSquare.Tag = "√";
            this.btnSquare.Text = "√";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnMultiplicate
            // 
            this.btnMultiplicate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicate.Location = new System.Drawing.Point(251, 108);
            this.btnMultiplicate.Name = "btnMultiplicate";
            this.btnMultiplicate.Size = new System.Drawing.Size(45, 45);
            this.btnMultiplicate.TabIndex = 16;
            this.btnMultiplicate.Tag = "X";
            this.btnMultiplicate.Text = "X";
            this.btnMultiplicate.UseVisualStyleBackColor = true;
            this.btnMultiplicate.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(200, 108);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 45);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnRest
            // 
            this.btnRest.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRest.Location = new System.Drawing.Point(251, 159);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(45, 45);
            this.btnRest.TabIndex = 18;
            this.btnRest.Tag = "-";
            this.btnRest.Text = "-";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(200, 159);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(45, 45);
            this.btnPlus.TabIndex = 17;
            this.btnPlus.Tag = "+";
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResult.Location = new System.Drawing.Point(200, 210);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(96, 45);
            this.btnResult.TabIndex = 20;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnthree
            // 
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnthree.Location = new System.Drawing.Point(114, 210);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(45, 45);
            this.btnthree.TabIndex = 23;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.addnumber);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.Location = new System.Drawing.Point(63, 210);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(45, 45);
            this.btnTwo.TabIndex = 22;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.addnumber);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOne.Location = new System.Drawing.Point(12, 210);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(45, 45);
            this.btnOne.TabIndex = 21;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.addnumber);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(114, 261);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(45, 45);
            this.btnDot.TabIndex = 26;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCero.Location = new System.Drawing.Point(63, 261);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(45, 45);
            this.btnCero.TabIndex = 25;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.addnumber);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.Location = new System.Drawing.Point(12, 261);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(45, 45);
            this.button22.TabIndex = 24;
            this.button22.Text = "+/-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 315);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMultiplicate);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSquared);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnPutoff);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.txtResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator - ERIB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnPutoff;
        private Button btnDeleteAll;
        private Button btnDelete;
        private Button btnSquared;
        private Button btnSquare;
        private Button btnMultiplicate;
        private Button btnDivide;
        private Button btnRest;
        private Button btnPlus;
        private Button btnResult;
        private Button btnthree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnDot;
        private Button btnCero;
        private Button button22;
    }
}