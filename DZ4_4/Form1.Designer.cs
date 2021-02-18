namespace DZ4_4
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
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDell = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.MaskedTBPhone = new System.Windows.Forms.MaskedTextBox();
            this.ButtonCLear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelN = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurname.Location = new System.Drawing.Point(273, 41);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(81, 20);
            this.LabelSurname.TabIndex = 0;
            this.LabelSurname.Text = "Фамилия";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(273, 85);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(40, 20);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Имя";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.Location = new System.Drawing.Point(273, 133);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(51, 20);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.Text = "e-mail";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhone.Location = new System.Drawing.Point(273, 184);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(41, 20);
            this.LabelPhone.TabIndex = 4;
            this.LabelPhone.Text = "тел.";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(384, 40);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(256, 20);
            this.TextBoxSurname.TabIndex = 5;
            this.TextBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSurname_KeyPress);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(384, 85);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(256, 20);
            this.TextBoxName.TabIndex = 6;
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSurname_KeyPress);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(384, 132);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxEmail.Size = new System.Drawing.Size(256, 20);
            this.TextBoxEmail.TabIndex = 7;
            this.TextBoxEmail.Validated += new System.EventHandler(this.TextBoxEmail_Validated);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(384, 239);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(111, 44);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDell
            // 
            this.ButtonDell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDell.Location = new System.Drawing.Point(539, 239);
            this.ButtonDell.Name = "ButtonDell";
            this.ButtonDell.Size = new System.Drawing.Size(101, 44);
            this.ButtonDell.TabIndex = 10;
            this.ButtonDell.Text = "Удалить";
            this.ButtonDell.UseVisualStyleBackColor = true;
            this.ButtonDell.Click += new System.EventHandler(this.ButtonDell_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(13, 13);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.ScrollAlwaysVisible = true;
            this.ListBox1.Size = new System.Drawing.Size(254, 407);
            this.ListBox1.TabIndex = 11;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // MaskedTBPhone
            // 
            this.MaskedTBPhone.Location = new System.Drawing.Point(384, 186);
            this.MaskedTBPhone.Mask = "(999) 000-0000";
            this.MaskedTBPhone.Name = "MaskedTBPhone";
            this.MaskedTBPhone.Size = new System.Drawing.Size(256, 20);
            this.MaskedTBPhone.TabIndex = 12;
            // 
            // ButtonCLear
            // 
            this.ButtonCLear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCLear.Location = new System.Drawing.Point(528, 239);
            this.ButtonCLear.Name = "ButtonCLear";
            this.ButtonCLear.Size = new System.Drawing.Size(112, 44);
            this.ButtonCLear.TabIndex = 13;
            this.ButtonCLear.Text = "Очистить";
            this.ButtonCLear.UseVisualStyleBackColor = true;
            this.ButtonCLear.Click += new System.EventHandler(this.ButtonCLear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(277, 239);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(114, 44);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "Сохранить изменения";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Location = new System.Drawing.Point(658, 13);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(59, 13);
            this.LabelN.TabIndex = 15;
            this.LabelN.Text = "№ Анкеты";
            // 
            // LabelNumber
            // 
            this.LabelNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelNumber.Location = new System.Drawing.Point(721, 6);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(87, 27);
            this.LabelNumber.TabIndex = 16;
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonImport
            // 
            this.ButtonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonImport.Location = new System.Drawing.Point(277, 377);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(162, 30);
            this.ButtonImport.TabIndex = 17;
            this.ButtonImport.Text = "Import из файла";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExport.Location = new System.Drawing.Point(467, 377);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(173, 30);
            this.ButtonExport.TabIndex = 18;
            this.ButtonExport.Text = "Export в файл";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::DZ4_4.Properties.Resources.fotocap2;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(668, 46);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(140, 160);
            this.PictureBox1.TabIndex = 19;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(419, 239);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(94, 44);
            this.ButtonCancel.TabIndex = 20;
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(822, 451);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ButtonExport);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelN);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCLear);
            this.Controls.Add(this.MaskedTBPhone);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.ButtonDell);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelSurname);
            this.Name = "Form1";
            this.Text = "Анкета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDell;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.MaskedTextBox MaskedTBPhone;
        private System.Windows.Forms.Button ButtonCLear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button ButtonCancel;
    }
}

