namespace Klient
{
    partial class KlientTestForm
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
            this.listeDerTests = new System.Windows.Forms.ComboBox();
            this.kkTasteStartWeiter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.TasteRedag = new System.Windows.Forms.Button();
            this.kkFrageFeld = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kkGroupFrageAntwort = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.kkGroupFrageAntwort.SuspendLayout();
            this.SuspendLayout();
            // 
            // listeDerTests
            // 
            this.listeDerTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listeDerTests.FormattingEnabled = true;
            this.listeDerTests.Location = new System.Drawing.Point(12, 162);
            this.listeDerTests.Name = "listeDerTests";
            this.listeDerTests.Size = new System.Drawing.Size(276, 28);
            this.listeDerTests.TabIndex = 0;
            this.listeDerTests.Text = "Виберіть тему";
            this.listeDerTests.SelectedIndexChanged += new System.EventHandler(this.listeDerTests_SelectedIndexChanged);
            // 
            // kkTasteStartWeiter
            // 
            this.kkTasteStartWeiter.Location = new System.Drawing.Point(172, 388);
            this.kkTasteStartWeiter.Name = "kkTasteStartWeiter";
            this.kkTasteStartWeiter.Size = new System.Drawing.Size(116, 46);
            this.kkTasteStartWeiter.TabIndex = 1;
            this.kkTasteStartWeiter.Text = "button1";
            this.kkTasteStartWeiter.UseVisualStyleBackColor = true;
            this.kkTasteStartWeiter.Click += new System.EventHandler(this.kkTasteStartWeiter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тема тесту:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LoginLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про користувача:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(155, 18);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(64, 25);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "label2";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кількість тестів:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(160, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(82, 20);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(160, 82);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(82, 20);
            this.listBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "% успішності:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 154);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 20);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // TasteRedag
            // 
            this.TasteRedag.Location = new System.Drawing.Point(12, 388);
            this.TasteRedag.Name = "TasteRedag";
            this.TasteRedag.Size = new System.Drawing.Size(116, 46);
            this.TasteRedag.TabIndex = 8;
            this.TasteRedag.Text = "Редагування";
            this.TasteRedag.UseVisualStyleBackColor = true;
            // 
            // kkFrageFeld
            // 
            this.kkFrageFeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kkFrageFeld.FormattingEnabled = true;
            this.kkFrageFeld.ItemHeight = 20;
            this.kkFrageFeld.Location = new System.Drawing.Point(11, 9);
            this.kkFrageFeld.Name = "kkFrageFeld";
            this.kkFrageFeld.Size = new System.Drawing.Size(276, 64);
            this.kkFrageFeld.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логін:";
            // 
            // kkGroupFrageAntwort
            // 
            this.kkGroupFrageAntwort.Controls.Add(this.kkFrageFeld);
            this.kkGroupFrageAntwort.Controls.Add(this.checkBox3);
            this.kkGroupFrageAntwort.Controls.Add(this.checkBox2);
            this.kkGroupFrageAntwort.Controls.Add(this.checkBox1);
            this.kkGroupFrageAntwort.Location = new System.Drawing.Point(1, 193);
            this.kkGroupFrageAntwort.Name = "kkGroupFrageAntwort";
            this.kkGroupFrageAntwort.Size = new System.Drawing.Size(302, 189);
            this.kkGroupFrageAntwort.TabIndex = 10;
            this.kkGroupFrageAntwort.TabStop = false;
            // 
            // KlientTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 449);
            this.Controls.Add(this.kkGroupFrageAntwort);
            this.Controls.Add(this.TasteRedag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kkTasteStartWeiter);
            this.Controls.Add(this.listeDerTests);
            this.Name = "KlientTestForm";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.KlientTestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.kkGroupFrageAntwort.ResumeLayout(false);
            this.kkGroupFrageAntwort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listeDerTests;
        private System.Windows.Forms.Button kkTasteStartWeiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button TasteRedag;
        private System.Windows.Forms.ListBox kkFrageFeld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox kkGroupFrageAntwort;
    }
}