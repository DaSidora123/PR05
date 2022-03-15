namespace PR05
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptBtn = new System.Windows.Forms.Button();
            this.KeyTextBox1 = new System.Windows.Forms.TextBox();
            this.KeyTextBox2 = new System.Windows.Forms.TextBox();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.encryptTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptTextBox = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(176, 119);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(96, 23);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Зашифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.EncryptBtnClick);
            // 
            // KeyTextBox1
            // 
            this.KeyTextBox1.Location = new System.Drawing.Point(30, 33);
            this.KeyTextBox1.Name = "KeyTextBox1";
            this.KeyTextBox1.Size = new System.Drawing.Size(65, 20);
            this.KeyTextBox1.TabIndex = 1;
            // 
            // KeyTextBox2
            // 
            this.KeyTextBox2.Location = new System.Drawing.Point(176, 33);
            this.KeyTextBox2.Name = "KeyTextBox2";
            this.KeyTextBox2.Size = new System.Drawing.Size(69, 20);
            this.KeyTextBox2.TabIndex = 2;
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(30, 80);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(169, 20);
            this.WordTextBox.TabIndex = 3;
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Location = new System.Drawing.Point(27, 170);
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.Size = new System.Drawing.Size(218, 20);
            this.encryptTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Открытый ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Слово";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зашифрованое слово";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Закрытый ключ";
            // 
            // decryptTextBox
            // 
            this.decryptTextBox.Location = new System.Drawing.Point(27, 196);
            this.decryptTextBox.Name = "decryptTextBox";
            this.decryptTextBox.Size = new System.Drawing.Size(218, 20);
            this.decryptTextBox.TabIndex = 9;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(176, 222);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(96, 23);
            this.decryptBtn.TabIndex = 10;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.DecryptTbnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 324);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.decryptTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptTextBox);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.KeyTextBox2);
            this.Controls.Add(this.KeyTextBox1);
            this.Controls.Add(this.encryptBtn);
            this.Name = "Form1";
            this.Text = "Шифрование RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox KeyTextBox1;
        private System.Windows.Forms.TextBox KeyTextBox2;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.TextBox encryptTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptTextBox;
        private System.Windows.Forms.Button decryptBtn;
    }
}

