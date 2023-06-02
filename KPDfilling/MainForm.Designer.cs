namespace KPDfilling
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            disciplineNameLabel = new Label();
            courseLabel = new Label();
            courseCB = new ComboBox();
            semesterLabel = new Label();
            semesterCB = new ComboBox();
            nameCB = new ComboBox();
            groupCB = new ComboBox();
            nameLabel = new Label();
            groupLabel = new Label();
            FIOteacherLabel = new Label();
            fillButton = new Button();
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            kafedraCB = new ComboBox();
            kafedraLabel = new Label();
            profileLabel = new Label();
            profileCB = new ComboBox();
            addRowButton = new Button();
            panelTable2 = new Panel();
            bibliographyLabel = new Label();
            panelTable3 = new Panel();
            resourcesLabel = new Label();
            addRowButton2 = new Button();
            panelTable1 = new Panel();
            label1 = new Label();
            label17 = new Label();
            pictureBox1 = new PictureBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label19 = new Label();
            disciplineNameCB = new ComboBox();
            nextButton = new Button();
            previousButton = new Button();
            FIOteacherCB = new ComboBox();
            toolTip1 = new ToolTip(components);
            clearButton = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            предпросмотрToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьВWordToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            courseworkСheckBox = new CheckBox();
            certificationTB = new TextBox();
            academichoursTB = new TextBox();
            zeTB = new TextBox();
            certificationLabel = new Label();
            academichoursLabel = new Label();
            zeLabel = new Label();
            label18 = new Label();
            pictureBox2 = new PictureBox();
            fon = new PictureBox();
            tempBtn = new Button();
            panelTable2.SuspendLayout();
            panelTable3.SuspendLayout();
            panelTable1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fon).BeginInit();
            SuspendLayout();
            // 
            // disciplineNameLabel
            // 
            disciplineNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            disciplineNameLabel.AutoSize = true;
            disciplineNameLabel.Location = new Point(133, 659);
            disciplineNameLabel.Margin = new Padding(0);
            disciplineNameLabel.Name = "disciplineNameLabel";
            disciplineNameLabel.Size = new Size(172, 20);
            disciplineNameLabel.TabIndex = 3;
            disciplineNameLabel.Text = "Название дисциплины:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Location = new Point(133, 392);
            courseLabel.Margin = new Padding(0);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(44, 20);
            courseLabel.TabIndex = 5;
            courseLabel.Text = "Курс:";
            // 
            // courseCB
            // 
            courseCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            courseCB.DropDownStyle = ComboBoxStyle.DropDownList;
            courseCB.FormattingEnabled = true;
            courseCB.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            courseCB.Location = new Point(133, 418);
            courseCB.Margin = new Padding(0);
            courseCB.Name = "courseCB";
            courseCB.Size = new Size(213, 28);
            courseCB.TabIndex = 6;
            courseCB.SelectedIndexChanged += courseCB_SelectedIndexChanged;
            // 
            // semesterLabel
            // 
            semesterLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            semesterLabel.AutoSize = true;
            semesterLabel.Location = new Point(362, 392);
            semesterLabel.Margin = new Padding(0);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new Size(70, 20);
            semesterLabel.TabIndex = 7;
            semesterLabel.Text = "Семестр:";
            // 
            // semesterCB
            // 
            semesterCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            semesterCB.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterCB.FormattingEnabled = true;
            semesterCB.Items.AddRange(new object[] { "1", "2" });
            semesterCB.Location = new Point(362, 418);
            semesterCB.Margin = new Padding(0);
            semesterCB.Name = "semesterCB";
            semesterCB.Size = new Size(213, 28);
            semesterCB.TabIndex = 8;
            semesterCB.SelectedIndexChanged += semesterCB_SelectedIndexChanged;
            // 
            // nameCB
            // 
            nameCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nameCB.AutoCompleteMode = AutoCompleteMode.Append;
            nameCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            nameCB.DropDownStyle = ComboBoxStyle.DropDownList;
            nameCB.FormattingEnabled = true;
            nameCB.Items.AddRange(new object[] { "1", "2" });
            nameCB.Location = new Point(133, 486);
            nameCB.Margin = new Padding(0);
            nameCB.Name = "nameCB";
            nameCB.Size = new Size(596, 28);
            nameCB.TabIndex = 9;
            nameCB.SelectedIndexChanged += nameCB_SelectedIndexChanged;
            // 
            // groupCB
            // 
            groupCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupCB.AutoCompleteMode = AutoCompleteMode.Append;
            groupCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            groupCB.DropDownStyle = ComboBoxStyle.DropDownList;
            groupCB.FormattingEnabled = true;
            groupCB.Items.AddRange(new object[] { "1", "2" });
            groupCB.Location = new Point(133, 620);
            groupCB.Margin = new Padding(0);
            groupCB.Name = "groupCB";
            groupCB.Size = new Size(115, 28);
            groupCB.TabIndex = 10;
            groupCB.SelectedIndexChanged += groupCB_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(133, 459);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(191, 20);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Направление подготовки:";
            // 
            // groupLabel
            // 
            groupLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupLabel.AutoSize = true;
            groupLabel.Location = new Point(133, 594);
            groupLabel.Margin = new Padding(0);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(115, 20);
            groupLabel.TabIndex = 12;
            groupLabel.Text = "Номер группы:";
            // 
            // FIOteacherLabel
            // 
            FIOteacherLabel.AutoSize = true;
            FIOteacherLabel.Location = new Point(458, 594);
            FIOteacherLabel.Margin = new Padding(0);
            FIOteacherLabel.Name = "FIOteacherLabel";
            FIOteacherLabel.Size = new Size(112, 20);
            FIOteacherLabel.TabIndex = 13;
            FIOteacherLabel.Text = "Фамилия И.О. :";
            // 
            // fillButton
            // 
            fillButton.Location = new Point(549, 845);
            fillButton.Margin = new Padding(0);
            fillButton.Name = "fillButton";
            fillButton.Size = new Size(180, 29);
            fillButton.TabIndex = 15;
            fillButton.Text = "Заполнить документ";
            fillButton.UseVisualStyleBackColor = true;
            fillButton.Click += fillButton_Click;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startDateTimePicker.Location = new Point(270, 620);
            startDateTimePicker.Margin = new Padding(0);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(165, 27);
            startDateTimePicker.TabIndex = 16;
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(270, 594);
            startDateLabel.Margin = new Padding(0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(165, 20);
            startDateLabel.TabIndex = 17;
            startDateLabel.Text = "Дата начала семестра:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 19;
            label2.Text = "Лекции";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 9);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 20;
            label3.Text = "Лабораторные";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 9);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 21;
            label4.Text = "Семинары";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 11);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 22;
            label5.Text = "КРП";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 9);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 23;
            label6.Text = "Самостоятельная работа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 31);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 24;
            label7.Text = "Часы";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 31);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 25;
            label8.Text = "Содержание";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(229, 31);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 27;
            label9.Text = "Содержание";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(186, 31);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 26;
            label10.Text = "Часы";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(397, 31);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 29;
            label11.Text = "Содержание";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(355, 31);
            label12.Name = "label12";
            label12.Size = new Size(45, 20);
            label12.TabIndex = 28;
            label12.Text = "Часы";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(649, 31);
            label13.Name = "label13";
            label13.Size = new Size(97, 20);
            label13.TabIndex = 31;
            label13.Text = "Содержание";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(547, 31);
            label14.Name = "label14";
            label14.Size = new Size(45, 20);
            label14.TabIndex = 30;
            label14.Text = "Часы";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(785, 31);
            label15.Name = "label15";
            label15.Size = new Size(126, 20);
            label15.TabIndex = 33;
            label15.Text = "Форма контроля";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(743, 31);
            label16.Name = "label16";
            label16.Size = new Size(45, 20);
            label16.TabIndex = 32;
            label16.Text = "Часы";
            // 
            // kafedraCB
            // 
            kafedraCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            kafedraCB.AutoCompleteMode = AutoCompleteMode.Append;
            kafedraCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            kafedraCB.FormattingEnabled = true;
            kafedraCB.Items.AddRange(new object[] { "системного анализа и управления", "распределенных информационно-вычислительных систем", "геоинформационных систем и технологий", "цифровой экономики и управления", "информационных технологий", "интеллектуального управления техническими системами" });
            kafedraCB.Location = new Point(133, 354);
            kafedraCB.Margin = new Padding(0);
            kafedraCB.Name = "kafedraCB";
            kafedraCB.Size = new Size(596, 28);
            kafedraCB.TabIndex = 35;
            kafedraCB.TabStop = false;
            kafedraCB.DropDownClosed += comboBoxes_DropDownClosed;
            // 
            // kafedraLabel
            // 
            kafedraLabel.AutoSize = true;
            kafedraLabel.Location = new Point(133, 329);
            kafedraLabel.Margin = new Padding(0);
            kafedraLabel.Name = "kafedraLabel";
            kafedraLabel.Size = new Size(72, 20);
            kafedraLabel.TabIndex = 34;
            kafedraLabel.Text = "Кафедра:";
            // 
            // profileLabel
            // 
            profileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            profileLabel.AutoSize = true;
            profileLabel.Location = new Point(133, 526);
            profileLabel.Margin = new Padding(0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(173, 20);
            profileLabel.TabIndex = 37;
            profileLabel.Text = "Профиль направления:";
            // 
            // profileCB
            // 
            profileCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            profileCB.AutoCompleteMode = AutoCompleteMode.Append;
            profileCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            profileCB.BackColor = SystemColors.Window;
            profileCB.DropDownStyle = ComboBoxStyle.DropDownList;
            profileCB.FormattingEnabled = true;
            profileCB.Location = new Point(133, 552);
            profileCB.Margin = new Padding(0);
            profileCB.Name = "profileCB";
            profileCB.Size = new Size(596, 28);
            profileCB.TabIndex = 36;
            // 
            // addRowButton
            // 
            addRowButton.Location = new Point(378, 43);
            addRowButton.Name = "addRowButton";
            addRowButton.Size = new Size(138, 29);
            addRowButton.TabIndex = 39;
            addRowButton.Text = "Добавить строку";
            addRowButton.UseVisualStyleBackColor = true;
            addRowButton.Click += addRowButton_Click;
            // 
            // panelTable2
            // 
            panelTable2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelTable2.BackColor = Color.Transparent;
            panelTable2.BackgroundImage = (Image)resources.GetObject("panelTable2.BackgroundImage");
            panelTable2.BackgroundImageLayout = ImageLayout.None;
            panelTable2.Controls.Add(bibliographyLabel);
            panelTable2.Controls.Add(addRowButton);
            panelTable2.Location = new Point(938, 297);
            panelTable2.Name = "panelTable2";
            panelTable2.Size = new Size(1131, 724);
            panelTable2.TabIndex = 41;
            // 
            // bibliographyLabel
            // 
            bibliographyLabel.AutoSize = true;
            bibliographyLabel.Location = new Point(89, 16);
            bibliographyLabel.Name = "bibliographyLabel";
            bibliographyLabel.Size = new Size(216, 20);
            bibliographyLabel.TabIndex = 41;
            bibliographyLabel.Text = "Название, автор, год издания";
            // 
            // panelTable3
            // 
            panelTable3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelTable3.BackColor = Color.Transparent;
            panelTable3.BackgroundImage = (Image)resources.GetObject("panelTable3.BackgroundImage");
            panelTable3.BackgroundImageLayout = ImageLayout.None;
            panelTable3.Controls.Add(resourcesLabel);
            panelTable3.Controls.Add(addRowButton2);
            panelTable3.Location = new Point(938, 297);
            panelTable3.Name = "panelTable3";
            panelTable3.Size = new Size(1131, 724);
            panelTable3.TabIndex = 42;
            // 
            // resourcesLabel
            // 
            resourcesLabel.AutoSize = true;
            resourcesLabel.Location = new Point(23, 16);
            resourcesLabel.Name = "resourcesLabel";
            resourcesLabel.Size = new Size(335, 20);
            resourcesLabel.TabIndex = 41;
            resourcesLabel.Text = "Наименование, адрес ресурса, режим доступа";
            // 
            // addRowButton2
            // 
            addRowButton2.Location = new Point(378, 43);
            addRowButton2.Name = "addRowButton2";
            addRowButton2.Size = new Size(138, 29);
            addRowButton2.TabIndex = 39;
            addRowButton2.Text = "Добавить строку";
            addRowButton2.UseVisualStyleBackColor = true;
            addRowButton2.Click += addRowButton2_Click;
            // 
            // panelTable1
            // 
            panelTable1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelTable1.AutoScroll = true;
            panelTable1.BackColor = Color.Transparent;
            panelTable1.BackgroundImage = (Image)resources.GetObject("panelTable1.BackgroundImage");
            panelTable1.BackgroundImageLayout = ImageLayout.None;
            panelTable1.Controls.Add(label6);
            panelTable1.Controls.Add(label2);
            panelTable1.Controls.Add(label3);
            panelTable1.Controls.Add(label4);
            panelTable1.Controls.Add(label5);
            panelTable1.Controls.Add(label7);
            panelTable1.Controls.Add(label8);
            panelTable1.Controls.Add(label10);
            panelTable1.Controls.Add(label9);
            panelTable1.Controls.Add(label12);
            panelTable1.Controls.Add(label11);
            panelTable1.Controls.Add(label14);
            panelTable1.Controls.Add(label13);
            panelTable1.Controls.Add(label16);
            panelTable1.Controls.Add(label15);
            panelTable1.Location = new Point(938, 297);
            panelTable1.Name = "panelTable1";
            panelTable1.Size = new Size(1131, 724);
            panelTable1.TabIndex = 54;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 120);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(276, 20);
            label1.TabIndex = 44;
            label1.Text = "Федеральное бюджетное учреждение";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(340, 160);
            label17.Margin = new Padding(0);
            label17.Name = "label17";
            label17.Size = new Size(168, 20);
            label17.TabIndex = 45;
            label17.Text = "«Университет «Дубна»";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_new_small_eng_PhotoRoom_png_PhotoRoom__2_;
            pictureBox1.Location = new Point(508, 98);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(178, 202);
            label20.Margin = new Padding(0);
            label20.Name = "label20";
            label20.Size = new Size(327, 20);
            label20.TabIndex = 49;
            label20.Text = "Россия, 141982, г. Дубна Московской области,";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(318, 222);
            label21.Margin = new Padding(0);
            label21.Name = "label21";
            label21.Size = new Size(187, 20);
            label21.TabIndex = 50;
            label21.Text = "ул. Университетская, д. 19";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(212, 242);
            label22.Margin = new Padding(0);
            label22.Name = "label22";
            label22.Size = new Size(293, 20);
            label22.TabIndex = 51;
            label22.Text = "Тел.: (496)216-64-64, факс: (496)216-60-96";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.OrangeRed;
            label23.Location = new Point(376, 262);
            label23.Margin = new Padding(0);
            label23.Name = "label23";
            label23.Size = new Size(129, 20);
            label23.TabIndex = 52;
            label23.Text = "www.uni-dubna.ru";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(341, 140);
            label19.Margin = new Padding(0);
            label19.Name = "label19";
            label19.Size = new Size(167, 20);
            label19.TabIndex = 48;
            label19.Text = "высшего образования";
            // 
            // disciplineNameCB
            // 
            disciplineNameCB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            disciplineNameCB.AutoCompleteMode = AutoCompleteMode.Append;
            disciplineNameCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            disciplineNameCB.BackColor = Color.White;
            disciplineNameCB.FormattingEnabled = true;
            disciplineNameCB.Items.AddRange(new object[] { "3D-моделирование и дизайн пространственной среды", "ERP-системы", "SEO - оптимизация портальных решений", "Web-дизайн и портальные технологии", "Автоматизация технологических процессов и производств", "Автоматизация управления жизненным циклом продукции", "Автоматизированный электропривод", "Автоматизированный электропривод технологических комплексов", "Адаптивные информационные и коммуникационные технологии", "Адаптивные коммуникационные и информационные технологии", "Администрирование вычислительных сетей", "Администрирование вычислительных систем", "Академический рисунок и живопись", "Актуарные расчеты", "Анализ данных в биологии и медицине", "Анализ финансовой отчетности", "Архитектура вычислительных систем", "Архитектурный дизайн", "Аудит информационной безопасности", "Аудит информационной инфраструктуры", "Базы данных", "Безопасность жизнедеятельности", "Бизнес-планирование", "Бизнес-планирование информационных проектов", "Бухгалтерский учет и отчетность", "Введение в квантовые вычисления", "Введение в программирование", "Веб-технологии", "Верификация программного обеспечения", "Вычислительные машины, системы и сети", "Геоинформационные системы", "Готовые офисные системы", "Готовые офисные технологии", "Графический дизайн", "Деловые презентации и коммуникации", "Деньги. Кредит. Банки", "Диагностика и надежность автоматизированных систем", "Дизайн в полиграфии", "Дизайн интерфейса", "Дизайн интерьера", "Дискретная математика", "Дифференциальные уравнения в прикладных задачах", "Допуски и посадки", "Защита информации", "Защита информации в смарт-контрактах и блокчейн", "Имитационное моделирование производственных процессов в пакете AnyLogic", "Инвестиции", "Инженерная графика", "Инженерная графика. Начертательная геометрия", "Инженерная и компьютерная графика", "Инженерно-технические методы и средства защиты информации", "Интегрированные системы проектирования и управления", "Интеллектуальные информационные системы поддержки принятия решений", "Интеллектуальные системы поддержки принятия решений в системах информационной безопасности", "Интернет в организационно-управленческой деятельности", "Интернет-маркетинг", "Информатика", "Информационная безопасность", "Информационные системы и технологии", "Информационные технологии 1С в прикладных задачах", "Информационные технологии управления знаниями", "Информационный менеджмент", "Исследование операций в экономике", "История экономики и экономических учений", "Калькулирование и бюджетирование в отраслях производственной сферы", "Компьютерная алгебра", "Компьютерная графика", "Компьютерные сети", "Компьютерные технологии анализа динамических систем", "Компьютерный дизайн", "Компьютерный практикум", "Контроль и учет затрат", "Концепции современного естествознания", "Концепция международных стандартов по обеспечению информационной безопасности", "Концепция современного естествознания", "Корпоративные ERP и CRM системы", "Корпоративные информационные системы", "Корреляционно-регрессионный анализ", "Криптографические методы и средства защиты информации", "Макроэкономика", "Маркетинг", "Материаловедение", "Машинное обучение и анализ данных", "Машинное обучение и интеллектуальный анализ данных", "Менеджмент", "Методы и технологии защиты информации ограниченного распространения", "Методы и технологии расследования инцидентов информационной безопасности", "Методы оптимизации", "Микропроцессоры", "Микроэкономика", "Многоагентное управление сложными системами", "Многоагентные системы", "Модели и методы анализа проектных решений", "Модели конфиденциальности, целостности и доступности информации", "Моделирование бизнес-процессов", "Моделирование и прогнозирование экономических процессов", "Моделирование информационных процессов", "Моделирование логистических систем", "Моделирование процессов и систем", "Моделирование систем", "Моделирование сложных сетей", "Мультимедийные и игровые технологии", "Надежность, эргономика и качество АСОИУ", "Надежность, эргономика и качество программных систем", "Налоги и налоговая система", "Низкоуровневое программирование", "Нормирование точности", "Облачные сервисы и виртуальные среды", "Обобщенное программирование", "Общая теория измерений", "Общая теория систем", "Объектно-ориентированное программирование", "Операционные системы", "Организация и планирование автоматизированных производств", "Организация и планирование производства", "Организация и развитие электронного бизнеса", "Основы библиографических знаний", "Основы библиографических знаний и информационной культуры", "Основы бюджетирования и закупочной деятельности", "Основы инженерного творчества", "Основы информационной безопасности", "Основы искусственного интеллекта", "Основы композиции", "Основы машинного обучения", "Основы менеджмента и маркетинга", "Основы микропроцессорной техники", "Основы монтажа и анимации", "Основы оценки эффективности инвестиционных проектов", "Основы поведенческой экономики", "Основы предпринимательства", "Основы программирования", "Основы проектной деятельности", "Основы теории и методы дизайна", "Основы теории управления", "Основы теории упругости", "Основы технического и фундаментального анализа фондового рынка", "Основы технологий виртуальной и дополненной реальности", "Основы электротехники и электроники систем управления", "Офисные информационные технологии", "Офисные технологии", "Параллельные вычисления на графических процессорах", "Параллельные и распределенные вычисления", "Перспективные технологии веб-разработки", "Практика научно-технического перевода", "Приложения баз данных", "Приложения баз данных (Разработка приложений баз данных)", "Применение искусственного интеллекта в решении прикладных экономических задач", "Программирование в UNIX", "Программирование графических процессоров", "Программирование мобильных устройств", "Программирование на Java", "Программирование на графических процессорах", "Программирование на языке высокого уровня", "Программирование с использованием открытых библиотек на Python", "Программирование управляющих устройств на базе Arduino", "Программная инженерия", "Программно-аппаратные средства защиты информации", "Программное обеспечение систем управления", "Программные технологии Интернет", "Проектирование автоматизированных систем", "Проектирование динамических систем на основе моделирования", "Проектирование и тестирование пользовательского интерфейса программных продуктов", "Проектирование интеллектуальных систем реального времени", "Проектирование информационных систем", "Проектирование компьютерных средств обучения", "Проектирование, архитектура и конструирование программных систем", "Проектирование, архитектура и конструирование программных средств", "Разработка веб-приложений", "Разработка и управление требованиями в проекте автоматизации", "Разработка мобильных приложений", "Разработка приложений баз данных", "Разработка приложений виртуальной и дополненной реальности", "Разработка приложений на Java", "Разработка приложений электронной коммерции", "Разработка требований к программному обеспечению", "Разработка фирменного стиля", "Реинжиниринг бизнес-процессов", "Реинжиниринг и управление бизнес-процессами", "Рекламный дизайн", "Риск-менеджмент", "Сервис-ориентированные архитектуры и приложения", "Сетевая безопасность", "Сети и телекоммуникации", "Системная инженерия", "Системная инженерия программного обеспечения", "Системное программное обеспечение", "Системы искусственного интеллекта", "Системы корпоративного электронного обучения", "Системы реального времени", "Системы управления знаниями", "Системы финансового мониторинга в корпоративном управлении", "Социально-экономические проблемы производства", "Средства автоматизации и управления", "Стандартизация и сертификация программных средств", "Стохастические модели в прикладных задачах", "Стратегический анализ в управлении", "Страхование", "Структура и функции сложных сетей", "Структуры и алгоритмы обработки данных", "Теоретическая механика", "Теоретические основы автоматизированного управления", "Теоретические основы электротехники", "Теория автоматического управления", "Теория автоматов и формальных языков", "Теория вероятности и математическая статистика", "Теория и методология защиты информации", "Теория конечных графов и ее приложения", "Теория принятия решений", "Теория систем и системный анализ", "Теория управления", "Теория языков программирования и методы трансляции", "Тестирование и проектирование пользовательского интерфейса программных продуктов", "Тестирование программного обеспечения", "Технические измерения и приборы", "Технологии full-stack разработки интернет-ориентированных систем", "Технологии Web 2.0", "Технологии анализа данных и машинное обучение", "Технологии баз данных", "Технологии бизнес-анализа", "Технологии визуализации данных", "Технологии высокопроизводительных вычислений", "Технологии мультимедиа", "Технологии программирования", "Технологии разработки приложений в области профессиональной деятельности", "Технологии распределённого анализа больших данных", "Технологии распределенного реестра", "Технологии тестирования", "Технологические процессы автоматизированных производств", "Технология LabView проектирования электронных систем", "Технология высокопроизводительных вычислений", "Технология программирования", "Управление бизнес-процессами", "Управление бизнес-процессами и сервисами", "Управление в автоматизированном производстве", "Управление в инновационном менеджменте и интеллектуальная собственность", "Управление знаниями в сложных системах", "Управление инновационными проектами", "Управление инновациями", "Управление информационной безопасностью", "Управление информационными проектами", "Управление информационными ресурсами", "Управление ИТ сервисами и контентом", "Управление качеством", "Управление качеством в производственных системах", "Управление основанное на данных", "Управление программными проектами", "Управление проектами", "Управление проектами автоматизации бизнеса", "Управление проектами разработки систем искусственного интеллекта", "Управление рисками", "Управление рисками информационных проектов", "Управление социотехническими системами", "Управление требованиями", "Управление, основанное на данных", "Управленческий учет", "Уравнения математической физики", "Философские вопросы современного естествознания, синергетики и устойчивого развития", "Финансовые и коммерческие расчеты", "Финансы", "Фондовые рынки и биржевое дело", "Функциональное программирование", "Функциональный анализ", "Ценные бумаги", "Цены и ценообразование", "Цифровая обработка сигналов", "Цифровая электроника", "Цифровые двойники и виртуальное тестирование", "Цифровые инновации в управлении предприятием", "Цифровые платформы управления корпоративными ИТ", "Человеко-машинное взаимодействие", "Численные методы", "Численные методы и их приложения", "Шаблоны проектирования в разработке программного обеспечения", "Экономика", "Экономика и предпринимательство", "Экономика информационной отрасли", "Экономика фирмы", "Экономический анализ финансово-хозяйственной деятельности предприятия", "Электронный бизнес", "Электротехника и электроника", "Языки и технологии анализа данных" });
            disciplineNameCB.Location = new Point(133, 685);
            disciplineNameCB.Margin = new Padding(0);
            disciplineNameCB.Name = "disciplineNameCB";
            disciplineNameCB.Size = new Size(596, 28);
            disciplineNameCB.TabIndex = 53;
            disciplineNameCB.SelectedIndexChanged += disciplineNameCB_SelectedIndexChanged;
            disciplineNameCB.DropDownClosed += comboBoxes_DropDownClosed;
            disciplineNameCB.TextChanged += disciplineNameCB_TextChanged;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.White;
            nextButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(471, 845);
            nextButton.Margin = new Padding(0);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(78, 29);
            nextButton.TabIndex = 55;
            nextButton.Text = "→";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.White;
            previousButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            previousButton.Location = new Point(393, 845);
            previousButton.Margin = new Padding(0);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(78, 29);
            previousButton.TabIndex = 56;
            previousButton.Text = "←";
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // FIOteacherCB
            // 
            FIOteacherCB.AutoCompleteMode = AutoCompleteMode.Append;
            FIOteacherCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            FIOteacherCB.BackColor = SystemColors.Window;
            FIOteacherCB.FormattingEnabled = true;
            FIOteacherCB.Items.AddRange(new object[] { "Абадеев Э.М.", "Абгарян В.С.", "Абдрахимов М.З.", "Абрамова Н.А.", "Авакова Т.Ф.", "Авдеев М.В.", "Авдеев С.П.", "Авдеева Е.С.", "Аверичев Г.С.", "Аверкин А.Н.", "Авраменко Е.В.", "Айриян А.С.", "Алексеев К.В.", "Алексеева Е.Н.", "Алексеева М.В.", "Аллахвердиева А.Э.", "Андреев В.А.", "Андреев О.А.", "Андронов С.В.", "Анисимова О.В.", "Анисимова Т.В.", "Антоненков Е.Г.", "Антонов А.Н.", "Анфимов Н.В.", "Апарин А.А.", "Арбузов А.Б.", "Арбузова Е.В.", "Арефьева А.В.", "Аржанухин С.В.", "Арзуманян Г.М.", "Артюх А.Г.", "Архипова Е.В.", "Афанасьев С.В.", "Багдасарьян Н.Г.", "Бадреева Д.Р.", "Байгунов И.А.", "Байдацкий А.В.", "Балаберников А.И.", "Балашова М.В.", "Балаян А.М.", "Балуева Т.В.", "Банишев А.Ф.", "Бархатова И.А.", "Басалаев А.В.", "Батурина В.Д.", "Баулина Л.В.", "Баутин В.В.", "Башашин М.В.", "Башкин А.В.", "Башкирова Ю.А.", "Бедняков А.В.", "Беднякова Т.М.", "Белов М.А.", "Белов О.В.", "Белова Е.В.", "Белькова Е.Ю.", "Беляков Д.В.", "Белясов С.Н.", "Березуцкая А.Ю.", "Бескровная Л.Г.", "Бобиков С.А.", "Бобриков И.А.", "Бобылева С.В.", "Боголюбская А.А.", "Богомолова Е.В.", "Богословский Д.Н.", "Богучарский А.Н.", "Боднарчук В.И.", "Бодров А.С.", "Божкова И.М.", "Боклагов Е.Н.", "Болонкина Е.А.", "Борейко А.В.", "Борзаков С.Б.", "Борисова Т.И.", "Бородин В.А.", "Бочек А.М.", "Бронников С.В.", "Бугай А.Н.", "Бугров А.Н.", "Буденная Н.Н.", "Будник В.В.", "Буздавина Е.Л.", "Булавин М.В.", "Буланов С.А.", "Булычев А.А.", "Булякова И.А.", "Бунина С.Г.", "Бурлака Н.П.", "Бурмистров М.С.", "Буслаев Д.Л.", "Бусыгин А.А.", "Быкова В.И.", "Бычков А.В.", "Бяковская Н.Г.", "Вагина О.В.", "Вайндорф-Сысоева М.Е.", "Ванина Е.Н.", "Васильев А.А.", "Васильева А.Ю.", "Васильева Н.В.", "Васин Р.Н.", "Венгер А.Л.", "Вербицкая С.В.", "Вершинина А.В.", "Вершинина Т.Н.", "Виноградова О.Е.", "Виноградова О.О.", "Виноградова Ю.В.", "Вкансия 1..", "Возакова А.С.", "Возвышаева Н.А.", "Возная У.Е.", "Воинова А.А.", "Волкова А.А.", "Волкова С.Б.", "Волохова А.В.", "Волощенко М.В.", "Воробьев В.В.", "Воробьева Е.В.", "Воропай А.Н.", "Вымекаева Т.В.", "Выпряжкина И.Б.", "Вьюшкина М.В.", "Вяземский А.А.", "Гайнанов В.Г.", "Галимов А.Р.", "Галицкая И.В.", "Гасиев А.Л.", "Гаспарян Г.С.", "Гашимова В.Р.", "Герасимук Э.Р.", "Герценбергер К.В.", "Гикал Б.Н.", "Гладуш Д.В.", "Гладышев П.П.", "Глушков А.И.", "Глушкова О.В.", "Гогоненков Г.Н.", "Головков М.С.", "Голубцова А.А.", "Гольденгорин Б.И.", "Голяткина Л.И.", "Гончаров О.А.", "Горбунов Н.В.", "Горбунова В.Н.", "Гордеев И.С.", "Горшкова Р.М.", "Горюнова Е.А.", "Графова Е.Н.", "Грибова Е.Д.", "Григорьев П.Н.", "Григорян О.А.", "Гришанин А.К.", "Гришанина Г.Э.", "Гришко С.И.", "Громок В.Л.", "Губернаторова М.А.", "Гумен К.Ф.", "Гусев А.А.", "Гутовский Д.И.", "Давыдов Е.А.", "Данилова Т.С.", "Дасько А.А.", "Двинских В.В.", "Дворницына А.А.", "Дедович Т.Г.", "Деникин А.С.", "Денисова Е.А.", "Денисова Н.Н.", "Джавадзаде Д.Н.", "Джолос Р.В.", "Дзюба Д.М.", "Дзюба С.Ф.", "Дидоренко А.В.", "Дмитриева С.О.", "Добрынин В.Н.", "Долгунова Л.С.", "Долженко А.Н.", "Донгузов И.И.", "Доркин С.М.", "Дорохин В.А.", "Дряблов Д.К.", "Дубовская И.С.", "Дудинова Т.Е.", "Думбрайс К.О.", "Душанов Э.Б.", "Дыдышко Е.В.", "Дымкова Р.Ф.", "Егорова И.А.", "Елисеева Е.А.", "Емельянов В.Ю.", "Еник Т.Л.", "Енукова Е.А.", "Енягина И.М.", "Епишина Е.В.", "Еремин А.В.", "Еремина Я.В.", "Еремкина И.Н.", "Ермолин Д.С.", "Ермольчик В.Л.", "Ершов Е.А.", "Ершов Н.М.", "Ефимова Е.М.", "Ефремова К.В.", "Жабицкая Е.И.", "Жарков А.Н.", "Жаткина К.Н.", "Железова С.М.", "Желтов О.Б.", "Жмылев П.Ю.", "Жмылева А.П.", "Журавлева Е.В.", "Журавлёва О.Д.", "Забивалова Н.М.", "Завьялов К.И.", "Заднепрянец М.Г.", "Задорожный А.М.", "Зазолина Е.В.", "Затеса А.В.", "Захаров В.И.", "Захаров М.А.", "Захарова А.А.", "Захарова Н.М.", "Згурский Н.А.", "Зеленков Ю.А.", "Земляная Е.В.", "Зенцова И.М.", "Зинченко Д.А.", "Зотов А.А.", "Зотова Е.Ю.", "Зрелов П.В.", "Зубков О.А.", "Зуев Б.К.", "Зуева Е.В.", "Иванов С.В.", "Иванцов И.Д.", "Иванцова О.В.", "Ивлиева Н.Ю.", "Игнатьева М.В.", "Ильина А.В.", "Иноземцева Н.Г.", "Исакова Т.Г.", "Кадочников И.С.", "Калагина Л.И.", "Калинина М.Ю.", "Калиновский Ю.Л.", "Каляшин С.В.", "Каманина И.З.", "Камбарова М.Н.", "Каменев А.С.", "Каплина С.П.", "Капралов М.И.", "Капусткина Е.С.", "Караваев А.И.", "Карасева Е.И.", "Карась Т.Ю.", "Карпов А.В.", "Катков В.Л.", "Кафтырева А.А.", "Кизим А.В.", "Кинев В.А.", "Кинева И.А.", "Кириллов П.Е.", "Киров Е.Ф.", "Кирова Д.Л.", "Кирпичев И.А.", "Кирпичёва Е.Ю.", "Кисеева В.И.", "Киселев М.А.", "Клименко А.А.", "Клименко О.П.", "Климова Е.И.", "Клюева С.И.", "Княжева Г.Н.", "Кобец В.В.", "Ковалев О.О.", "Коваленко М.А.", "Кожукалов В.А.", "Козлов С.А.", "Козулин Э.М.", "Кокорева М.Г.", "Кокоулина Е.С.", "Колбенко Е.В.", "Колганова Е.А.", "Колесников А.Г.", "Колигаев О.А.", "Кольчугина И.Л.", "Комендантова М.С.", "Комиссаров А.А.", "Компаниец О.Г.", "Кондратьев В.Н.", "Константинов Д.Ю.", "Константинова Е.В.", "Копач Ю.Н.", "Копылова Т.В.", "Кореньков В.В.", "Корнева Л.Г.", "Королев А.В.", "Король М.П.", "Корягин Д.А.", "Корягина Л.В.", "Коснырева М.В.", "Костромин С.В.", "Котиков А.В.", "Кошелев К.В.", "Кошлань И.В.", "Кравец А.Г.", "Кравец Л.И.", "Кравченко А.Л.", "Кравченко Ю.С.", "Красавин Е.А.", "Красавин С.Е.", "Красотин И.О.", "Красухин К.Г.", "Крейдер О.А.", "Кривцов А.И.", "Кривченко В.А.", "Кришталь В.Н.", "Крылов А.В.", "Крылова Д.А.", "Крыльский Д.В.", "Крюков Ю.А.", "Крюкова О.В.", "Кудрявцева Д.В.", "Кузнецов Б.К.", "Кузнецов Е.А.", "Кузнецов О.Л.", "Кузнецов Ю.И.", "Кузнецова С.В.", "Кузьмина Е.А.", "Куликов Д.Л.", "Куликов К.В.", "Курбатова А.В.", "Лавров Г.К.", "Лазарева Г.А.", "Ларионов В.А.", "Ларионова И.Г.", "Латош Б.Н.", "Лебедев А.М.", "Левтерова Е.А.", "Лесовая Е.Н.", "Лившиц В.Н.", "Лисицин Д.Е.", "Литвиненко А.Г.", "Лишилин М.В.", "Ломаченков И.А.", "Лопанова Л.В.", "Лопырева Е.А.", "Лукина Е.С.", "Лукьянов К.В.", "Лукьянов С.М.", "Лупанов П.Е.", "Лычагин Е.В.", "Любимова А.В.", "Любовинкина Н.Я.", "Люосев Д.А.", "Ляникова Е.В.", "Ляскович А.В.", "Мадфес Н.Ю.", "Мажитова Е..", "Мазуров Е.В.", "Макаров А.А.", "Макаров А.Ф.", "Макаров О.А.", "Максимук Т.В.", "Малахов А.И.", "Малахова Н.А.", "Малинин А.В.", "Малинина С.С.", "Малиновский И.Б.", "Маломарченков В.В.", "Малышева М.А.", "Мамедова Г.И.", "Мардыбан Е.В.", "Марков К.Н.", "Марченко Е.В.", "Марченко Т.А.", "Матвеев В.Г.", "Матвеева О.Н.", "Махалкина Т.О.", "Махнев Ю.В.", "Машарипов А.К.", "Медовников А.С.", "Мележик В.С.", "Мельник Е.П.", "Мельникова Н.Е.", "Мельникова О.И.", "Мещерская Ю.В.", "Мещерякова И.А.", "Миловидова А.А.", "Мильнов Г.Д.", "Минаев Г.А.", "Миндрина А.А.", "Минзов А.С.", "Миронов М.А.", "Миронов М.В.", "Митина Т.В.", "Митрофанов С.В.", "Михайлов И.Е.", "Михайлов Ф.Н.", "Михайлова Н.В.", "Михайлова Н.Ю.", "Михеев М.А.", "Мицын С.В.", "Мищенко М.А.", "Мокров Ю.В.", "Молодоженцева М.А.", "Монахов Д.В.", "Моржухин А.М.", "Моржухина С.В.", "Мороз В.В.", "Морозов В.В.", "Моталов Ю.Г.", "Мотовилов А.К.", "Мошковский И.В.", "Мурадян А.В.", "Муратова М.Ю.", "Мусихина И.А.", "Мухина И.В.", "Мухортов Д.С.", "Назаров А.И.", "Назмитдинов Р.Г.", "Напольский Ф.С.", "Нейчев Р..", "Немченок И.Б.", "Ненужное Н..", "Нестеренко В.О.", "Нечаев А.Н.", "Никитин А.А.", "Никитин В.К.", "Николаева Л.А.", "Никонов Э.Г.", "Нилушкова П.Е.", "Новиков И.В.", "Новиков К.В.", "Новикова В.Н.", "Новикова С.А.", "Новожилова Г.В.", "Ноздрин М.А.", "Обухов Я.Л.", "Овсяникова А.Е.", "Оганесян Ю.Ц.", "Орлова Е.Р.", "Осадчий Е.Г.", "Осипов А.А.", "Осипов П.А.", "Ососков Г.А.", "Офицерова Ж.В.", "Павлова Т.В.", "Панков С.А.", "Панов С.А.", "Панфёров С.В.", "Папоян В.В.", "Парфенова Т.Н.", "Парфенюк С.Б.", "Пахомова Е.А.", "Пелеванюк И.С.", "Перепелкин Е.Е.", "Петров А.Е.", "Петров В.А.", "Петров В.А.", "Петрова А.М.", "Петрова Е.Г.", "Петрова И.Ф.", "Петрова М.О.", "Пешков В.В.", "Пивин Р.В.", "Пиманова Н.Н.", "Пироженко И.Г.", "Пискунова О.И.", "Подгайный Д.В.", "Подгорный С.А.", "Позднякова Н.А.", "Полотнянко Н.А.", "Полухина Ю.П.", "Полуян С.В.", "Понкин Д.О.", "Попеко А.Г.", "Попов А.А.", "Попов В.Д.", "Попова Е.С.", "Порымов И.Е.", "Потапова Е.В.", "Потемкина С.В.", "Прахова Л.Ю.", "Прогулова Т.Б.", "Прох П.А.", "Прохоров Г.Ю.", "Пряхин В.Н.", "Пряхина Д.И.", "Пузова С.В.", "Пустовалова А.А.", "Пухаева Н.Е.", "Распопова Ю.Н.", "Рахмонов И.Р.", "Рахмонова А.Р.", "Рац Н.А.", "Рачков В.А.", "Резвая Е.П.", "Решетников А.Г.", "Решетников Г.П.", "Ржавцев А.А.", "Рогачева Н.С.", "Рогачевский О.В.", "Роенко А.О.", "Роенко А.А.", "Рожкова О.В.", "Розанов А.Ю.", "Романов Ю.И.", "Рудаков А.Ю.", "Рудных С.К.", "Рудык Э.Н.", "Рулев А.А.", "Румянцев М.М.", "Румянцева Н.С.", "Русакова Е.А.", "Рыбачук М.А.", "Рымшин А.В.", "Рысева О.А.", "Рычагова Н.В.", "Рябкова С.А.", "Рябов Н.В.", "Рябцев С.В.", "Савватеева О.А.", "Савватеева Т.П.", "Савина М.В.", "Сагайдак Н.А.", "Садовников В.М.", "Садырова Т.И.", "Сажиенко Е.В.", "Сазонов А.А.", "Сайко В.В.", "Сакрюкин С.В.", "Сакулин Д.Г.", "Салеев В.А.", "Самарин В.В.", "Самойлов Ю.Е.", "Самойлова М.В.", "Самохвалова Е.В.", "Сандалова О.В.", "Сандалова Т.В.", "Сафарова С.Ю.", "Сахаров Ю.С.", "Сахарова Н.А.", "Свиридова О.С.", "Свирихин А.И.", "Свистунова Л.В.", "Северюхин А.П.", "Северюхин Ю.С.", "Седых Г.С.", "Семенов А.Ю.", "Семячко Л.Н.", "Сеннер А.Е.", "Сеннер С.А.", "Сергеева Е.В.", "Середа Ю.М.", "Сидорин А.О.", "Сидоров Д.С.", "Сидорова М.В.", "Сидорова О.В.", "Силантьев А.В.", "Симоненко В.Г.", "Синицин А.А.", "Скуратов В.А.", "Слепцова Ю.А.", "Слободова Д.А.", "Смагин В.Д.", "Смагина Е.П.", "Смирнов Д.П.", "Смирнов Д.С.", "Смирнова Я.В.", "Соков О.А.", "Соколов А.С.", "Соколов И.А.", "Соколов Р.В.", "Соколова М.С.", "Сокотущенко В.Н.", "Солнышкина М.Г.", "Сорин А.С.", "Спаскова Н.О.", "Спирина Н.В.", "Стадник А.В.", "Станкус А.С.", "Старовойтова Л.И.", "Старостин Е.А.", "Стеценко С.Г.", "Стифорова Е.Г.", "Стрекаловский О.В.", "Стрелец И.Э.", "Стрельцова О.И.", "Суворов А.И.", "Супрунова О.Ю.", "Суслов И.А.", "Суханов В.Ю.", "Суханов М.Г.", "Сухов Е.В.", "Сухорукова В.В.", "Сыресин Е.М.", "Сычев П.П.", "Сычева М.П.", "Сюракшина Л.А.", "Тайнов В.А.", "Таначев И.А.", "Тарасенко А.В.", "Тарасов Е.Б.", "Тарасова О.В.", "Тарасова С.Ю.", "Тараховский Ю.С.", "Таскаев А.В.", "Теленков А.П.", "Тер-Акопьян Г.М.", "Терехова Е.А.", "Терлецкая И.Ю.", "Теряев Л.Н.", "Теряев О.В.", "Тестов Д.С.", "Тестов М.С.", "Технический с..", "Тималина Е.Ю.", "Тимонина Л.С.", "Тимошенко Г.Н.", "Тимушева Д.М.", "Тихомирова Е.С.", "Тихомирова И.К.", "Ткач О.В.", "Ткачев Л.Г.", "Ткаченко Е.С.", "Токарев М.В.", "Токарева Н.А.", "Толокнова К.В.", "Торосян А.Г.", "Третьяков А.В.", "Трофимов А.Т.", "Тюпикова Т.В.", "Тютюнников С.И.", "Тяпкин И.А.", "Тятюшкина О.Ю.", "Узиков Ю.Н.", "Укустов С.С.", "Ульянов С.В.", "Умрихин В.В.", "Устинов В.В.", "Учкина Н.А.", "Ушанкова М.Ю.", "Фадейкина И.Н.", "Федорков В.Г.", "Федоров С.В.", "Федорук Н.А.", "Федосеева Л.Н.", "Фесенко Р.П.", "Филин А.В.", "Филиппов М.Н.", "Филозова И.А.", "Философов Д.В.", "Финкельштейн М.Я.", "Флорко А.Б.", "Фомин В.Д.", "Фомина А.В.", "Фомичев А.С.", "Франк А.И.", "Фризен А.В.", "Фролов Е.А.", "Фронтасьева М.В.", "Фурсаев Д.В.", "Халиль А.С.", "Харевич Л.А.", "Харитонова Т.Б.", "Харламов В.А.", "Хозиев В.Б.", "Хозиева М.В.", "Хозяинов М.С.", "Холмуродов Х.Т.", "Хохлова С.П.", "Храмко Т.С.", "Хромов А.А.", "Цивенко Я.Б.", "Чабаненко Т.В.", "Чавлеишвили М.П.", "Чареев Д.А.", "Чаусов В.Н.", "Чебыкина Е.В.", "Чередник В.И.", "Черемисина Е.Н.", "Черепанов Е.А.", "Черепанова В.Г.", "Чермных Л.П.", "Черненко М.Д.", "Чернокожев Д.А.", "Чижов А.В.", "Чиркин И.А.", "Чистоступова М.В.", "Чураков А.В.", "Шабалин А.Ю.", "Шабанбекова Г.Г.", "Шадис В.С.", "Шадров К.Н.", "Шалаев В.В.", "Шамаева Е.Ф.", "Шамшеев В.С.", "Шандов М.М.", "Шевченко А.В.", "Шевчук И.И.", "Шешунова С.В.", "Шилова В.А.", "Шимон И.Я.", "Шимон Н.В.", "Шириков И.В.", "Шишков А.А.", "Шкурко М.А.", "Шматов С.В.", "Шмелева И.В.", "Шокин Я.В.", "Штейн А.Н.", "Штейн Е.А.", "Штемберг А.С.", "Шубина Е.В.", "Шукринов Ю.М.", "Шунейкин Г.П.", "Щеблыкина Ж.В.", "Щеголев В.Ю.", "Эпштейн А.А.", "Юсупов И.И.", "Юшанхай В.Ю.", "Ющенкова Д.В.", "Яблоков М.Ю.", "Яковенко С.Л.", "Яковлева Н.А.", "Якушина О.А.", "Яламов А.С.", "Ямщиков С.В." });
            FIOteacherCB.Location = new Point(458, 620);
            FIOteacherCB.Margin = new Padding(0);
            FIOteacherCB.Name = "FIOteacherCB";
            FIOteacherCB.Size = new Size(271, 28);
            FIOteacherCB.TabIndex = 57;
            FIOteacherCB.DropDownClosed += comboBoxes_DropDownClosed;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(133, 845);
            clearButton.Margin = new Padding(0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(126, 29);
            clearButton.TabIndex = 60;
            clearButton.Text = "Очистить все";
            toolTip1.SetToolTip(clearButton, "При нажатии на эту кнопку все текстовые поля очистятся и будут сгенерированы новые поля на основе введенных данных");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1902, 27);
            toolStrip1.TabIndex = 59;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { печатьToolStripMenuItem, предпросмотрToolStripMenuItem, сохранитьToolStripMenuItem, открытьВWordToolStripMenuItem, выходToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(59, 24);
            toolStripDropDownButton1.Text = "Файл";
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(202, 26);
            печатьToolStripMenuItem.Text = "Печать";
            печатьToolStripMenuItem.Click += печатьToolStripMenuItem_Click;
            // 
            // предпросмотрToolStripMenuItem
            // 
            предпросмотрToolStripMenuItem.Name = "предпросмотрToolStripMenuItem";
            предпросмотрToolStripMenuItem.Size = new Size(202, 26);
            предпросмотрToolStripMenuItem.Text = "Предпросмотр";
            предпросмотрToolStripMenuItem.ToolTipText = "При нажатии на кнопку \"Предпросмотр\" откроется приложение Word в режиме предпросмотра, а также окно печати";
            предпросмотрToolStripMenuItem.Click += предпросмотрToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(202, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // открытьВWordToolStripMenuItem
            // 
            открытьВWordToolStripMenuItem.Name = "открытьВWordToolStripMenuItem";
            открытьВWordToolStripMenuItem.Size = new Size(202, 26);
            открытьВWordToolStripMenuItem.Text = "Открыть в Word";
            открытьВWordToolStripMenuItem.ToolTipText = "При нажатии откроется документ Word с заполненным КПД, где будет доступна возможность редактирования";
            открытьВWordToolStripMenuItem.Click += открытьВWordToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(202, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(73, 24);
            toolStripButton1.Text = "Помощь";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(71, 24);
            toolStripButton2.Text = "Справка";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // courseworkСheckBox
            // 
            courseworkСheckBox.AutoSize = true;
            courseworkСheckBox.Location = new Point(584, 420);
            courseworkСheckBox.Margin = new Padding(0);
            courseworkСheckBox.Name = "courseworkСheckBox";
            courseworkСheckBox.Size = new Size(149, 24);
            courseworkСheckBox.TabIndex = 61;
            courseworkСheckBox.Text = "Курсовая работа";
            courseworkСheckBox.UseVisualStyleBackColor = true;
            // 
            // certificationTB
            // 
            certificationTB.ForeColor = Color.Black;
            certificationTB.Location = new Point(588, 748);
            certificationTB.Margin = new Padding(0);
            certificationTB.Name = "certificationTB";
            certificationTB.Size = new Size(52, 27);
            certificationTB.TabIndex = 62;
            certificationTB.KeyPress += hoursTextBox_KeyPress;
            // 
            // academichoursTB
            // 
            academichoursTB.ForeColor = Color.Black;
            academichoursTB.Location = new Point(588, 776);
            academichoursTB.Margin = new Padding(0);
            academichoursTB.Name = "academichoursTB";
            academichoursTB.Size = new Size(52, 27);
            academichoursTB.TabIndex = 63;
            academichoursTB.KeyPress += hoursTextBox_KeyPress;
            // 
            // zeTB
            // 
            zeTB.ForeColor = Color.Black;
            zeTB.Location = new Point(588, 804);
            zeTB.Margin = new Padding(0);
            zeTB.Name = "zeTB";
            zeTB.Size = new Size(52, 27);
            zeTB.TabIndex = 64;
            zeTB.KeyPress += hoursTextBox_KeyPress;
            // 
            // certificationLabel
            // 
            certificationLabel.AutoSize = true;
            certificationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            certificationLabel.Location = new Point(309, 748);
            certificationLabel.Margin = new Padding(0);
            certificationLabel.Name = "certificationLabel";
            certificationLabel.Size = new Size(250, 20);
            certificationLabel.TabIndex = 65;
            certificationLabel.Text = "часов промежуточной аттестации:";
            // 
            // academichoursLabel
            // 
            academichoursLabel.AutoSize = true;
            academichoursLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            academichoursLabel.Location = new Point(309, 777);
            academichoursLabel.Margin = new Padding(0);
            academichoursLabel.Name = "academichoursLabel";
            academichoursLabel.Size = new Size(161, 20);
            academichoursLabel.TabIndex = 66;
            academichoursLabel.Text = "академических часов:";
            // 
            // zeLabel
            // 
            zeLabel.AutoSize = true;
            zeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            zeLabel.Location = new Point(309, 804);
            zeLabel.Margin = new Padding(0);
            zeLabel.Name = "zeLabel";
            zeLabel.Size = new Size(132, 20);
            zeLabel.TabIndex = 67;
            zeLabel.Text = "зачетных единиц:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(133, 748);
            label18.Margin = new Padding(0);
            label18.Name = "label18";
            label18.Size = new Size(153, 20);
            label18.TabIndex = 68;
            label18.Text = "Укажите количество:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(508, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // fon
            // 
            fon.BackColor = Color.Transparent;
            fon.Image = (Image)resources.GetObject("fon.Image");
            fon.Location = new Point(869, 199);
            fon.Name = "fon";
            fon.Size = new Size(1131, 980);
            fon.SizeMode = PictureBoxSizeMode.Zoom;
            fon.TabIndex = 70;
            fon.TabStop = false;
            // 
            // tempBtn
            // 
            tempBtn.Location = new Point(768, 98);
            tempBtn.Name = "tempBtn";
            tempBtn.Size = new Size(0, 0);
            tempBtn.TabIndex = 71;
            tempBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tempBtn);
            Controls.Add(pictureBox2);
            Controls.Add(label18);
            Controls.Add(zeLabel);
            Controls.Add(academichoursLabel);
            Controls.Add(certificationLabel);
            Controls.Add(zeTB);
            Controls.Add(academichoursTB);
            Controls.Add(certificationTB);
            Controls.Add(courseworkСheckBox);
            Controls.Add(clearButton);
            Controls.Add(toolStrip1);
            Controls.Add(FIOteacherCB);
            Controls.Add(previousButton);
            Controls.Add(panelTable3);
            Controls.Add(nextButton);
            Controls.Add(panelTable2);
            Controls.Add(disciplineNameCB);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label1);
            Controls.Add(profileLabel);
            Controls.Add(profileCB);
            Controls.Add(kafedraCB);
            Controls.Add(kafedraLabel);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(fillButton);
            Controls.Add(FIOteacherLabel);
            Controls.Add(groupLabel);
            Controls.Add(nameLabel);
            Controls.Add(groupCB);
            Controls.Add(nameCB);
            Controls.Add(semesterCB);
            Controls.Add(semesterLabel);
            Controls.Add(courseCB);
            Controls.Add(courseLabel);
            Controls.Add(disciplineNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panelTable1);
            Controls.Add(fon);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заполнение календарного плана дисциплины";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panelTable2.ResumeLayout(false);
            panelTable2.PerformLayout();
            panelTable3.ResumeLayout(false);
            panelTable3.PerformLayout();
            panelTable1.ResumeLayout(false);
            panelTable1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label disciplineNameLabel;
        private Label courseLabel;
        private ComboBox courseCB;
        private Label semesterLabel;
        private ComboBox semesterCB;
        private ComboBox nameCB;
        private ComboBox groupCB;
        private Label nameLabel;
        private Label groupLabel;
        private Label FIOteacherLabel;
        private Button fillButton;
        private DateTimePicker startDateTimePicker;
        private Label startDateLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ComboBox kafedraCB;
        private Label kafedraLabel;
        private Label profileLabel;
        private ComboBox profileCB;
        private Button addRowButton;
        private Panel panelTable2;
        private Label bibliographyLabel;
        private Panel panelTable3;
        private Label resourcesLabel;
        private Button addRowButton2;
        private Label label1;
        private Label label17;
        private PictureBox pictureBox1;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label19;
        private ComboBox disciplineNameCB;
        private Panel panelTable1;
        private Button nextButton;
        private Button previousButton;
        private ComboBox FIOteacherCB;
        private ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem предпросмотрToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьВWordToolStripMenuItem;
        private Button clearButton;
        private CheckBox courseworkСheckBox;
        private TextBox certificationTB;
        private TextBox academichoursTB;
        private TextBox zeTB;
        private Label certificationLabel;
        private Label academichoursLabel;
        private Label zeLabel;
        private Label label18;
        private PictureBox pictureBox2;
        private PictureBox fon;
        private Button tempBtn;
    }
}