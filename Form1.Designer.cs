
namespace HR_Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depDel = new System.Windows.Forms.Button();
            this.depSave = new System.Windows.Forms.Button();
            this.depAdd = new System.Windows.Forms.Button();
            this.depName = new System.Windows.Forms.TextBox();
            this.depList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearFields = new System.Windows.Forms.Button();
            this.empDel = new System.Windows.Forms.Button();
            this.empSave = new System.Windows.Forms.Button();
            this.empAdd = new System.Windows.Forms.Button();
            this.empSalary = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.empExperience = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.empAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.photoDel = new System.Windows.Forms.Button();
            this.photoAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.empPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empExperience)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.depDel);
            this.groupBox1.Controls.Add(this.depSave);
            this.groupBox1.Controls.Add(this.depAdd);
            this.groupBox1.Controls.Add(this.depName);
            this.groupBox1.Controls.Add(this.depList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // empList
            // 
            this.empList.FormattingEnabled = true;
            this.empList.ItemHeight = 20;
            this.empList.Location = new System.Drawing.Point(4, 174);
            this.empList.Name = "empList";
            this.empList.ScrollAlwaysVisible = true;
            this.empList.Size = new System.Drawing.Size(219, 304);
            this.empList.TabIndex = 7;
            this.empList.SelectedIndexChanged += new System.EventHandler(this.empList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список сотрудников:";
            // 
            // depDel
            // 
            this.depDel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depDel.Location = new System.Drawing.Point(162, 119);
            this.depDel.Name = "depDel";
            this.depDel.Size = new System.Drawing.Size(61, 26);
            this.depDel.TabIndex = 5;
            this.depDel.Text = "Удалить";
            this.depDel.UseVisualStyleBackColor = true;
            this.depDel.Click += new System.EventHandler(this.depDel_Click);
            // 
            // depSave
            // 
            this.depSave.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depSave.Location = new System.Drawing.Point(79, 119);
            this.depSave.Name = "depSave";
            this.depSave.Size = new System.Drawing.Size(77, 26);
            this.depSave.TabIndex = 4;
            this.depSave.Text = "Сохранить";
            this.depSave.UseVisualStyleBackColor = true;
            this.depSave.Click += new System.EventHandler(this.depSave_Click);
            // 
            // depAdd
            // 
            this.depAdd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depAdd.Location = new System.Drawing.Point(4, 119);
            this.depAdd.Name = "depAdd";
            this.depAdd.Size = new System.Drawing.Size(69, 26);
            this.depAdd.TabIndex = 3;
            this.depAdd.Text = "Добавить";
            this.depAdd.UseVisualStyleBackColor = true;
            this.depAdd.Click += new System.EventHandler(this.depAdd_Click);
            // 
            // depName
            // 
            this.depName.Location = new System.Drawing.Point(4, 88);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(219, 25);
            this.depName.TabIndex = 2;
            // 
            // depList
            // 
            this.depList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depList.FormattingEnabled = true;
            this.depList.Location = new System.Drawing.Point(4, 54);
            this.depList.Name = "depList";
            this.depList.Size = new System.Drawing.Size(219, 28);
            this.depList.TabIndex = 1;
            this.depList.SelectedIndexChanged += new System.EventHandler(this.depList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список департаментов:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearFields);
            this.groupBox2.Controls.Add(this.empDel);
            this.groupBox2.Controls.Add(this.empSave);
            this.groupBox2.Controls.Add(this.empAdd);
            this.groupBox2.Controls.Add(this.empSalary);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.empExperience);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.empAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.empEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.empPhone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.empPosition);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.empBirth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.empName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(477, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 485);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // clearFields
            // 
            this.clearFields.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFields.Location = new System.Drawing.Point(14, 453);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(219, 26);
            this.clearFields.TabIndex = 19;
            this.clearFields.Text = "Очистить поля данных";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // empDel
            // 
            this.empDel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empDel.Location = new System.Drawing.Point(172, 422);
            this.empDel.Name = "empDel";
            this.empDel.Size = new System.Drawing.Size(61, 26);
            this.empDel.TabIndex = 18;
            this.empDel.Text = "Удалить";
            this.empDel.UseVisualStyleBackColor = true;
            this.empDel.Click += new System.EventHandler(this.empDel_Click);
            // 
            // empSave
            // 
            this.empSave.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empSave.Location = new System.Drawing.Point(89, 422);
            this.empSave.Name = "empSave";
            this.empSave.Size = new System.Drawing.Size(77, 26);
            this.empSave.TabIndex = 17;
            this.empSave.Text = "Сохранить";
            this.empSave.UseVisualStyleBackColor = true;
            this.empSave.Click += new System.EventHandler(this.empSave_Click);
            // 
            // empAdd
            // 
            this.empAdd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empAdd.Location = new System.Drawing.Point(14, 422);
            this.empAdd.Name = "empAdd";
            this.empAdd.Size = new System.Drawing.Size(69, 26);
            this.empAdd.TabIndex = 16;
            this.empAdd.Text = "Добавить";
            this.empAdd.UseVisualStyleBackColor = true;
            this.empAdd.Click += new System.EventHandler(this.empAdd_Click);
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(110, 386);
            this.empSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(126, 25);
            this.empSalary.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Зарплата:";
            // 
            // empExperience
            // 
            this.empExperience.Location = new System.Drawing.Point(111, 355);
            this.empExperience.Name = "empExperience";
            this.empExperience.Size = new System.Drawing.Size(126, 25);
            this.empExperience.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Стаж:";
            // 
            // empAddress
            // 
            this.empAddress.Location = new System.Drawing.Point(9, 162);
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(227, 25);
            this.empAddress.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Должность:";
            // 
            // empEmail
            // 
            this.empEmail.Location = new System.Drawing.Point(9, 271);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(227, 25);
            this.empEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "E-Mail:";
            // 
            // empPhone
            // 
            this.empPhone.Location = new System.Drawing.Point(9, 217);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(227, 25);
            this.empPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон:";
            // 
            // empPosition
            // 
            this.empPosition.Location = new System.Drawing.Point(10, 322);
            this.empPosition.Name = "empPosition";
            this.empPosition.Size = new System.Drawing.Size(227, 25);
            this.empPosition.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Адрес:";
            // 
            // empBirth
            // 
            this.empBirth.Location = new System.Drawing.Point(9, 110);
            this.empBirth.Name = "empBirth";
            this.empBirth.Size = new System.Drawing.Size(225, 25);
            this.empBirth.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата рождения:";
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(8, 57);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(227, 25);
            this.empName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Фамилия, имя:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.photoDel);
            this.groupBox3.Controls.Add(this.photoAdd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.empPhoto);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(230, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 485);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото";
            // 
            // photoDel
            // 
            this.photoDel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoDel.Location = new System.Drawing.Point(19, 422);
            this.photoDel.Name = "photoDel";
            this.photoDel.Size = new System.Drawing.Size(209, 51);
            this.photoDel.TabIndex = 9;
            this.photoDel.Text = "Удалить фотографию";
            this.photoDel.UseVisualStyleBackColor = true;
            this.photoDel.Click += new System.EventHandler(this.photoDel_Click);
            // 
            // photoAdd
            // 
            this.photoAdd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoAdd.Location = new System.Drawing.Point(19, 357);
            this.photoAdd.Name = "photoAdd";
            this.photoAdd.Size = new System.Drawing.Size(209, 51);
            this.photoAdd.TabIndex = 7;
            this.photoAdd.Text = "Добавить фотографию";
            this.photoAdd.UseVisualStyleBackColor = true;
            this.photoAdd.Click += new System.EventHandler(this.photoAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фото сотрудника:";
            // 
            // empPhoto
            // 
            this.empPhoto.Image = global::HR_Department.Properties.Resources.profile;
            this.empPhoto.Location = new System.Drawing.Point(7, 56);
            this.empPhoto.Name = "empPhoto";
            this.empPhoto.Size = new System.Drawing.Size(232, 282);
            this.empPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPhoto.TabIndex = 0;
            this.empPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система управления отделом кадров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empExperience)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox depList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox depName;
        private System.Windows.Forms.ListBox empList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button depDel;
        private System.Windows.Forms.Button depSave;
        private System.Windows.Forms.Button depAdd;
        private System.Windows.Forms.Button photoDel;
        private System.Windows.Forms.Button photoAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox empPhoto;
        private System.Windows.Forms.DateTimePicker empBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button empDel;
        private System.Windows.Forms.Button empSave;
        private System.Windows.Forms.Button empAdd;
        private System.Windows.Forms.NumericUpDown empSalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown empExperience;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox empAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empPosition;
        private System.Windows.Forms.Label label7;
    }
}

