namespace CSharp_TimSNT
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
            btnThoat = new Button();
            label1 = new Label();
            txtNhapso = new TextBox();
            label2 = new Label();
            txtKTSo = new TextBox();
            label3 = new Label();
            txtNhoN = new TextBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(489, 143);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 147);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhap so n";
            label1.Click += label1_Click;
            // 
            // txtNhapso
            // 
            txtNhapso.Location = new Point(288, 143);
            txtNhapso.Name = "txtNhapso";
            txtNhapso.Size = new Size(186, 23);
            txtNhapso.TabIndex = 2;
            txtNhapso.TextChanged += txtNhapso_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 185);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "KT SNT";
            label2.Click += label1_Click;
            // 
            // txtKTSo
            // 
            txtKTSo.Location = new Point(288, 181);
            txtKTSo.Name = "txtKTSo";
            txtKTSo.Size = new Size(186, 23);
            txtKTSo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 226);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 1;
            label3.Text = "SNT nho hon n";
            label3.Click += label1_Click;
            // 
            // txtNhoN
            // 
            txtNhoN.Location = new Point(288, 222);
            txtNhoN.Name = "txtNhoN";
            txtNhoN.Size = new Size(186, 23);
            txtNhoN.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNhoN);
            Controls.Add(label3);
            Controls.Add(txtKTSo);
            Controls.Add(label2);
            Controls.Add(txtNhapso);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Label label1;
        private TextBox txtNhapso;
        private Label label2;
        private TextBox txtKTSo;
        private Label label3;
        private TextBox txtNhoN;
    }
}
