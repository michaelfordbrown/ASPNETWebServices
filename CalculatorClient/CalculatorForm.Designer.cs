namespace CalculatorClient
{
    partial class CalculatorForm
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
            this.lbOperator = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbOperand1 = new System.Windows.Forms.Label();
            this.lbOperand2 = new System.Windows.Forms.Label();
            this.tbOperand1 = new System.Windows.Forms.TextBox();
            this.tbOperand2 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btExecute = new System.Windows.Forms.Button();
            this.lbCalcResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integer Calculator";
            // 
            // lbOperator
            // 
            this.lbOperator.FormattingEnabled = true;
            this.lbOperator.ItemHeight = 20;
            this.lbOperator.Location = new System.Drawing.Point(167, 140);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(120, 84);
            this.lbOperator.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(163, 99);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Select Operator Function";
            // 
            // lbOperand1
            // 
            this.lbOperand1.AutoSize = true;
            this.lbOperand1.Location = new System.Drawing.Point(167, 258);
            this.lbOperand1.Name = "lbOperand1";
            this.lbOperand1.Size = new System.Drawing.Size(84, 20);
            this.lbOperand1.TabIndex = 3;
            this.lbOperand1.Text = "Operand 1";
            // 
            // lbOperand2
            // 
            this.lbOperand2.AutoSize = true;
            this.lbOperand2.Location = new System.Drawing.Point(355, 258);
            this.lbOperand2.Name = "lbOperand2";
            this.lbOperand2.Size = new System.Drawing.Size(84, 20);
            this.lbOperand2.TabIndex = 4;
            this.lbOperand2.Text = "Operand 2";
            // 
            // tbOperand1
            // 
            this.tbOperand1.Location = new System.Drawing.Point(171, 318);
            this.tbOperand1.Name = "tbOperand1";
            this.tbOperand1.Size = new System.Drawing.Size(100, 26);
            this.tbOperand1.TabIndex = 5;
            // 
            // tbOperand2
            // 
            this.tbOperand2.Location = new System.Drawing.Point(359, 318);
            this.tbOperand2.Name = "tbOperand2";
            this.tbOperand2.Size = new System.Drawing.Size(100, 26);
            this.tbOperand2.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(171, 386);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(55, 20);
            this.lbResult.TabIndex = 7;
            this.lbResult.Text = "Result";
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(537, 308);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(110, 47);
            this.btExecute.TabIndex = 9;
            this.btExecute.Text = "Execute";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.onExecute);
            // 
            // lbCalcResult
            // 
            this.lbCalcResult.AutoSize = true;
            this.lbCalcResult.Location = new System.Drawing.Point(167, 430);
            this.lbCalcResult.Name = "lbCalcResult";
            this.lbCalcResult.Size = new System.Drawing.Size(18, 20);
            this.lbCalcResult.TabIndex = 10;
            this.lbCalcResult.Text = "0";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 586);
            this.Controls.Add(this.lbCalcResult);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbOperand2);
            this.Controls.Add(this.tbOperand1);
            this.Controls.Add(this.lbOperand2);
            this.Controls.Add(this.lbOperand1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbOperator);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorForm";
            this.Text = "Integer Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbOperator;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbOperand1;
        private System.Windows.Forms.Label lbOperand2;
        private System.Windows.Forms.TextBox tbOperand1;
        private System.Windows.Forms.TextBox tbOperand2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Label lbCalcResult;
    }
}

