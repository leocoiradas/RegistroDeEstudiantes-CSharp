using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEstudiantes
{
    public partial class Form1 : Form
    {
        private EstudiantesLogica estudiantes;
        public Form1()
        {
            InitializeComponent();
            //La sig lista se crea para obtener la información de los campos de texto
            var listTextBox = new List <TextBox> ();
            listTextBox.Add(TextBoxID);
            listTextBox.Add(TextBoxName);
            listTextBox.Add(TextBoxLastName);
            listTextBox.Add(TextBoxDegree);
            listTextBox.Add(TextBoxEmail);
            var listLabel = new List <Label> ();
            listLabel.Add(labelID);
            listLabel.Add(labelName);
            listLabel.Add(labelLastName);
            listLabel.Add(labelDegree);
            listLabel.Add(labelEmail);
            Object[] images = { PictureBoxProfile };
            estudiantes = new EstudiantesLogica(listTextBox, listLabel, images);
        }


        private void PictureBoxProfile_Click(object sender, EventArgs e)
        {
            estudiantes.uploadImage.LoadImage(PictureBoxProfile);
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxID.Text.Equals(""))
            {
                labelID.ForeColor = Color.Red;
            }
            else
            {
                labelID.ForeColor = Color.Green;
                labelID.Text = "ID";
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.numberKeyPress(e);
        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLastName.Text.Equals(""))
            {
                labelLastName.ForeColor = Color.Red;
            }
            else
            {
                labelLastName.ForeColor = Color.Green;
                labelLastName.Text = "Apellido";
            }
        }
        private void TextBoxLastName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void TextBoxName_TextChanged_1(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Equals(""))
            {
                labelName.ForeColor = Color.Red;
            }
            else
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = "Nombre";
            }
        }

        private void TextBoxName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);

        }

        private void TextBoxDegree_TextChanged_1(object sender, EventArgs e)
        {
            if (TextBoxDegree.Text.Equals(""))
            {
                labelDegree.ForeColor = Color.Red;
            }
            else
            {
                labelDegree.ForeColor = Color.Green;
                labelDegree.Text = "Carrera";
            }
        }

        private void TextBoxDegree_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {

            if (TextBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.Red;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            estudiantes.Registrar();
        }

        
    }
}

    