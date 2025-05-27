using MetroFramework.Controls;
using System.Text;
using System.Windows.Forms;

namespace AutoParc_WindowsForms_UI
{
    public static class ValidareDate
    {
        public class ControaleVehicul
        {
            public MetroTextBox TxtID { get; set; }
            public MetroTextBox TxtMarca { get; set; }
            public MetroTextBox TxtModel { get; set; }
            public MetroTextBox TxtAnul { get; set; }
            public MetroTextBox TxtNrDeIm { get; set; }
            public MetroTextBox TxtStare { get; set; }
            public MetroRadioButton RdbRed { get; set; }
            public MetroRadioButton RdbVerde { get; set; }
            public MetroRadioButton RdbAlbastru { get; set; }
            public MetroRadioButton RdbAlba { get; set; }
        }

        public static bool Valideaza(ControaleVehicul controale)
        {
            bool valid = true;
            StringBuilder mesajEroare = new StringBuilder();

            if (string.IsNullOrWhiteSpace(controale.TxtID.Text) || !int.TryParse(controale.TxtID.Text, out _))
            {
                mesajEroare.AppendLine("ID trebuie să fie un număr întreg!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(controale.TxtMarca.Text))
            {
                mesajEroare.AppendLine("Marca nu poate fi goală!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(controale.TxtModel.Text))
            {
                mesajEroare.AppendLine("Modelul nu poate fi gol!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(controale.TxtAnul.Text) || !int.TryParse(controale.TxtAnul.Text, out _))
            {
                mesajEroare.AppendLine("Anul trebuie să fie un număr întreg!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(controale.TxtNrDeIm.Text))
            {
                mesajEroare.AppendLine("Numărul de înmatriculare nu poate fi gol!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(controale.TxtStare.Text))
            {
                mesajEroare.AppendLine("Starea tehnică nu poate fi goală!");
                valid = false;
            }

            if (!(controale.RdbRed.Checked || controale.RdbVerde.Checked || controale.RdbAlbastru.Checked || controale.RdbAlba.Checked))
            {
                mesajEroare.AppendLine("Selectați o culoare pentru vehicul!");
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show(mesajEroare.ToString(), "Eroare validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }
    }
}
