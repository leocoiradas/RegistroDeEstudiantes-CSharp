using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Windows.Forms.Label;

namespace Logica
{
    public class EstudiantesLogica : Libraries
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        //Creamos el atributo image, que contendrá la imagen que obtenemos del formulario
        private PictureBox image;
        private Libraries Libraries;
        private Bitmap BitmapImage;
        private DataGridView dataGridView;
        private NumericUpDown inputPage;
        private Paginador<Estudiante> _paginador;
        private string _action = "insert";
        public EstudiantesLogica(List<TextBox> listTextBox, List<Label> listLabel, object[] images)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //Ahora utilizamos el atributo image para obtener el valor o la imagen que ingresa por el formulario
            //inicializamos el atributo image, poniendo entre parentesis la clase PictureBox, esto porque vamos a convertir un objeto (o dato) a un 
            //Objeto de la clase PictureBox
            image = (PictureBox)images[0];
            Libraries = new Libraries();
            BitmapImage = (Bitmap)images[1];
            dataGridView = (DataGridView)images[2];
            inputPage = (NumericUpDown)images[3];
            ResetFields();
        }
        public void Registrar()
        {
            for (int i = 0; i < listTextBox.Count; i++)
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

                CheckEmailIsRegistered();

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
                switch (_action)
                {   
                    case "insert":
                        
                        db.Insert(new Estudiante()
                        {
                            nid = listTextBox[0].Text,
                            nombre = listTextBox[1].Text,
                            apellido = listTextBox[2].Text,
                            carrera = listTextBox[3].Text,
                            email = listTextBox[4].Text,
                            imagen = imageArray,
                        });
                        break;
                    case "update":

                        db.Update(Estudiantes.Where(u => u.id.Equals(_idStudent))
                            .Set(p => p.nid, listTextBox[0].Text)
                            .Set(p => p.nombre, listTextBox[1].Text)
                            .Set(p => p.apellido, listTextBox[2].Text)
                            .Set(p => p.carrera, listTextBox[3].Text)
                            .Set(p => p.email, listTextBox[4].Text)
                            .Set(p => p.imagen, imageArray));
                        break;
                }
                
                CommitTransaction();
                ResetFields();
            }
            catch (Exception)
            {
                RollbackTransaction();
            }



        }
        public void CheckEmailIsRegistered()
        {
            var user = Estudiantes.Where(u => u.email.Equals(listTextBox[4].Text)).ToList();
            if (user.Count.Equals(0))
            {
                ConectarABaseDeDatos();
            }
            else
            {
                if (user[0].id.Equals(_idStudent))
                {
                    ConectarABaseDeDatos();
                }
                else
                {
                    listLabel[3].Text = "Email ya esta registrado";
                    listLabel[3].ForeColor = Color.Red;
                    listTextBox[3].Focus();
                }
                
            }
        }
        private List<Estudiante> studentList;
        public void Paginador(string metodo)
        {
            switch (metodo)
            {
                case "First":
                    page_num = _paginador.First();
                    break;
                case "Previous":
                    page_num = _paginador.Previous();
                    break;
                case "Next": 
                    page_num = _paginador.Next();
                    break;
                case "Last": 
                    page_num = _paginador.Last();
                    break;
            }
            SearchStudent("");
        }
        public void ResetFields()
        {
            _action = "insert";
            page_num = 1;
            _idStudent = 0;
            image.Image = BitmapImage;
            listLabel[0].Text = "Nid";
            listLabel[1].Text = "Nombre";
            listLabel[2].Text = "Apellido";
            listLabel[3].Text = "Carrera";
            listLabel[4].Text = "Email";
            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].ForeColor = Color.LightSlateGray;
            listLabel[4].ForeColor = Color.LightSlateGray;
            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listTextBox[4].Text = "";
            studentList = Estudiantes.ToList();
            if (studentList.Count > 0)
            {
                _paginador = new Paginador<Estudiante>(studentList, listLabel[5], reg_for_page);
            }
            SearchStudent("");
        }
        private int reg_for_page = 2, page_num = 1;
        public void SearchStudent(string searchParams) {
            int inicio = (page_num - 1 ) * reg_for_page;
            List<Estudiante> query = new List<Estudiante>();
            if (searchParams.Equals(""))
            {
              query = Estudiantes.ToList();
            }
            else
            {
                query = Estudiantes.Where(c =>
                    c.nid.StartsWith(searchParams) ||
                    c.nombre.StartsWith(searchParams) ||
                    c.apellido.StartsWith(searchParams)).ToList();
            }
            if (query.Count > 0)
            {
                dataGridView.DataSource = query.Select(c => new
                {
                    c.id,
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.carrera,
                    c.email,
                    c.imagen
                }).Skip(inicio).Take(reg_for_page).ToList();
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[6].Visible = false;
            }
            else
            {
                dataGridView.DataSource = query.Select(c => new
                {
                    c.id,
                    c.nid,
                    c.nombre,
                    c.apellido,
                    c.carrera,
                    c.email
                }).ToList();
            }
        }

        private int _idStudent = 0;
        public void GetEstudiante()
        {
            _action = "update";
            _idStudent = Convert.ToInt16(dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(dataGridView.CurrentRow.Cells[4].Value);
            listTextBox[4].Text = Convert.ToString(dataGridView.CurrentRow.Cells[5].Value);
            listTextBox[5].Text = Convert.ToString(dataGridView.CurrentRow.Cells[6].Value);
            try
            {
                byte[] arrayImage = (byte[])dataGridView.CurrentRow.Cells[6].Value;
                image.Image = uploadImage.byteArrayToImage(arrayImage);
            }
            catch (Exception)
            {
                image.Image = BitmapImage;
            }
        }
        public void DeleteStudent()
        {
            if (_idStudent.Equals(0))
            {
                MessageBox.Show("Seleccione un estudiante");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de que quieres eliminar el siguiente estudiante?", "Eliminar estudiante",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Estudiantes.Where(c => c.nid.Equals(_idStudent)).Delete();
                    ResetFields();
                }
            }
        }
    }
        
            
            
        

}
    


