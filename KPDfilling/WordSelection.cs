using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace KPDfilling
{
    public enum TextAligment { Left, Center, Right, Justify }

    public enum BorderType { None, Single, Double }

    class WordSelection
    {
        private Word.Range _range;
        private bool _insertParagrAfterText = true;

        private Word.WdParagraphAlignment _savedAligment;

        public WordSelection(Word.Range inputRange) : this(inputRange, true, true)
        {

        }

        public WordSelection(Word.Range inputRange, bool insertParagrAfterText)
            : this(inputRange, insertParagrAfterText, true)
        {

        }

        public WordSelection(Word.Range inputRange, bool insertParagrAfterText, bool setDefaultStyle)
        {
            _range = inputRange;

            _insertParagrAfterText = insertParagrAfterText;

            if (setDefaultStyle)
            {
                _savedAligment = _range.ParagraphFormat.Alignment;
                _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                _savedAligment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                _range.Italic = 0;
                _range.Bold = 0;
            }
            else
            {
                _savedAligment = _range.ParagraphFormat.Alignment;
            }
        }

        public bool Bold
        {
            get
            {
                if (_range.Bold == 1) { return true; }
                else { return false; }
            }
            set
            {
                if (value == true) { _range.Bold = 1; }
                else { _range.Bold = 0; }
            }
        }

        public bool Italic
        {
            get
            {
                if (_range.Italic == 1) { return true; }
                else { return false; }
            }
            set
            {
                if (value == true) { _range.Italic = 1; }
                else { _range.Italic = 0; }
            }
        }

        public TextAligment Aligment
        {
            get
            {
                if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphLeft)
                { return TextAligment.Left; }
                else if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphCenter)
                { return TextAligment.Center; }
                else if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphRight)
                { return TextAligment.Right; }
                else if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphJustify)
                { return TextAligment.Justify; }
                else { throw new Exception("Ошибка при определении типа вырвнивания текста"); }
            }
            set
            {
                if (value == TextAligment.Left)
                {
                    _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    _savedAligment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
                else if (value == TextAligment.Center)
                {
                    _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    _savedAligment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                else if (value == TextAligment.Right)
                {
                    _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    _savedAligment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                }
                else if (value == TextAligment.Justify)
                {
                    _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    _savedAligment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                }
                else { throw new Exception("Неизвестный тип выравнивания текста"); }
            }
        }

        public string Text
        {
            get { return _range.Text; }
            set
            {
                _range.Text = value;
                if (_insertParagrAfterText)
                {
                    _range.InsertParagraphAfter();
                }
                _range.ParagraphFormat.Alignment = this._savedAligment;
            }
        }

        public int FontSize
        {
            get { return Convert.ToInt32(this._range.Font.Size); }
            set
            {
                if (value < 1) { throw new Exception("Ошибка при установке размера шрифта  Word. Размер шрифта не может быть меньше 1."); }
                float fontSize = (float)Convert.ToDouble(value);
                this._range.Font.Size = fontSize;
            }
        }

        public BorderType Border
        {
            set
            {
                switch (value)
                {
                    case BorderType.None:
                        _range.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                        break;
                    case BorderType.Single:
                        _range.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        break;
                    case BorderType.Double:
                        _range.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                        break;
                    default:
                        _range.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                        break;
                }
            }
            get
            {
                switch (_range.Borders.OutsideLineStyle)
                {
                    case Word.WdLineStyle.wdLineStyleNone:
                        return BorderType.None;
                    case Word.WdLineStyle.wdLineStyleSingle:
                        return BorderType.Single;
                    case Word.WdLineStyle.wdLineStyleDouble:
                        return BorderType.Double;
                    default:
                        return BorderType.None;
                }
            }
        }
    }
}