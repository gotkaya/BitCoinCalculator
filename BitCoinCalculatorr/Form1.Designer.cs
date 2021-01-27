
namespace BitCoinCalculatorr
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
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBtn = new System.Windows.Forms.Button();
            this.amountOfBts = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.currencyMenu.Location = new System.Drawing.Point(50, 120);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 21);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            // 
            // getRatesBtn
            // 
            this.getRatesBtn.Location = new System.Drawing.Point(184, 171);
            this.getRatesBtn.Name = "getRatesBtn";
            this.getRatesBtn.Size = new System.Drawing.Size(75, 23);
            this.getRatesBtn.TabIndex = 1;
            this.getRatesBtn.Text = "Get Rates";
            this.getRatesBtn.UseVisualStyleBackColor = true;
            this.getRatesBtn.Click += new System.EventHandler(this.getRatesBtn_Click);
            // 
            // amountOfBts
            // 
            this.amountOfBts.Location = new System.Drawing.Point(50, 171);
            this.amountOfBts.Name = "amountOfBts";
            this.amountOfBts.Size = new System.Drawing.Size(100, 20);
            this.amountOfBts.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(50, 254);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(50, 235);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(37, 13);
            this.resultlabel.TabIndex = 4;
            this.resultlabel.Text = "Result";
            this.resultlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitCoinCalculatorr.Properties.Resources.Screenshot_5;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBts);
            this.Controls.Add(this.getRatesBtn);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoinCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBtn;
        private System.Windows.Forms.TextBox amountOfBts;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultlabel;
    }
}

