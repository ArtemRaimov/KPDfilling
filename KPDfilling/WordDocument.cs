using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace KPDfilling
{
    class WordDocument
    {
        private Object _missingObj = System.Reflection.Missing.Value;
        private Object _trueObj = true;
        private Object _falseObj = false;

        private Word._Application _application;
        private Word._Document _document;

        private Object _templatePathObj;

        private Word.Range _currentRange = null;

        private Word.Table _table = null;

        private WordSelection _selection;

        public WordSelection Selection
        {
            get { return _selection; }
            set { MessageBox.Show("Ошибка! Свойство InsertedParagraph только для чтения", "Ошибка"); return; }
        }

        public static char NewLineChar { get { return (char)11; } }

        public bool Closed
        {
            get
            {
                if (_application == null || _document == null) { return true; }
                else { return false; }
            }
        }

        public bool Visible
        {
            get
            {
                if (Closed) { throw new Exception("Ошибка при попытке изменить видимость Microsoft Word. Программа или документ уже закрыты."); }
                return _application.Visible;

            }
            set
            {
                if (Closed) { throw new Exception("Ошибка при попытке изменить видимость Microsoft Word. Программа или документ уже закрыты."); }
                try 
                {
                    _application.Visible = value;
                }
                catch
                {
                    MessageBox.Show("Ошибка при попытке изменить видимость Microsoft Word. Программа или документ уже закрыты.", "Ошибка");
                }
            }
        }

        public int PagesCount
        {
            get
            {
                int pagesCount = 0;
                Word.WdStatistic pagesStatType = Word.WdStatistic.wdStatisticPages;
                pagesCount = _document.ComputeStatistics(pagesStatType, ref _missingObj);
                return pagesCount;
            }
        }

        public WordDocument(bool startVisible)
        {
            _application = new Word.Application();

            try
            {
                _document = _application.Documents.Add(ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj);
            }
            catch (Exception error)
            {
                this.Close();
                throw error;
            }
            Visible = startVisible;
            SetSelectionToBegin();
        }

        public WordDocument() : this(false) { }

        public WordDocument(string templatePath, bool startVisible)
        {
            _application = new Word.Application();

            _templatePathObj = templatePath;

            try
            {
                _document = _application.Documents.Add(ref _templatePathObj, ref _missingObj, ref _missingObj, ref _missingObj);
            }
            catch (Exception error)
            {
                this.Close();
                throw error;
            }
            Visible = startVisible;

            SetSelectionToBegin();
        }

        public WordDocument(string templatePath)
            : this(templatePath, false) { }

        public static void FillShowTemplate(string pathToTemplate, Action<WordDocument> fillWordDoc)
        {
            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);
                fillWordDoc(wordDoc);
            }
            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }
                throw error;
            }
            wordDoc.Visible = true;
        }

        public void SetSelectionToText(string stringToFind)
        {
            Word.Range foundRange = findRangeByString(stringToFind);
            if (foundRange == null)
            {
                MessageBox.Show("Ошибка при поиске текста в MS Word. Не удалось найти и выбрать заданный текст: " + stringToFind, "Ошибка");
            }
            _currentRange = foundRange;
            _selection = new WordSelection(foundRange, false);
        }

        public void SetSelectionToText(string containerStr, string stringToFind)
        {

            Word.Range containerRange = null;
            Word.Range foundRange = null;

            containerRange = findRangeByString(containerStr);
            if (containerRange != null)
            {
                foundRange = findRangeByString(containerRange, stringToFind);
            }

            if (foundRange != null)
            {
                _currentRange = foundRange;
                _selection = new WordSelection(foundRange, false);
            }
            else
            {
                MessageBox.Show("Ошибка при поиске текста в MS Word. Не удалось найти заданную область для поиска текста: " + containerStr, "Ошибка");
            }
        }

        public void SetSelectionToBookmark(string bookmarkName, bool isParagraph)
        {
            if (Closed) { MessageBox.Show("Ошибка при обращении к документу Word. Документ уже закрыт.", "Ошибка"); return; }

            Object bookmarkNameObj = bookmarkName;
            Word.Range bookmarkRange = null;
            try
            {
                bookmarkRange = _document.Bookmarks.get_Item(ref bookmarkNameObj).Range;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при поиске закладки " + bookmarkName + " в документе Word. Сообщение от Word: " + error.Message, "Ошибка");
            }
            _currentRange = bookmarkRange;
            _selection = new WordSelection(_currentRange, isParagraph);
        }

        public void SetSelectionToBookmark(string bookmarkName)
        {
            SetSelectionToBookmark(bookmarkName, false);
        }

        public void SetSelectionToBegin()
        {
            object start = 0;
            object end = 0;
            this._currentRange = this._document.Range(ref start, ref end);
            _selection = new WordSelection(_currentRange);
        }

        public void SetSelectionToCell(int rowIndex, int columnIndex)
        {
            if (_table == null) { MessageBox.Show("Ошибка при выборе ячейки в таблице Word, не выбрана текущая таблица.", "Ошибка"); return; }

            _currentRange = _table.Cell(rowIndex, columnIndex).Range;
            _selection = new WordSelection(_currentRange, false);
        }

        public void InsertParagraphAfter()
        {
            if (Closed) { MessageBox.Show("Ошибка при обращении к документу Word. Документ уже закрыт.", "Ошибка"); return; }
            Object collapseDirection = Word.WdCollapseDirection.wdCollapseEnd;
            try
            {
                _currentRange.Collapse(ref collapseDirection);
                _currentRange.InsertParagraphAfter();
                _selection = new WordSelection(_currentRange);
            }
            catch (Exception wordError)
            {
                throw wordError;
            }
        }

        public void InsertParagraphAfter(string textToInsert)
        {
            this.InsertParagraphAfter();
            this._selection.Text = textToInsert;
        }

        public void InsertTable(int numRows, int numColumns)
        {
            InsertTable(numRows, numColumns, BorderType.Single);
        }

        public void InsertTable(int numRows, int numColumns, BorderType border)
        {
            _table = _document.Tables.Add(_currentRange, numRows, numColumns, ref _missingObj, ref _missingObj);
            switch (border)
            {
                case BorderType.None:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    break;
                case BorderType.Single:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    break;
                case BorderType.Double:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    break;
                default:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    break;
            }
            _currentRange = _table.Range;
            _selection = new WordSelection(_currentRange, false);
        }

        public void SetColumnWidth(int columnIndex, int widthPixels)
        {
            if (_table == null) { MessageBox.Show("Ошибка при установке ширины колонки в таблице Word - текущая таблица не выбрана (SetColumnWidth(int columnIndex, int widthPixels))", "Ошибка"); }
            _table.Columns[columnIndex].SetWidth(widthPixels, Word.WdRulerStyle.wdAdjustNone);
        }

        public void InsertPageAtEnd()
        {
            object missing = Missing.Value;
            object what = Word.WdGoToItem.wdGoToLine;
            object which = Word.WdGoToDirection.wdGoToLast;
            Word.Range endRange = _document.GoTo(ref what, ref which, ref missing, ref missing);
            _currentRange = endRange;
            _selection = new WordSelection(endRange);

            int oldPagesCount = PagesCount;
            while (oldPagesCount == PagesCount)
            {
                InsertParagraphAfter();
            }
            InsertParagraphAfter();
        }

        public void InsertFile(string pathToFile)
        {
            if (_currentRange == null) { MessageBox.Show("Ничего не выбрано", "Ошибка"); return; }
            _currentRange.InsertFile(pathToFile);
        }

        public void Save(string pathToSave)
        {
            Object pathToSaveObj = pathToSave;
            _document.SaveAs(ref pathToSaveObj, Word.WdSaveFormat.wdFormatDocument, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj, ref _missingObj);
        }

        public void Close()
        {

            if (_document != null)
            {
                _document.Close(ref _falseObj, ref _missingObj, ref _missingObj);
            }
            _application.Quit(ref _missingObj, ref _missingObj, ref _missingObj);
            _document = null;
            _application = null;
        }

        public void ReplaceAllStrings(string strToFind, string replaceStr)
        {
            if (Closed) { MessageBox.Show("Ошибка при обращении к документу Word. Документ уже закрыт.", "Ошибка"); return; }

            object strToFindObj = strToFind;
            object replaceStrObj = replaceStr;
            Word.Range wordRange;
            object replaceTypeObj;

            replaceTypeObj = Word.WdReplace.wdReplaceAll;

            try
            {
                for (int i = 1; i <= _document.Sections.Count; i++)
                {
                    wordRange = _document.Sections[i].Range;
                    Word.Find wordFindObj = wordRange.Find;
                    object[] wordFindParameters = new object[15] { strToFindObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, replaceStrObj, replaceTypeObj, _missingObj, _missingObj, _missingObj, _missingObj };
                    wordFindObj.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, wordFindObj, wordFindParameters);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при выполнении замене всех строк  в документе Word.  " + error.Message + " (ReplaceAllStrings)", "Ошибка");
            }
        }

        public void SelectTable(int tableNumber)
        {
            try
            {
                _table = _document.Tables[tableNumber];
            }
            catch (Exception error)
            {
                MessageBox.Show("Таблица с номером " + tableNumber + " не найдена в документе Word. Подробности: " + error.Message, "Ошибка");
            }
            _currentRange = _table.Range;
            _selection = new WordSelection(_table.Range, true, false);
        }

        public void AddRowToTable()
        {
            _table.Rows.Add(ref _missingObj);
        }

        private Word.Range findRangeByString(string stringToFind)
        {
            if (Closed) { throw new Exception("Ошибка при обращении к документу Word. Документ уже закрыт."); }
            object stringToFindObj = stringToFind;
            Word.Range wordRange;
            bool rangeFound;

            for (int i = 1; i <= _document.Sections.Count; i++)
            {
                wordRange = _document.Sections[i].Range;
                Word.Find wordFindObj = wordRange.Find;
                object[] wordFindParameters = new object[15] { stringToFindObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj };
                rangeFound = (bool)wordFindObj.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, wordFindObj, wordFindParameters);
                if (rangeFound) { return wordRange; }
            }
            return null;
        }

        private Word.Range findRangeByString(Word.Range containerRange, string stringToFind)
        {
            if (Closed) { throw new Exception("Ошибка при обращении к документу Word. Документ уже закрыт."); }
            object stringToFindObj = stringToFind;
            bool rangeFound;
            Word.Find wordFindObj = containerRange.Find;
            object[] wordFindParameters = new object[15] { stringToFindObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj };
            rangeFound = (bool)wordFindObj.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, wordFindObj, wordFindParameters);
            if (rangeFound) { return containerRange; }
            else { return null; }
        }

        public void PrintDocument()
        {
            if (Closed) { MessageBox.Show("Ошибка при обращении к документу Word. Документ уже закрыт.", "Ошибка"); return; }

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.AllowSomePages = true;
                printDialog.AllowSelection = true;
                printDialog.AllowPrintToFile = true;
                printDialog.AllowCurrentPage = true;
                try
                {
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        _document.PrintOut(Background: false, Append: false, Range: Word.WdPrintOutRange.wdPrintAllDocument, OutputFileName: "", PrintToFile: false, Collate: true, ManualDuplexPrint: false, PrintZoomColumn: 0, PrintZoomRow: 0, PrintZoomPaperWidth: 0, PrintZoomPaperHeight: 0);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка при попытке печати документа Word. " + error.Message, "Ошибка");
                }
            }
        }

        public void PreviewDocument()
        {
            if (Closed) { MessageBox.Show("Ошибка при обращении к документу Word. Документ уже закрыт.", "Ошибка"); return; }

            try
            {
                _document.PrintPreview();
                var dialogResult = _application.Dialogs[WdWordDialog.wdDialogFilePrint].Show();
                if (dialogResult == 1)
                    _document.PrintOut();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при открытии предварительного просмотра Word. " + error.Message, "Ошибка");
            }
        }

        public void SaveDocument()
        {
            try
            {
                _application.Dialogs[WdWordDialog.wdDialogFileSaveAs].Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при попытке сохранить документ Word. " + error.Message, "Ошибка");
            }
        }

        public void MergeCells(int startRowIndex, int startColumnIndex, int endRowIndex, int endColumnIndex)
        {
            if (_table == null) { MessageBox.Show("Ошибка при объединении ячеек в таблице Word - текущая таблица не выбрана.", "Ошибка"); return; }

            _table.Cell(startRowIndex, startColumnIndex).Merge(_table.Cell(endRowIndex, endColumnIndex));
        }
    } 
}