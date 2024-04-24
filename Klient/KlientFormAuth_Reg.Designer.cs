namespace Klient
{
    partial class KlientFormAuth_Reg
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.kkTasteEnterAdd = new System.Windows.Forms.Button();
            this.LoginFeld = new System.Windows.Forms.TextBox();
            this.PasswortFeld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // kkTasteEnterAdd
            // 
            this.kkTasteEnterAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kkTasteEnterAdd.Location = new System.Drawing.Point(61, 166);
            this.kkTasteEnterAdd.Name = "kkTasteEnterAdd";
            this.kkTasteEnterAdd.Size = new System.Drawing.Size(209, 52);
            this.kkTasteEnterAdd.TabIndex = 0;
            this.kkTasteEnterAdd.Text = "Вхід";
            this.kkTasteEnterAdd.UseVisualStyleBackColor = true;
            this.kkTasteEnterAdd.Click += new System.EventHandler(this.kkTasteEnterAdd_Click);
            // 
            // LoginFeld
            // 
            this.LoginFeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginFeld.Location = new System.Drawing.Point(112, 33);
            this.LoginFeld.Name = "LoginFeld";
            this.LoginFeld.Size = new System.Drawing.Size(209, 30);
            this.LoginFeld.TabIndex = 1;
            this.LoginFeld.TextChanged += new System.EventHandler(this.LoginFeld_TextChanged);
            this.LoginFeld.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginFeld_MouseDown);
            // 
            // PasswortFeld
            // 
            this.PasswortFeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswortFeld.Location = new System.Drawing.Point(112, 75);
            this.PasswortFeld.Name = "PasswortFeld";
            this.PasswortFeld.Size = new System.Drawing.Size(209, 30);
            this.PasswortFeld.TabIndex = 2;
            this.PasswortFeld.TextChanged += new System.EventHandler(this.PasswortFeld_TextChanged);
            this.PasswortFeld.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswortFeld_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логін:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(112, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(192, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Немає аккаунту?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KlientFormAuth_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 230);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswortFeld);
            this.Controls.Add(this.LoginFeld);
            this.Controls.Add(this.kkTasteEnterAdd);
            this.Name = "KlientFormAuth_Reg";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kkTasteEnterAdd;
        private System.Windows.Forms.TextBox LoginFeld;
        private System.Windows.Forms.TextBox PasswortFeld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

