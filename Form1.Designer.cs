﻿namespace WindowsFormsApp1
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
            System.Windows.Forms.ColumnHeader Name;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("xz");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("xz1");
            this.listViewPeople = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox16 = new System.Windows.Forms.ListBox();
            this.listBox15 = new System.Windows.Forms.ListBox();
            this.listBox14 = new System.Windows.Forms.ListBox();
            this.listBox13 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.ButtonSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPeople
            // 
            this.listViewPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Name});
            this.listViewPeople.HideSelection = false;
            this.listViewPeople.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewPeople.Location = new System.Drawing.Point(9, 48);
            this.listViewPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewPeople.Name = "listViewPeople";
            this.listViewPeople.Size = new System.Drawing.Size(210, 687);
            this.listViewPeople.TabIndex = 0;
            this.listViewPeople.UseCompatibleStateImageBehavior = false;
            this.listViewPeople.View = System.Windows.Forms.View.List;
            this.listViewPeople.DoubleClick += new System.EventHandler(this.listViewPeople_DoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Звёздный",
            "Солнечный",
            "Южный"});
            this.comboBox1.Location = new System.Drawing.Point(352, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Корпус:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBox16, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.listBox15, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.listBox14, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.listBox13, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.listBox12, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBox11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBox10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBox8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(312, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 687);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // listBox16
            // 
            this.listBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox16.FormattingEnabled = true;
            this.listBox16.Location = new System.Drawing.Point(237, 597);
            this.listBox16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox16.Name = "listBox16";
            this.listBox16.Size = new System.Drawing.Size(232, 88);
            this.listBox16.TabIndex = 50;
            this.listBox16.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox15
            // 
            this.listBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox15.FormattingEnabled = true;
            this.listBox15.Location = new System.Drawing.Point(2, 597);
            this.listBox15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox15.Name = "listBox15";
            this.listBox15.Size = new System.Drawing.Size(231, 88);
            this.listBox15.TabIndex = 49;
            this.listBox15.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox14
            // 
            this.listBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox14.FormattingEnabled = true;
            this.listBox14.Location = new System.Drawing.Point(237, 512);
            this.listBox14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox14.Name = "listBox14";
            this.listBox14.Size = new System.Drawing.Size(232, 81);
            this.listBox14.TabIndex = 48;
            this.listBox14.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox13
            // 
            this.listBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox13.FormattingEnabled = true;
            this.listBox13.Location = new System.Drawing.Point(2, 512);
            this.listBox13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox13.Name = "listBox13";
            this.listBox13.Size = new System.Drawing.Size(231, 81);
            this.listBox13.TabIndex = 47;
            this.listBox13.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox12
            // 
            this.listBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox12.FormattingEnabled = true;
            this.listBox12.Location = new System.Drawing.Point(237, 427);
            this.listBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(232, 81);
            this.listBox12.TabIndex = 46;
            this.listBox12.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox11
            // 
            this.listBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox11.FormattingEnabled = true;
            this.listBox11.Location = new System.Drawing.Point(2, 427);
            this.listBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(231, 81);
            this.listBox11.TabIndex = 45;
            this.listBox11.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox10
            // 
            this.listBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox10.FormattingEnabled = true;
            this.listBox10.Location = new System.Drawing.Point(237, 342);
            this.listBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(232, 81);
            this.listBox10.TabIndex = 44;
            this.listBox10.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox9
            // 
            this.listBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Location = new System.Drawing.Point(2, 342);
            this.listBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(231, 81);
            this.listBox9.TabIndex = 43;
            this.listBox9.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox8
            // 
            this.listBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(237, 257);
            this.listBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(232, 81);
            this.listBox8.TabIndex = 42;
            this.listBox8.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox7
            // 
            this.listBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(2, 257);
            this.listBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(231, 81);
            this.listBox7.TabIndex = 41;
            this.listBox7.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox6
            // 
            this.listBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(237, 172);
            this.listBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(232, 81);
            this.listBox6.TabIndex = 40;
            this.listBox6.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox5
            // 
            this.listBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(2, 172);
            this.listBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(231, 81);
            this.listBox5.TabIndex = 39;
            this.listBox5.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(237, 87);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(232, 81);
            this.listBox4.TabIndex = 38;
            this.listBox4.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(2, 87);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(231, 81);
            this.listBox3.TabIndex = 37;
            this.listBox3.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(237, 2);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 81);
            this.listBox2.TabIndex = 36;
            this.listBox2.Click += new System.EventHandler(this.RoomClicked);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 2);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 81);
            this.listBox1.TabIndex = 35;
            this.listBox1.Click += new System.EventHandler(this.RoomClicked);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.Location = new System.Drawing.Point(116, 740);
            this.ButtonSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(102, 44);
            this.ButtonSaveFile.TabIndex = 7;
            this.ButtonSaveFile.Text = "Сохранить файл";
            this.ButtonSaveFile.UseVisualStyleBackColor = true;
            // 
            // ButtonSelectFile
            // 
            this.ButtonSelectFile.Location = new System.Drawing.Point(9, 739);
            this.ButtonSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSelectFile.Name = "ButtonSelectFile";
            this.ButtonSelectFile.Size = new System.Drawing.Size(102, 45);
            this.ButtonSelectFile.TabIndex = 6;
            this.ButtonSelectFile.Text = "Выбрать файл";
            this.ButtonSelectFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Направление:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(90, 12);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 609);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSaveFile);
            this.Controls.Add(this.ButtonSelectFile);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listViewPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPeople;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonSaveFile;
        private System.Windows.Forms.Button ButtonSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox16;
        private System.Windows.Forms.ListBox listBox15;
        private System.Windows.Forms.ListBox listBox14;
        private System.Windows.Forms.ListBox listBox13;
        private System.Windows.Forms.ListBox listBox12;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

