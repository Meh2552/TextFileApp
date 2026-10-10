namespace TextFileApp
{
    partial class FrmFileName
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
            lbText = new Label();
            panel1 = new Panel();
            lbHeader = new Label();
            btnOkay = new Button();
            txtFileName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbText.ForeColor = Color.White;
            lbText.Location = new Point(31, 97);
            lbText.Name = "lbText";
            lbText.Size = new Size(193, 56);
            lbText.TabIndex = 14;
            lbText.Text = "Enter File Name";
            lbText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbHeader);
            panel1.Location = new Point(1, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 92);
            panel1.TabIndex = 16;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.White;
            lbHeader.Location = new Point(30, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(185, 47);
            lbHeader.TabIndex = 17;
            lbHeader.Text = "File Name";
            // 
            // btnOkay
            // 
            btnOkay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOkay.Location = new Point(161, 221);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(202, 42);
            btnOkay.TabIndex = 17;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnRun_Click;
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(48, 156);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(436, 29);
            txtFileName.TabIndex = 18;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(522, 305);
            Controls.Add(txtFileName);
            Controls.Add(btnOkay);
            Controls.Add(panel1);
            Controls.Add(lbText);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmFileName";
            Text = "FrmFileName";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSubtitle;
        private Label lbText;
        private Panel panel1;
        private Label lbHeader;
        private Button btnOkay;
        private TextBox txtFileName;
    }
}
