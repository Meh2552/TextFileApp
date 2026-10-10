namespace TextFileApp
{
    partial class FrmLab1
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
            panel1 = new Panel();
            lbHeader = new Label();
            btnCreate = new Button();
            txtInput = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbHeader);
            panel1.Location = new Point(1, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 92);
            panel1.TabIndex = 16;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.White;
            lbHeader.Location = new Point(30, 23);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(30, 47);
            lbHeader.TabIndex = 17;
            lbHeader.Text = " ";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(154, 264);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(202, 42);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(56, 108);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(397, 129);
            txtInput.TabIndex = 18;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(509, 333);
            Controls.Add(txtInput);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLab1";
            Text = "FrmLab1";
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
        private Button btnCreate;
        private TextBox txtInput;
    }
}
