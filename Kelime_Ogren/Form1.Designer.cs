namespace Kelime_Ogren
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtİng = new System.Windows.Forms.TextBox();
            this.txtTurk = new System.Windows.Forms.TextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // txtİng
            // 
            this.txtİng.Location = new System.Drawing.Point(167, 41);
            this.txtİng.Name = "txtİng";
            this.txtİng.Size = new System.Drawing.Size(160, 30);
            this.txtİng.TabIndex = 10;
            // 
            // txtTurk
            // 
            this.txtTurk.Location = new System.Drawing.Point(167, 102);
            this.txtTurk.Name = "txtTurk";
            this.txtTurk.Size = new System.Drawing.Size(160, 30);
            this.txtTurk.TabIndex = 1;
            this.txtTurk.TextChanged += new System.EventHandler(this.txtTurk_TextChanged);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(398, 170);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(80, 24);
            this.lblCevap.TabIndex = 3;
            this.lblCevap.Text = "Kelime:";
            this.lblCevap.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Süre:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(484, 44);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(33, 24);
            this.lblSure.TabIndex = 3;
            this.lblSure.Text = "90";
            this.lblSure.Click += new System.EventHandler(this.lblSure_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(484, 102);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(22, 24);
            this.lblKelime.TabIndex = 3;
            this.lblKelime.Text = "0";
            this.lblKelime.Click += new System.EventHandler(this.lblKelime_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kelime:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 244);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.txtTurk);
            this.Controls.Add(this.txtİng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtİng;
        private System.Windows.Forms.TextBox txtTurk;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

