using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace KPDfilling
{
    public partial class MainForm : Form
    {
        public int addRowsCount = 18;
        public int firstTextboxIndex = 1;
        public int textBoxIndex = 1;
        public int top2 = 73;
        public int left2 = 5;
        public int top3 = 73;
        public int left3 = 5;
        public int numOfClicks1 = 1;
        public int numOfClicks2 = 1;
        public int countOfClicks = 0;
        public int countPanel1 = 0;
        public int countPanel2 = 0;
        WordDocument wordDoc = null;
        private string pathToTemplate { get { return System.Windows.Forms.Application.StartupPath + "KPDtemplate.docx"; } }
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateTextBoxes1()
        {
            int tbNum = 1;
            if ((courseCB.SelectedIndex == 3 || courseCB.SelectedIndex == 5) && (semesterCB.SelectedIndex == 1))
                addRowsCount = 15;
            else
                addRowsCount = 18;
            int left = 23;
            int top = 65;

            for (int i = 1; i < addRowsCount; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(29, 22);
                textBox.KeyPress += hoursTextBox_KeyPress;
                panelTable1.Controls.Add(textBox);
                top += 30;
                textBox.Text = "2";
            }
        }

        private void CreateTextBoxes2()
        {
            int tbNum = 2;
            int left = 55;
            int top = 65;

            for (int i = 2; i < addRowsCount + 1; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(100, 22);
                textBox.MouseHover += textBox_MouseHover;
                textBox.MouseLeave += textBox_MouseLeave;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }

        private void CreateTextBoxes3()
        {
            int tbNum = 3;
            int left = 195;
            int top = 65;

            for (int i = 3; i < addRowsCount + 2; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(29, 22);
                textBox.KeyPress += hoursTextBox_KeyPress;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }

        private void CreateTextBoxes4()
        {
            int tbNum = 4;
            int left = 227;
            int top = 65;

            for (int i = 4; i < addRowsCount + 3; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(100, 22);
                textBox.MouseHover += textBox_MouseHover;
                textBox.MouseLeave += textBox_MouseLeave;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }
        private void CreateTextBoxes5()
        {
            int tbNum = 5;
            int left = 366;
            int top = 65;

            for (int i = 5; i < addRowsCount + 4; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(29, 22);
                textBox.KeyPress += hoursTextBox_KeyPress;
                panelTable1.Controls.Add(textBox);
                top += 30;
                textBox.Text = "2";
            }
        }
        private void CreateTextBoxes6()
        {
            int tbNum = 6;
            int left = 398;
            int top = 65;

            for (int i = 6; i < addRowsCount + 5; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(100, 22);
                textBox.MouseHover += textBox_MouseHover;
                textBox.MouseLeave += textBox_MouseLeave;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }
        private void CreateTextBoxes7()
        {
            int tbNum = 7;
            int left = 556;
            int top = 65;

            for (int i = 7; i < addRowsCount + 6; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(29, 22);
                textBox.KeyPress += hoursTextBox_KeyPress;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }
        private void CreateTextBoxes8()
        {
            int tbNum = 8;
            int left = 650;
            int top = 65;

            for (int i = 8; i < addRowsCount + 7; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(100, 22);
                textBox.MouseHover += textBox_MouseHover;
                textBox.MouseLeave += textBox_MouseLeave;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }
        private void CreateTextBoxes9()
        {
            int tbNum = 9;
            int left = 756;
            int top = 65;

            for (int i = 9; i < addRowsCount + 8; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(29, 22);
                textBox.KeyPress += hoursTextBox_KeyPress;
                panelTable1.Controls.Add(textBox);
                top += 30;
                textBox.Text = "4";
            }
        }
        private void CreateTextBoxes10()
        {
            int tbNum = 10;
            int left = 790;
            int top = 65;

            for (int i = 10; i < addRowsCount + 9; i++)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Name = "textBox" + tbNum;
                tbNum += 10;
                textBox.Location = new System.Drawing.Point(left, top);
                textBox.Size = new Size(100, 22);
                textBox.MouseHover += textBox_MouseHover;
                textBox.MouseLeave += textBox_MouseLeave;
                panelTable1.Controls.Add(textBox);
                top += 30;
            }
        }

        private void CreateTextBoxesTable2()
        {
            int left = 5;
            int top = 43;
            if (textBoxIndex == 1)
            {
                if (addRowsCount >= 16)
                    textBoxIndex = 171;
                else if (addRowsCount <= 15)
                    textBoxIndex = 141;
            }

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Name = "textBox" + textBoxIndex;
            textBoxIndex++;
            textBox.Location = new System.Drawing.Point(left, top);
            textBox.Size = new Size(370, 22);
            textBox.MouseHover += textBox_MouseHover;
            textBox.MouseLeave += textBox_MouseLeave;
            panelTable2.Controls.Add(textBox);
        }
        private void CreateTextBoxesTable3()
        {
            if (lines.Count > 0)
            {
                if (textBoxIndex == 1)
                {
                    if (addRowsCount >= 16)
                        textBoxIndex = 171;
                    else if (addRowsCount <= 15)
                        textBoxIndex = 141;
                }
            }
            int left = 5;
            int top = 43;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Name = "textBox" + textBoxIndex;
            textBoxIndex++;
            textBox.Location = new System.Drawing.Point(left, top);
            textBox.Size = new Size(370, 22);
            textBox.MouseHover += textBox_MouseHover;
            textBox.MouseLeave += textBox_MouseLeave;
            panelTable3.Controls.Add(textBox);
        }

        private void RemoveTextBoxes()
        {
            for (int i = panelTable1.Controls.Count - 1; i >= 0; i--)
            {
                if (panelTable1.Controls[i] is System.Windows.Forms.TextBox)
                {
                    panelTable1.Controls.RemoveAt(i);
                }
            }
            for (int i = panelTable2.Controls.Count - 1; i >= 0; i--)
            {
                if (panelTable2.Controls[i] is System.Windows.Forms.TextBox)
                {
                    panelTable2.Controls.RemoveAt(i);
                }
            }
            for (int i = panelTable3.Controls.Count - 1; i >= 0; i--)
            {
                if (panelTable3.Controls[i] is System.Windows.Forms.TextBox)
                {
                    panelTable3.Controls.RemoveAt(i);
                }
            }
        }

        public class Book
        {
            public string bibl { get; set; }
        }

        public List<String> lines = new List<String>();

        public async void Bibliography()
        {
            string url = "https://lib.uni-dubna.ru/MegaPro/API?Method=SearchKKO&discipline=" + disciplineNameCB.Text + "&ngr=" + groupCB.Text;
            HttpClient httpClient = new HttpClient();
            try
            {
                lines.Clear();
                string json = await httpClient.GetStringAsync(url);
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json);

                foreach (Book book in books)
                {
                    string bibl = book.bibl;
                    string line = bibl.Replace("<b>", "");
                    line = line.Replace("</b>", "");
                    line = line.Replace("<br>", "");
                    line = line.Replace("</br>", "");
                    lines.Add(line);
                }
                if (lines.Count == 0)
                {
                    MessageBox.Show("Для указанной группы по данной дисциплине литература не найдена!", "Внимание!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при десериализации JSON: " + ex.Message, "Внимание!");
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            wordDoc = null;
            try
            {
                DateTime startDay = startDateTimePicker.Value;
                int year = Convert.ToInt32(startDay.ToString("yyyy"));
                int year2 = Convert.ToInt32(year) + 1;
                if (Convert.ToInt32(startDay.ToString("MM")) <= 7)
                {
                    year -= 1;
                    year2 -= 1;
                }
                string doubleyear = year.ToString() + "/" + year2.ToString();
                string date3 = startDay.ToString("«dd» MMMM yyyy");
                wordDoc = new WordDocument(pathToTemplate);

                wordDoc.SetSelectionToText("@@disciplineName");
                wordDoc.Selection.Aligment = TextAligment.Center;
                wordDoc.Selection.Text = disciplineNameCB.Text;

                wordDoc.SetSelectionToText("@@course");
                wordDoc.Selection.Text = courseCB.Text;

                wordDoc.SetSelectionToText("@@semester");
                wordDoc.Selection.Text = semesterCB.Text;

                wordDoc.SetSelectionToText("@@name");
                wordDoc.Selection.Text = nameCB.Text;

                wordDoc.SetSelectionToText("@@group");
                wordDoc.Selection.Text = groupCB.Text;

                wordDoc.SetSelectionToText("@@year");
                wordDoc.Selection.Text = doubleyear;

                wordDoc.SetSelectionToText("@@teacherFIO");
                wordDoc.Selection.Text = FIOteacherCB.Text;

                wordDoc.SetSelectionToText("@@kafedra");
                wordDoc.Selection.Aligment = TextAligment.Center;
                wordDoc.Selection.Text = kafedraCB.Text;

                if (kafedraCB.SelectedIndex == 0)
                    wordDoc.ReplaceAllStrings("@@kafedraFIO", "Черемисина Е.Н.");
                else if (kafedraCB.SelectedIndex == 1)
                    wordDoc.ReplaceAllStrings("@@kafedraFIO", "Кореньков В.В.");
                else if (kafedraCB.SelectedIndex == 2)
                    wordDoc.ReplaceAllStrings("@@kafedraFIO", "Любимова А.В.");
                else if (kafedraCB.SelectedIndex == 3)
                    wordDoc.ReplaceAllStrings("@@kafedraFIO", "Тюпикова Т.В.");
                else if (kafedraCB.SelectedIndex == 4)
                    wordDoc.ReplaceAllStrings("@@kafedraFIO", "Токарева Н.А.");
                else if (kafedraCB.SelectedIndex == 5)
                    wordDoc.ReplaceAllStrings("@@kafedraFIO", "Крюков Ю.А.");

                wordDoc.SetSelectionToText("@@date");
                wordDoc.Selection.Text = date3;

                wordDoc.SetSelectionToText("@@profile");
                wordDoc.Selection.Text = profileCB.Text;

                wordDoc.SetSelectionToText("@@certification");
                wordDoc.Selection.Text = certificationTB.Text;
                wordDoc.Selection.Bold = true;

                wordDoc.SetSelectionToText("@@academichours");
                wordDoc.Selection.Text = academichoursTB.Text;
                wordDoc.Selection.Bold = true;

                wordDoc.SetSelectionToText("@@ze");
                wordDoc.Selection.Text = zeTB.Text;
                wordDoc.Selection.Bold = true;

                int tableNum = 2;
                wordDoc.SelectTable(tableNum);
                if (courseworkСheckBox.Checked)
                    wordDoc.AddRowToTable();
                int count = 1;
                for (int addRowsNum = 1; addRowsNum <= addRowsCount; addRowsNum++)
                {
                    wordDoc.AddRowToTable();
                    if (count == 1)
                        wordDoc.SetSelectionToCell(5, 1);
                    else if (count > 1)
                        wordDoc.SetSelectionToCell(addRowsNum + 3, 1);
                    count++;

                    DateTime date = startDateTimePicker.Value;
                    DateTime date2 = date.AddDays(7);
                    if (date.DayOfWeek == DayOfWeek.Monday)
                    {
                        date2 = date.AddDays(5);
                    }
                    else if (date.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        date2 = date.AddDays(4);
                    }
                    else if (date.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        date2 = date.AddDays(3);
                    }
                    else if (date.DayOfWeek == DayOfWeek.Thursday)
                    {
                        date2 = date.AddDays(2);
                    }
                    else if (date.DayOfWeek == DayOfWeek.Friday)
                    {
                        date2 = date.AddDays(1);
                    }
                    else if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        date2 = date;
                    }
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        MessageBox.Show("Выбранный день - выходной!", "Внимание!");
                        return;
                    }
                    for (int i = 1; i < addRowsNum; i++)
                    {
                        wordDoc.Selection.Text = i + " неделя \n с " + date.ToString("dd.MM.yy") + "\n по " + date2.ToString("dd.MM.yy");
                        date = date2.AddDays(2);
                        date2 = date.AddDays(5);
                    }
                    wordDoc.Selection.Aligment = TextAligment.Center;
                    if (courseworkСheckBox.Checked)
                    {
                        wordDoc.SetSelectionToCell(addRowsCount + addRowsNum - 2, 1);
                        wordDoc.Selection.Text = "Курсовая работа / проект (выполняется в течение семестра)";
                        wordDoc.SetSelectionToCell(addRowsCount + addRowsNum - 1, 1);
                    }
                    else
                        wordDoc.SetSelectionToCell(addRowsCount + addRowsNum - 2, 1);
                }
                wordDoc.Selection.Text = "ВСЕГО";
                wordDoc.Selection.Bold = true;
                wordDoc.Selection.Aligment = TextAligment.Center;
                wordDoc.Selection.FontSize = 9;

                int hours1 = 0;
                int hours3 = 0;
                int hours5 = 0;
                int hours7 = 0;
                int hours9 = 0;

                int textboxIndex = firstTextboxIndex;
                for (int rowNum = 5; rowNum <= addRowsCount + 3; rowNum++)
                {
                    for (int columnNum = 2; columnNum <= 11; columnNum++)
                    {
                        wordDoc.SetSelectionToCell(rowNum, columnNum);
                        System.Windows.Forms.TextBox textBox = Controls.Find("textBox" + textboxIndex.ToString(), true).FirstOrDefault() as System.Windows.Forms.TextBox;
                        if (textBox != null)
                        {
                            wordDoc.Selection.Text = textBox.Text;
                            if ((int.TryParse(textBox.Text, out int distance)) && (textBox.Text != ""))
                            {
                                wordDoc.Selection.Aligment = TextAligment.Center;
                                if (textboxIndex % 10 == 1)
                                    hours1 += Convert.ToInt32(textBox.Text);
                                else if (textboxIndex % 10 == 3)
                                    hours3 += Convert.ToInt32(textBox.Text);
                                else if (textboxIndex % 10 == 5)
                                    hours5 += Convert.ToInt32(textBox.Text);
                                else if (textboxIndex % 10 == 7)
                                    hours7 += Convert.ToInt32(textBox.Text);
                                else if (textboxIndex % 10 == 9)
                                    hours9 += Convert.ToInt32(textBox.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при замене текста в таблице 1.", "Внимание!");
                            wordDoc.Selection.Text = "error";
                        }
                        textboxIndex++;
                    }
                }
                wordDoc.SetSelectionToCell(23, 2);
                wordDoc.Selection.Aligment = TextAligment.Center;
                if (hours1 == 0)
                    wordDoc.Selection.Text = "";
                else
                    wordDoc.Selection.Text = hours1.ToString();
                wordDoc.SetSelectionToCell(23, 4);
                wordDoc.Selection.Aligment = TextAligment.Center;
                if (hours3 == 0)
                    wordDoc.Selection.Text = "";
                else
                    wordDoc.Selection.Text = hours3.ToString();
                wordDoc.SetSelectionToCell(23, 6);
                wordDoc.Selection.Aligment = TextAligment.Center;
                if (hours5 == 0)
                    wordDoc.Selection.Text = "";
                else
                    wordDoc.Selection.Text = hours5.ToString();
                wordDoc.SetSelectionToCell(23, 8);
                wordDoc.Selection.Aligment = TextAligment.Center;
                if (hours7 == 0)
                    wordDoc.Selection.Text = "";
                else
                    wordDoc.Selection.Text = hours7.ToString();
                wordDoc.SetSelectionToCell(23, 10);
                wordDoc.Selection.Aligment = TextAligment.Center;
                if (hours9 == 0)
                    wordDoc.Selection.Text = "";
                else
                    wordDoc.Selection.Text = hours9.ToString();

                if (courseworkСheckBox.Checked)
                {
                    if (addRowsCount < 17)
                    {
                        wordDoc.MergeCells(19, 1, 19, 11);
                        wordDoc.SetSelectionToCell(19, 1);
                    }
                    else
                    {
                        wordDoc.MergeCells(22, 1, 22, 11);
                        wordDoc.SetSelectionToCell(22, 1);
                    }
                    wordDoc.Selection.Aligment = TextAligment.Left;
                }

                tableNum = 3;
                wordDoc.SelectTable(tableNum);
                if (lines.Count > 0)
                {
                    for (int rowNum = 1; rowNum < lines.Count; rowNum++)
                    {
                        wordDoc.AddRowToTable();
                        wordDoc.SetSelectionToCell(rowNum + 2, 1);
                        wordDoc.Selection.Aligment = TextAligment.Center;
                        wordDoc.Selection.Text = rowNum.ToString();
                        wordDoc.SetSelectionToCell(rowNum + 1, 2);
                        wordDoc.Selection.Text = lines[rowNum - 1];
                    }
                }
                else
                {
                    for (int rowNum = 1; rowNum <= numOfClicks1; rowNum++)
                    {
                        wordDoc.AddRowToTable();
                        wordDoc.SetSelectionToCell(rowNum + 1, 1);
                        wordDoc.Selection.Aligment = TextAligment.Center;
                        wordDoc.Selection.Text = rowNum.ToString();
                        wordDoc.SetSelectionToCell(rowNum + 1, 2);
                        System.Windows.Forms.TextBox textBox = panelTable2.Controls.Find("textBox" + textboxIndex.ToString(), true).FirstOrDefault() as System.Windows.Forms.TextBox;
                        if (textBox != null)
                        {
                            wordDoc.Selection.Text = textBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при замене текста в таблице 2.", "Внимание!");
                            wordDoc.Selection.Text = "error";
                        }
                        textboxIndex++;
                    }
                }
                tableNum = 4;
                wordDoc.SelectTable(tableNum);
                for (int rowNum = 1; rowNum <= numOfClicks2; rowNum++)
                {
                    wordDoc.AddRowToTable();
                    wordDoc.SetSelectionToCell(rowNum + 1, 1);
                    wordDoc.Selection.Aligment = TextAligment.Center;
                    wordDoc.Selection.Text = rowNum.ToString();
                    wordDoc.SetSelectionToCell(rowNum + 1, 2);
                    System.Windows.Forms.TextBox textBox = panelTable3.Controls.Find("textBox" + textboxIndex.ToString(), true).FirstOrDefault() as System.Windows.Forms.TextBox;
                    if (textBox != null)
                    {
                        wordDoc.Selection.Text = textBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при замене текста в таблице 3.", "Внимание!");
                        wordDoc.Selection.Text = "error";
                    }
                    textboxIndex++;
                }
            }
            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }
                MessageBox.Show("Ошибка при замене текста в документе Word. Подробности: " + error.Message, "Внимание!");
                return;
            }

            MessageBox.Show("Документ заполнен.\nДальнейшие действия с ним доступны во вкладке 'Файл'.", "Успешно!");
            печатьToolStripMenuItem.Enabled = true;
            предпросмотрToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;
            открытьВWordToolStripMenuItem.Enabled = true;
            fillButton.Enabled = true;
            textBoxIndex = 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fon.Visible = true;
            previousButton.Enabled = false;
            nextButton.Enabled = true;
            fillButton.Enabled = false;
            panelTable1.Hide();
            nameCB.Enabled = false;
            groupCB.Enabled = false;
            semesterCB.Enabled = false;
            profileCB.Enabled = false;
            nextButton.Enabled = false;
            disciplineNameCB.Enabled = false;
            FIOteacherCB.Enabled = false;
            печатьToolStripMenuItem.Enabled = false;
            предпросмотрToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            открытьВWordToolStripMenuItem.Enabled = false;
            panelTable2.Visible = false;
            panelTable3.Visible = false;
            clearButton.Enabled = false;
        }

        private void courseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            disciplineNameCB.SelectedIndex = -1;
            semesterCB.Enabled = true;
            semesterCB.SelectedIndex = -1;
            profileCB.Items.Clear();
            groupCB.Items.Clear();
            profileCB.Enabled = false;
            nameCB.Enabled = false;
            groupCB.Enabled = false;
            disciplineNameCB.Enabled = false;
            if (courseCB.SelectedIndex <= 3)
            {
                nameCB.Items.Clear();
                nameCB.Items.AddRange(new string[] { "01.03.02 Прикладная математика и информатика", "02.03.02 Фундаментальная информатика и информационные технологии", "09.03.01 Информатика и вычислительная техника", "09.03.02 Информационные системы и технологии", "09.03.03 Прикладная информатика", "09.03.04 Программная инженерия", "15.03.04 Автоматизация технологических процессов и производств", "38.03.01 Экономика", "38.03.05 Бизнес - информатика" });
            }
            else if (courseCB.SelectedIndex >= 4)
            {
                nameCB.Items.Clear();
                nameCB.Items.AddRange(new string[] { "01.04.02 Прикладная математика и информатика", "09.04.03 Прикладная информатика", "27.04.03 Системный анализ и управление" });
            }
        }

        private void semesterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameCB.Enabled = true;
        }

        private void nameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            profileCB.Enabled = true;
            groupCB.Enabled = true;
            string dircode = "";
            groupCB.Items.Clear();
            profileCB.Items.Clear();
            disciplineNameCB.SelectedIndex = -1;
            disciplineNameCB.Enabled = false;
            int course = courseCB.SelectedIndex + 1;
            if (courseCB.SelectedIndex <= 3)
            {
                if (nameCB.SelectedIndex == 0)
                {
                    dircode = "18";
                    profileCB.Items.Add("Прикладная математика и информатика(общий профиль)");
                    profileCB.Items.Add("Математическое моделирование");
                }
                else if (nameCB.SelectedIndex == 1)
                {
                    dircode = "22";
                    profileCB.Items.Add("Сетевые технологии");
                }
                else if (nameCB.SelectedIndex == 2)
                {
                    dircode = "01";
                    profileCB.Items.Add("Инженерия систем искусственного интеллекта");
                    profileCB.Items.Add("Технологии разработки программного обеспечения");
                }
                else if (nameCB.SelectedIndex == 3)
                {
                    dircode = "28";
                    profileCB.Items.Add("Безопасность информационных систем");
                    profileCB.Items.Add("Геоинформационные системы и технологии");
                }
                else if (nameCB.SelectedIndex == 4)
                {
                    dircode = "07";
                    profileCB.Items.Add("Прикладная информатика в управлении корпоративными системами");
                    profileCB.Items.Add("Информационные технологии в управлении цифровой экономикой");
                    profileCB.Items.Add("Прикладная информатика в компьютерном дизайне");
                }
                else if (nameCB.SelectedIndex == 5)
                {
                    dircode = "25";
                    profileCB.Items.Add("Разработка программно-информационных систем");
                }
                else if (nameCB.SelectedIndex == 6)
                {
                    dircode = "23";
                    profileCB.Items.Add("Интеллектуальные системы управления роботизированными системами");
                }
                else if (nameCB.SelectedIndex == 7)
                {
                    dircode = "03";
                    profileCB.Items.Add("Цифровые технологии в бизнесе");
                    profileCB.Items.Add("Экономика организации");
                    profileCB.Items.Add("Анализ данных и методы оптимизации в экономике");
                }
                else if (nameCB.SelectedIndex == 8)
                {
                    dircode = "27";
                    profileCB.Items.Add("Электронный бизнес");
                }
            }
            else if (courseCB.SelectedIndex >= 4)
            {
                if (nameCB.SelectedIndex == 0)
                {
                    dircode = "18";
                    profileCB.Items.Add("Искусственный интеллект в системах управления");
                    profileCB.Items.Add("Искусственный интеллект в цифровой экономике");
                }
                else if (nameCB.SelectedIndex == 1)
                {
                    dircode = "07";
                    profileCB.Items.Add("Математическое моделирование и анализ данных");
                    profileCB.Items.Add("Математическое моделирование");
                }
                else if (nameCB.SelectedIndex == 2)
                {
                    dircode = "01";
                    profileCB.Items.Add("Цифровые платформы и аналитика больших данных");
                    profileCB.Items.Add("Интеллектуальные технологии в управлении цифровым производством");
                    profileCB.Items.Add("Геоинформационные технологии в управлении сложными системами");
                    profileCB.Items.Add("Бизнес-аналитика и интеллектуальный анализ данных");
                }
            }
            for (int i = 1; i <= 6; i++)
                groupCB.Items.Add(course + dircode.ToString() + i.ToString());
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Name = "textBox" + textBoxIndex;
            textBoxIndex++;
            textBox.Location = new System.Drawing.Point(left2, top2);
            textBox.Size = new Size(370, 22);
            textBox.MouseHover += textBox_MouseHover;
            textBox.MouseLeave += textBox_MouseLeave;
            panelTable2.Controls.Add(textBox);
            top2 += 30;
            numOfClicks1++;
        }

        private void addRowButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Name = "textBox" + textBoxIndex;
            textBoxIndex++;
            textBox.Location = new System.Drawing.Point(left3, top3);
            textBox.Size = new Size(370, 22);
            textBox.MouseHover += textBox_MouseHover;
            textBox.MouseLeave += textBox_MouseLeave;
            panelTable3.Controls.Add(textBox);
            top3 += 30;
            numOfClicks2++;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            countOfClicks++;
            if (lines.Count > 0)
            {
                if (countOfClicks == 0)
                {
                    previousButton.Enabled = false;
                    nextButton.Enabled = true;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Hide();
                }

                if (countOfClicks == 1)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    panelTable1.Show();
                    panelTable2.Hide();
                    panelTable3.Hide();
                    CreateTextBoxes1();
                    CreateTextBoxes2();
                    CreateTextBoxes3();
                    CreateTextBoxes4();
                    CreateTextBoxes5();
                    CreateTextBoxes6();
                    CreateTextBoxes7();
                    CreateTextBoxes8();
                    CreateTextBoxes9();
                    CreateTextBoxes10();
                    courseCB.Enabled = false;
                    semesterCB.Enabled = false;
                    groupCB.Enabled = false;
                    profileCB.Enabled = false;
                    nameCB.Enabled = false;
                    clearButton.Enabled = false;
                    disciplineNameCB.Enabled = false;
                    clearButton.Enabled = false;
                }
                if (countOfClicks == 2)
                {
                    fillButton.Enabled = true;
                    previousButton.Enabled = true;
                    nextButton.Enabled = false;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Show();
                    if (countPanel2 == 0)
                    {
                        CreateTextBoxesTable3();
                        countPanel2++;
                    }
                }
            }
            else
            {
                if (countOfClicks == 0)
                {
                    previousButton.Enabled = false;
                    nextButton.Enabled = true;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Hide();
                }

                if (countOfClicks == 1)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    panelTable1.Show();
                    panelTable2.Hide();
                    panelTable3.Hide();
                    CreateTextBoxes1();
                    CreateTextBoxes2();
                    CreateTextBoxes3();
                    CreateTextBoxes4();
                    CreateTextBoxes5();
                    CreateTextBoxes6();
                    CreateTextBoxes7();
                    CreateTextBoxes8();
                    CreateTextBoxes9();
                    CreateTextBoxes10();
                    courseCB.Enabled = false;
                    semesterCB.Enabled = false;
                    groupCB.Enabled = false;
                    profileCB.Enabled = false;
                    nameCB.Enabled = false;
                    clearButton.Enabled = false;
                    disciplineNameCB.Enabled = false;
                    clearButton.Enabled = false;
                }
                if (countOfClicks == 2)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    panelTable1.Hide();
                    panelTable2.Show();
                    panelTable3.Hide();
                    if (countPanel1 == 0)
                    {
                        CreateTextBoxesTable2();
                        countPanel1++;
                    }
                }
                if (countOfClicks == 3)
                {
                    fillButton.Enabled = true;
                    previousButton.Enabled = true;
                    nextButton.Enabled = false;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Show();
                    if (countPanel2 == 0)
                    {
                        CreateTextBoxesTable3();
                        countPanel2++;
                    }
                }
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            countOfClicks--;
            if (lines.Count > 0)
            {
                if (countOfClicks == 0)
                {
                    previousButton.Enabled = false;
                    nextButton.Enabled = true;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Hide();
                    clearButton.Enabled = true;
                }

                if (countOfClicks == 1)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    panelTable1.Show();
                    panelTable2.Hide();
                    panelTable3.Hide();
                    courseCB.Enabled = false;
                    semesterCB.Enabled = false;
                    groupCB.Enabled = false;
                    profileCB.Enabled = false;
                    nameCB.Enabled = false;
                    disciplineNameCB.Enabled = false;
                }
                if (countOfClicks == 2)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = false;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Show();
                }
            }
            else
            {
                if (countOfClicks == 0)
                {
                    previousButton.Enabled = false;
                    nextButton.Enabled = true;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Hide();
                    clearButton.Enabled = true;
                }

                if (countOfClicks == 1)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    panelTable1.Show();
                    panelTable2.Hide();
                    panelTable3.Hide();
                    courseCB.Enabled = false;
                    semesterCB.Enabled = false;
                    groupCB.Enabled = false;
                    profileCB.Enabled = false;
                    nameCB.Enabled = false;
                    disciplineNameCB.Enabled = false;
                }
                if (countOfClicks == 2)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = true;
                    panelTable1.Hide();
                    panelTable2.Show();
                    panelTable3.Hide();
                }
                if (countOfClicks == 3)
                {
                    previousButton.Enabled = true;
                    nextButton.Enabled = false;
                    panelTable1.Hide();
                    panelTable2.Hide();
                    panelTable3.Show();
                }
            }
        }

        private void groupCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            disciplineNameCB.Enabled = true;
            FIOteacherCB.Enabled = true;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordDoc.PrintDocument();
            печатьToolStripMenuItem.Enabled = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form helpForm = new HelpForm();
            helpForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"https://vk.com/oorkk", UseShellExecute = true });
        }

        private void предпросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordDoc.Visible = true;
            wordDoc.PreviewDocument();
            предпросмотрToolStripMenuItem.Enabled = false;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordDoc.SaveDocument();
            сохранитьToolStripMenuItem.Enabled = false;
        }

        private void открытьВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordDoc.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            открытьВWordToolStripMenuItem.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            RemoveTextBoxes();
            countPanel1 = 0;
            countPanel2 = 0;
            textBoxIndex = 1;
            courseCB.Enabled = true;
            clearButton.Enabled = false;
            courseCB.SelectedIndex = -1;
            semesterCB.SelectedIndex = -1;
            groupCB.SelectedIndex = -1;
            profileCB.SelectedIndex = -1;
            nameCB.SelectedIndex = -1;
            kafedraCB.SelectedIndex = -1;
            disciplineNameCB.SelectedIndex = -1;
            FIOteacherCB.SelectedIndex = -1;
            fillButton.Enabled = false;
            nextButton.Enabled = false;
            nameCB.Enabled = false;
            groupCB.Enabled = false;
            semesterCB.Enabled = false;
            profileCB.Enabled = false;
            disciplineNameCB.Enabled = false;
            FIOteacherCB.Enabled = false;
            courseworkСheckBox.Checked = false;
            top2 = 73;
            top3 = 73;
        }

        private void disciplineNameCB_TextChanged(object sender, EventArgs e)
        {
            Bibliography();
            nextButton.Enabled = true;
        }

        private void hoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void disciplineNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
        }

        private void comboBoxes_DropDownClosed(object sender, EventArgs e)
        {
            tempBtn.Focus();
        }

        private void textBox_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            toolTip1.SetToolTip(textBox, textBox.Text);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }

        private void academichoursTB_TextChanged(object sender, EventArgs e)
        {
            if (academichoursTB.Text != "")
            {
                if (Convert.ToInt32(academichoursTB.Text) <= 36)
                    zeTB.Text = "1";
                else if (Convert.ToInt32(academichoursTB.Text) <= 72)
                    zeTB.Text = "2";
                else if (Convert.ToInt32(academichoursTB.Text) <= 108)
                    zeTB.Text = "3";
                else if (Convert.ToInt32(academichoursTB.Text) <= 144)
                    zeTB.Text = "4";
                else if (Convert.ToInt32(academichoursTB.Text) <= 180)
                    zeTB.Text = "5";
                else if (Convert.ToInt32(academichoursTB.Text) <= 216)
                    zeTB.Text = "6";
            }
        }
    }
}