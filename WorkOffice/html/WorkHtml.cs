using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace WorkOffice.html
{
    internal class WorkHtml
    {
        static string[] m_colorTable = new string[]
            {
               // rrGGbb
                "#000000", // default, starts at index 0
                "#000000", // real color table starts at index 1
                "#0000FF",
                "#00ffFF",
                "#00FF00",
                "#FF00FF",
                "#FF0000",
                "#FFFF00",
                "#FFffFF",
                "#000080",
                "#008080",
                "#008000",
                "#800080",
                "#800000",
                "#808000",
                "#808080",
                "#c0c0c0"
            };
        static string Escape(string st)
        {
            st = st.Replace("&", "&amp;");
            st = st.Replace("<", "&lt;");
            st = st.Replace(">", "&gt;");
            return st;
        }
        public string deleteAllHyperlink(string text)
        {
            return Regex.Replace(text, @"<a.?>|</a>", "");
        }

        public string deleteAllTeg(string text)
        {
            return Regex.Replace(text, "<.*?>", string.Empty);
        }

        public string convertToHtmlCode(string text)
        {
            return HttpUtility.HtmlEncode(text);
        }

        public string convertRichTextInHtmlText(string rtf)
        {
            return "";
        }
        public string convertRichTextInHtmlText(RichTextBox richTextBox)
        {
            ConvertRtfToHtml convertRtfToHtml = new ConvertRtfToHtml();

            
            return convertRtfToHtml.ConverterRtftoHtml(richTextBox.Rtf);
        }

         // функция для конвертации RTF-кода в HTML-код
      private string ConvertRtfToHtml(string rtf)
      {
           RichTextBox rtb = new RichTextBox();
            rtb.Rtf = rtf;
           return rtb.SelectedText;
       }
   }




}
