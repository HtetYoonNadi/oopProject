namespace oopProject
{
    partial class NameForm
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdoLargest = new System.Windows.Forms.RadioButton();
            this.rdoSmallest = new System.Windows.Forms.RadioButton();
            this.rdoTotal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(155, 101);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(183, 31);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(155, 193);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(183, 31);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(155, 284);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(183, 31);
            this.txtNum3.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(155, 382);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 69);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(159, 529);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(91, 25);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result : ";
            this.lblResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdoLargest
            // 
            this.rdoLargest.AutoSize = true;
            this.rdoLargest.Location = new System.Drawing.Point(556, 104);
            this.rdoLargest.Name = "rdoLargest";
            this.rdoLargest.Size = new System.Drawing.Size(115, 29);
            this.rdoLargest.TabIndex = 5;
            this.rdoLargest.TabStop = true;
            this.rdoLargest.Text = "Largest";
            this.rdoLargest.UseVisualStyleBackColor = true;
            // 
            // rdoSmallest
            // 
            this.rdoSmallest.AutoSize = true;
            this.rdoSmallest.Location = new System.Drawing.Point(556, 194);
            this.rdoSmallest.Name = "rdoSmallest";
            this.rdoSmallest.Size = new System.Drawing.Size(125, 29);
            this.rdoSmallest.TabIndex = 6;
            this.rdoSmallest.TabStop = true;
            this.rdoSmallest.Text = "Smallest";
            this.rdoSmallest.UseVisualStyleBackColor = true;
            // 
            // rdoTotal
            // 
            this.rdoTotal.AutoSize = true;
            this.rdoTotal.Location = new System.Drawing.Point(556, 284);
            this.rdoTotal.Name = "rdoTotal";
            this.rdoTotal.Size = new System.Drawing.Size(91, 29);
            this.rdoTotal.TabIndex = 7;
            this.rdoTotal.TabStop = true;
            this.rdoTotal.Text = "Total";
            this.rdoTotal.UseVisualStyleBackColor = true;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 771);
            this.Controls.Add(this.rdoTotal);
            this.Controls.Add(this.rdoSmallest);
            this.Controls.Add(this.rdoLargest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "NameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rdoLargest;
        private System.Windows.Forms.RadioButton rdoSmallest;
        private System.Windows.Forms.RadioButton rdoTotal;
    }
}

