using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLaundryWithDesign
{
    internal class Support
    {
        public static void msi (string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void msw(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mse(string text)
        {
            MessageBox.Show(text, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void enableField(Control control)
        {
            foreach (var enable in control.Controls)
            {
                if (enable is BunifuTextBox)
                {
                    ((BunifuTextBox)enable).Enabled = true;
                }
            }
        }

        public static void clearField(Control control)
        {
            foreach (var clear in control.Controls)
            {
                if (clear is BunifuTextBox)
                {
                    ((BunifuTextBox)clear).Text = string.Empty;
                }

                if (clear is ComboBox)
                {
                    ((ComboBox)clear).Text = "";
                }

                if (clear is BunifuDatePicker)
                {
                    ((BunifuDatePicker)clear).Value = DateTime.Now;
                }

                if (clear is NumericUpDown)
                {
                    ((NumericUpDown)clear).Value = 0;
                }
            }
        }
    }
}
