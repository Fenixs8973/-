namespace Шифровщик
{
    partial class Form1
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
            this.EnteredTextBox = new System.Windows.Forms.TextBox();
            this.ButtonEncryption = new System.Windows.Forms.Button();
            this.ButtonDecryption = new System.Windows.Forms.Button();
            this.TextBoxFirstkey = new System.Windows.Forms.TextBox();
            this.TextBoxFSecondkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnteredTextBox
            // 
            this.EnteredTextBox.Location = new System.Drawing.Point(12, 12);
            this.EnteredTextBox.Multiline = true;
            this.EnteredTextBox.Name = "EnteredTextBox";
            this.EnteredTextBox.Size = new System.Drawing.Size(417, 80);
            this.EnteredTextBox.TabIndex = 0;
            this.EnteredTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ButtonEncryption
            // 
            this.ButtonEncryption.Location = new System.Drawing.Point(638, 65);
            this.ButtonEncryption.Name = "ButtonEncryption";
            this.ButtonEncryption.Size = new System.Drawing.Size(112, 31);
            this.ButtonEncryption.TabIndex = 1;
            this.ButtonEncryption.Text = "Зашифровать";
            this.ButtonEncryption.UseVisualStyleBackColor = true;
            this.ButtonEncryption.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDecryption
            // 
            this.ButtonDecryption.Location = new System.Drawing.Point(638, 16);
            this.ButtonDecryption.Name = "ButtonDecryption";
            this.ButtonDecryption.Size = new System.Drawing.Size(112, 31);
            this.ButtonDecryption.TabIndex = 3;
            this.ButtonDecryption.Text = "Дешифровать";
            this.ButtonDecryption.UseVisualStyleBackColor = true;
            this.ButtonDecryption.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBoxFirstkey
            // 
            this.TextBoxFirstkey.Location = new System.Drawing.Point(457, 22);
            this.TextBoxFirstkey.Name = "TextBoxFirstkey";
            this.TextBoxFirstkey.Size = new System.Drawing.Size(112, 20);
            this.TextBoxFirstkey.TabIndex = 4;
            this.TextBoxFirstkey.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxFSecondkey
            // 
            this.TextBoxFSecondkey.Location = new System.Drawing.Point(457, 72);
            this.TextBoxFSecondkey.Name = "TextBoxFSecondkey";
            this.TextBoxFSecondkey.Size = new System.Drawing.Size(112, 20);
            this.TextBoxFSecondkey.TabIndex = 5;
            this.TextBoxFSecondkey.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Второй ключ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Первый ключ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFSecondkey);
            this.Controls.Add(this.TextBoxFirstkey);
            this.Controls.Add(this.ButtonDecryption);
            this.Controls.Add(this.ButtonEncryption);
            this.Controls.Add(this.EnteredTextBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnteredTextBox;
        private System.Windows.Forms.Button ButtonEncryption;
        private System.Windows.Forms.Button ButtonDecryption;
        private System.Windows.Forms.TextBox TextBoxFirstkey;
        private System.Windows.Forms.TextBox TextBoxFSecondkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

