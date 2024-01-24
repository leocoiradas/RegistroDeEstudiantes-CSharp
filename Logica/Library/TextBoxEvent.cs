using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condicion que nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //Condicion que permite no hacer salto de linea si se presiona la tecla enter, negándole el ingreso de caracter mediante e.handled = true
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que nos permite usar la tecla backspace para borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condicion que nos permite usar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Condicion que nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //Condicion que permite no hacer salto de linea si se presiona la tecla enter, negándole el ingreso de caracter mediante e.handled = true
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que nos permite usar la tecla backspace para borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condicion que nos permite usar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = true; }

        }
        public bool CheckEmailIsValid(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
