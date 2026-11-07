namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            label1 = new Label();
            txtSecondNumber = new TextBox();
            cbOperator = new ComboBox();
            txtFirstNumber = new TextBox();
            btnCompute = new Button();
            panel1 = new Panel();
            lblResult = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(81, 28);
            label1.Name = "label1";
            label1.Size = new Size(205, 22);
            label1.TabIndex = 0;
            label1.Text = "BASIC CALCULATOR";
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.BorderStyle = BorderStyle.FixedSingle;
            txtSecondNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecondNumber.Location = new Point(81, 157);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(205, 26);
            txtSecondNumber.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(146, 115);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(71, 26);
            cbOperator.TabIndex = 2;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.BorderStyle = BorderStyle.FixedSingle;
            txtFirstNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstNumber.Location = new Point(81, 72);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(205, 26);
            txtFirstNumber.TabIndex = 4;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.LightGray;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(134, 320);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(106, 36);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(81, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 106);
            panel1.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Lime;
            lblResult.Location = new Point(14, 26);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(76, 22);
            lblResult.TabIndex = 6;
            lblResult.Text = "000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 0;
            label2.Text = "Total:";
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(373, 402);
            Controls.Add(panel1);
            Controls.Add(btnCompute);
            Controls.Add(txtFirstNumber);
            Controls.Add(cbOperator);
            Controls.Add(txtSecondNumber);
            Controls.Add(label1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            Load += FrmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSecondNumber;
        private ComboBox cbOperator;
        private TextBox txtFirstNumber;
        private Button btnCompute;
        private Panel panel1;
        private Label lblResult;
        private Label label2;
    }
}
