using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionare_Parc_Auto.Classes
{
    class Validare
    {
        public void Validare_Numar(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Trebuie sa introduci doar numere.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        public void Validare_Caracter(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Trebuie sa introduci doar caractere.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

    }
}
