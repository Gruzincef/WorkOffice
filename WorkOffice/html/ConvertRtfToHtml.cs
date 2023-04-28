using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WorkOffice.html
{

    internal class ConvertRtfToHtml
    {

        public string rtftext
        {
            get;
            set;
        }
        public string htmltext
        {
            get;
            set;
        }
        public ConvertRtfToHtml()
        {


        }
        private HtmlTeg convercodertf(string rtfcode)
        {
            HtmlTeg htmlteg = new HtmlTeg();


            return htmlteg;
        }
        public string ConverterRtftoHtml(RichTextBox richTextBox)
        {
            return this.ConverterRtftoHtml(richTextBox.Rtf);
        }
        enum flag
        {
            none = -1,
            ch = 1,
            code = 2,
            start = 0,
            u = 3,
            hh = 4,
        }
        readonly Dictionary<char, int> hex = new Dictionary<char, int>()
     {
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'a', 10},
        {'b', 11},
        {'c', 12},
        {'d', 13},
        {'e', 14},
        {'f', 15}
     };
        readonly Dictionary<string, string> codeRtfHtml = new Dictionary<string, string>()
        { 
            {"\\","&nbsp;&nbsp;&nbsp;&nbsp;"}, //Табуляция
            {"CR","<br/>"},//Символ CR
            { "LF","<br/>"},//Символ LF
            { "\\~","&nbsp;"},//Задает жесткий(неразрываемый) пробел между двумя словами, т.е.в этой позиции предложение не может быть разделено при переносе на следующую строку.
            { "\\-","<br/>"},//Символ обозначает мягкий перенос(nonrequired hyphen).
            { "\\_","<br/>"}, //Символ обозначает неразрываемый перенос(nonbreaking hyphen), на месте которого слово не может быть разделено.
            { "\\line","<br/>"}, //Эта последовательность вызывает переход на новую строку в тексте.
            { "\\раr","<br/>"}, //С помощью данной последовательности в тексте отмечается конец абзаца. Последовательность \раr может заменяться последовательностью \10 или \13. При этом \10 соответствует ASCII-символу с кодом 10 (carriage return). Непосредственно ввести ASCII-код 10 (CR) нельзя, т.к.он игнорируется программой чтения.
            { "\\sect","<br/>"}, //Эта последовательность обозначает конец текстового фрагмента или текстового абзаца.
            { "\\tab","<br/>"}, //Данная последовательность заменяет табулятор.Можно также непосредственно задавать ASCII-код 09Н.
            { "\\page","<br/>"}
        };
        public string ConverterRtftoHtml(string richTextBox)
        {
            string codertf = "";
            string text = "";
            flag fl=flag.none;
            int utfCode = 0;
            int[] utfArray = new int[2];
            int len=0;
            foreach (char ch in richTextBox)
            {
                
                if ((ch == '\\')&&(codertf.Length >= 2))
                {
                    len = 0;

                    if ((codertf[0] == 'u') && (codertf.Length >= 5) && (int.TryParse(codertf.Substring(1, 4), out utfCode)))
                    {
                        len = 6;
                        text += Convert.ToChar(utfCode);
                        text += codertf.Substring(len, codertf.Length - len);
                    }
                    else
                    if (codertf[0] == '\'')
                    {
                        len = 3;
                        string s = codertf[1].ToString() + codertf[2].ToString();
                        utfCode = Convert.ToInt32(s, 16);
                        Encoding encoding = Encoding.GetEncoding("Windows-1251");
                        text += encoding.GetString(new byte[] { (byte)utfCode });
                        text += codertf.Substring(len, codertf.Length - len);
                    }
                    else
                    if (codertf[0] == 'i')
                    {

                        if ((codertf.Length > 1) && (codertf[1] == '0'))
                        {
                            len = 2;
                            text += "</i>" + codertf.Substring(len, codertf.Length - len);
                        } 
                        else
                        {
                            len = 1;
                            text += "<i>" + codertf.Substring(len, codertf.Length - len);
                        }
                    }
                    else
                    if (codertf[0] == 'b')
                    {

                        if ((codertf.Length > 1) && (codertf[1] == '0'))
                        {
                            len = 2;
                            text += "</b>" + codertf.Substring(len, codertf.Length - len);
                        }
                        else
                        {
                            len = 1;
                            text += "<b>" + codertf.Substring(len, codertf.Length - len);
                        }
                    }
                    else
                    if ((codertf[0] == 'f')&&(codertf[1] == 's'))
                     {
                        text += "<div style='font-size:" + codertf.Substring(2, codertf.Length - 2).Trim() + "px;'>";
                     }
                    else
                    {
                        text += codertf;
                    }


                        codertf = "";
                    fl = flag.start;

                    
                    
                }                
                else
                {
                    codertf += ch.ToString();
                }
                
               
                /*            //Собираем код
                            if (fl == flag.start)
                            {
                                if (ch == 'u')
                                {
                                    fl = flag.u;
                                }
                                if (ch == '\'')
                                {
                                    fl = flag.hh;
                                }
                            } 
                */


            }
            return text;
        }

    }
}
