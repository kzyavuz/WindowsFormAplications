namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_number2 = new System.Windows.Forms.Label();
            this.lbl_number1 = new System.Windows.Forms.Label();
            this.btn_carp = new System.Windows.Forms.Button();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.btn_çıkart = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_number2);
            this.panel1.Controls.Add(this.lbl_number1);
            this.panel1.Controls.Add(this.btn_carp);
            this.panel1.Controls.Add(this.txt_number2);
            this.panel1.Controls.Add(this.btn_çıkart);
            this.panel1.Controls.Add(this.btn_topla);
            this.panel1.Controls.Add(this.txt_number1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 169);
            this.panel1.TabIndex = 0;
            // 
            // lbl_number2
            // 
            this.lbl_number2.AutoSize = true;
            this.lbl_number2.Location = new System.Drawing.Point(15, 113);
            this.lbl_number2.Name = "lbl_number2";
            this.lbl_number2.Size = new System.Drawing.Size(47, 16);
            this.lbl_number2.TabIndex = 6;
            this.lbl_number2.Text = "2. Sayı";
            // 
            // lbl_number1
            // 
            this.lbl_number1.AutoSize = true;
            this.lbl_number1.Location = new System.Drawing.Point(12, 65);
            this.lbl_number1.Name = "lbl_number1";
            this.lbl_number1.Size = new System.Drawing.Size(47, 16);
            this.lbl_number1.TabIndex = 5;
            this.lbl_number1.Text = "1. Sayı";
            // 
            // btn_carp
            // 
            this.btn_carp.BackColor = System.Drawing.SystemColors.Info;
            this.btn_carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carp.Location = new System.Drawing.Point(534, 62);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(79, 66);
            this.btn_carp.TabIndex = 4;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = false;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // txt_number2
            // 
            this.txt_number2.Location = new System.Drawing.Point(129, 108);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(100, 22);
            this.txt_number2.TabIndex = 3;
            // 
            // btn_çıkart
            // 
            this.btn_çıkart.BackColor = System.Drawing.SystemColors.Info;
            this.btn_çıkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_çıkart.Location = new System.Drawing.Point(449, 62);
            this.btn_çıkart.Name = "btn_çıkart";
            this.btn_çıkart.Size = new System.Drawing.Size(79, 66);
            this.btn_çıkart.TabIndex = 2;
            this.btn_çıkart.Text = "-";
            this.btn_çıkart.UseVisualStyleBackColor = false;
            this.btn_çıkart.Click += new System.EventHandler(this.btn_çıkart_Click);
            // 
            // btn_topla
            // 
            this.btn_topla.BackColor = System.Drawing.SystemColors.Info;
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_topla.Location = new System.Drawing.Point(364, 62);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(79, 66);
            this.btn_topla.TabIndex = 1;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = false;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // txt_number1
            // 
            this.txt_number1.Location = new System.Drawing.Point(129, 62);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(100, 22);
            this.txt_number1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 281);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(337, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deneme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.TextBox txt_number2;

        private System.Windows.Forms.Button btn_çıkart;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_carp;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_number1;
        private System.Windows.Forms.Label lbl_number2;
    }
}

