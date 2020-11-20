using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHK_Visual_2._0
{
    class Helper
    {

        public static void CheckBoxChecker(CheckBox cb, TextBox tb, char character)
        {

            if (cb.Checked)
            {
                tb.AppendText(character.ToString());
            }
            else
            {
                int startIndex = tb.Text.IndexOf(character);
                tb.Text = tb.Text.Remove(startIndex, 1);
            }
        }

        public static void Indent(TextBox tb, bool indent)
        {
            if(indent)
            {
                tb.AppendText("                ");
            }
        }

        public static void DeleteIndent(TextBox tb, int charToDelete)
        {
            tb.Focus();

            for (int i = 0; i < charToDelete; i++)
            {
               SendKeys.Send("{DELETE}");
            }
        }

        public static String fileParse()
        {

            List<String> final = new List<String>();
            String fs = String.Empty;

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = Application.StartupPath;
                fd.Filter = "ahk files (*.ahk)|*.ahk";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fs = fd.FileName;
                }
            }

            return fs;
        }

        public static void WriteToBox(CheckBox insertCheck, CheckBox newLineCheck, CheckBox sendCheck, String toPut, TextBox textBox, int position)
        {
            StringBuilder sb = new StringBuilder();
            String newLine = String.Empty;
            String send = String.Empty;
            
            
            if (newLineCheck.Checked)
            {
                newLine = "\r\n";
            }

            if (sendCheck.Checked)
            {
                send = "Send, ";
            }

            sb.Append(send);
            sb.Append(toPut);
            sb.Append(newLine);

            if (insertCheck.Checked)
            {
                textBox.Text = textBox.Text.Insert(position, sb.ToString());
            }
            else
            {
                textBox.AppendText(toPut);
            }
        }


    }
}
