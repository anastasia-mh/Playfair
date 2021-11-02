namespace Playfair
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonENG = new System.Windows.Forms.RadioButton();
            this.radioButtonRUS = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonENC = new System.Windows.Forms.Button();
            this.textBoxEnc = new System.Windows.Forms.TextBox();
            this.buttonDEC = new System.Windows.Forms.Button();
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключевое слово:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(21, 37);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(288, 22);
            this.textBoxKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Язык кодировки:";
            // 
            // radioButtonENG
            // 
            this.radioButtonENG.AutoSize = true;
            this.radioButtonENG.Checked = true;
            this.radioButtonENG.Location = new System.Drawing.Point(4, 4);
            this.radioButtonENG.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonENG.Name = "radioButtonENG";
            this.radioButtonENG.Size = new System.Drawing.Size(59, 21);
            this.radioButtonENG.TabIndex = 0;
            this.radioButtonENG.TabStop = true;
            this.radioButtonENG.Text = "ENG";
            this.radioButtonENG.UseVisualStyleBackColor = true;
            // 
            // radioButtonRUS
            // 
            this.radioButtonRUS.AutoSize = true;
            this.radioButtonRUS.Location = new System.Drawing.Point(71, 4);
            this.radioButtonRUS.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRUS.Name = "radioButtonRUS";
            this.radioButtonRUS.Size = new System.Drawing.Size(56, 21);
            this.radioButtonRUS.TabIndex = 1;
            this.radioButtonRUS.Text = "РУС";
            this.radioButtonRUS.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonENG);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonRUS);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(360, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 25);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(356, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(200, 185);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ключевая матрица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Исходный текст:";
            // 
            // textBoxOrig
            // 
            this.textBoxOrig.Location = new System.Drawing.Point(21, 97);
            this.textBoxOrig.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrig.Multiline = true;
            this.textBoxOrig.Name = "textBoxOrig";
            this.textBoxOrig.Size = new System.Drawing.Size(288, 186);
            this.textBoxOrig.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Зашифрованный текст:";
            // 
            // buttonENC
            // 
            this.buttonENC.AutoSize = true;
            this.buttonENC.Location = new System.Drawing.Point(25, 293);
            this.buttonENC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonENC.Name = "buttonENC";
            this.buttonENC.Size = new System.Drawing.Size(116, 28);
            this.buttonENC.TabIndex = 10;
            this.buttonENC.Text = "Зашифровать";
            this.buttonENC.UseVisualStyleBackColor = true;
            this.buttonENC.Click += new System.EventHandler(this.buttonENC_Click);
            // 
            // textBoxEnc
            // 
            this.textBoxEnc.Location = new System.Drawing.Point(21, 363);
            this.textBoxEnc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnc.Multiline = true;
            this.textBoxEnc.Name = "textBoxEnc";
            this.textBoxEnc.Size = new System.Drawing.Size(280, 196);
            this.textBoxEnc.TabIndex = 11;
            // 
            // buttonDEC
            // 
            this.buttonDEC.AutoSize = true;
            this.buttonDEC.Location = new System.Drawing.Point(25, 567);
            this.buttonDEC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDEC.Name = "buttonDEC";
            this.buttonDEC.Size = new System.Drawing.Size(124, 28);
            this.buttonDEC.TabIndex = 12;
            this.buttonDEC.Text = "Расшифровать";
            this.buttonDEC.UseVisualStyleBackColor = true;
            this.buttonDEC.Click += new System.EventHandler(this.buttonDEC_Click);
            // 
            // textBoxDec
            // 
            this.textBoxDec.Location = new System.Drawing.Point(356, 363);
            this.textBoxDec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDec.Multiline = true;
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.ReadOnly = true;
            this.textBoxDec.Size = new System.Drawing.Size(280, 196);
            this.textBoxDec.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Расшифрованный текст:";
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOK.Location = new System.Drawing.Point(547, 34);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(38, 27);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 614);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxDec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDEC);
            this.Controls.Add(this.textBoxEnc);
            this.Controls.Add(this.buttonENC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOrig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Playfair";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonRUS;
        private System.Windows.Forms.RadioButton radioButtonENG;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonENC;
        private System.Windows.Forms.TextBox textBoxEnc;
        private System.Windows.Forms.Button buttonDEC;
        private System.Windows.Forms.TextBox textBoxDec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOK;
    }
}

