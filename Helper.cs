using System;
using System.Collections.Generic;
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
                tb.AppendText("    ");
            }
        }

    }
}
