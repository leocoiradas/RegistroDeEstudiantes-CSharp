using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Windows.Forms.Label;

namespace Logica
{
    public class EstudiantesLogica: Libraries
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        //Creamos el atributo image, que contendrá la imagen que obtenemos del formulario
        private PictureBox image;
        private Libraries Libraries;
        public EstudiantesLogica(List<TextBox> listTextBox, List<Label> listLabel, object[] images)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //Ahora utilizamos el atributo image para obtener el valor o la imagen que ingresa por el formulario
            //inicializamos el atributo image, poniendo entre parentesis la clase PictureBox, esto porque vamos a convertir un objeto (o dato) a un 
            //Objeto de la clase PictureBox
            image = (PictureBox)images[0];
            Libraries = new Libraries();
        }
        public void Registrar()
        {
            for (int i=0; i< listTextBox.Count; i++)
            {
                {
                    if (listTextBox[i].Text.Equals(""))
                    {
                        string label = listLabel[i].Text;
                        listLabel[i].Text = $"El campo {label} es requerido.";
                        listLabel[i].ForeColor = Color.Red;
                        listTextBox[i].Focus();
                        break;
                        
                    }
                    if (listLabel[i].Text.Equals("Email"))
                    {
                        RegistrarEmail();
                    }
                }

            }
            
        }
        public void RegistrarEmail()
        {
            if (Libraries.textBoxEvent.CheckEmailIsValid(listTextBox[4].Text))
            {
                
                ConectarABaseDeDatos();
                
            }
            else
            {
                string label = listLabel[4].Text;
                listLabel[4].Text = $"El campo {label} no es valido.";
                listLabel[4].ForeColor = Color.Red;
                listTextBox[4].Focus();
            }
        }
        public void ConectarABaseDeDatos()
        {
            BeginTransactionAsync();
            try 
            {
                var imageArray = Libraries.uploadImage.ImageToByte(image.Image);
                var db = new Conexion();
                db.Insert(new Estudiante()
                {
                    nid = listTextBox[0].Text,
                    nombre = listTextBox[1].Text,
                    apellido = listTextBox[2].Text,
                    carrera = listTextBox[3].Text,
                    email = listTextBox[4].Text,
                    imagen = imageArray,
                });
                CommitTransaction();
            }
            catch (Exception)
            {
                RollbackTransaction();
            }
            
        
        
        }
    }
}
