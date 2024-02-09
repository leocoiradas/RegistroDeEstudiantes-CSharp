using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistroDeEstudiantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOther = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TextBoxDegree = new System.Windows.Forms.TextBox();
            this.labelDegree = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1069, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de estudiantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonOther);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.TextBoxDegree);
            this.groupBox2.Controls.Add(this.labelDegree);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.labelLastName);
            this.groupBox2.Controls.Add(this.labelName);
            this.groupBox2.Controls.Add(this.labelID);
            this.groupBox2.Controls.Add(this.TextBoxEmail);
            this.groupBox2.Controls.Add(this.TextBoxLastName);
            this.groupBox2.Controls.Add(this.TextBoxName);
            this.groupBox2.Controls.Add(this.TextBoxID);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(471, 568);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonOther
            // 
            this.buttonOther.BackColor = System.Drawing.Color.Aqua;
            this.buttonOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOther.FlatAppearance.BorderSize = 0;
            this.buttonOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOther.ForeColor = System.Drawing.Color.Black;
            this.buttonOther.Location = new System.Drawing.Point(229, 532);
            this.buttonOther.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(100, 28);
            this.buttonOther.TabIndex = 9;
            this.buttonOther.Text = "Otra cosa";
            this.buttonOther.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Aqua;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(121, 532);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Aqua;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(13, 532);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TextBoxDegree
            // 
            this.TextBoxDegree.Location = new System.Drawing.Point(13, 458);
            this.TextBoxDegree.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDegree.Multiline = true;
            this.TextBoxDegree.Name = "TextBoxDegree";
            this.TextBoxDegree.Size = new System.Drawing.Size(161, 35);
            this.TextBoxDegree.TabIndex = 6;
            this.TextBoxDegree.TextChanged += new System.EventHandler(this.TextBoxDegree_TextChanged_1);
            this.TextBoxDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDegree_KeyPress_1);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDegree.Location = new System.Drawing.Point(8, 429);
            this.labelDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(85, 25);
            this.labelDegree.TabIndex = 10;
            this.labelDegree.Text = "Carrera";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(210, 429);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 25);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(8, 361);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 25);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Apellido";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(210, 361);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Nombre";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(8, 293);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 25);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(215, 458);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Multiline = true;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(161, 35);
            this.TextBoxEmail.TabIndex = 5;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(8, 390);
            this.TextBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLastName.Multiline = true;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(161, 35);
            this.TextBoxLastName.TabIndex = 4;
            this.TextBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            this.TextBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLastName_KeyPress_1);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(215, 390);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxName.Multiline = true;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(161, 35);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged_1);
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress_1);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(8, 322);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxID.Multiline = true;
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(161, 35);
            this.TextBoxID.TabIndex = 2;
            this.TextBoxID.TextChanged += new System.EventHandler(this.TextBoxID_TextChanged);
            this.TextBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxID_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Black;
            this.groupBox5.Controls.Add(this.PictureBoxProfile);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(105, 53);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(255, 230);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxProfile.BackgroundImage")));
            this.PictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxProfile.Location = new System.Drawing.Point(4, 19);
            this.PictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(247, 207);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 0;
            this.PictureBoxProfile.TabStop = false;
            this.PictureBoxProfile.Click += new System.EventHandler(this.PictureBoxProfile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Información del estudiante";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numPage);
            this.groupBox3.Controls.Add(this.labelPages);
            this.groupBox3.Controls.Add(this.buttonLast);
            this.groupBox3.Controls.Add(this.buttonNext);
            this.groupBox3.Controls.Add(this.buttonPrev);
            this.groupBox3.Controls.Add(this.buttonFirst);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(479, 155);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(591, 568);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 397);
            this.dataGridView1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lista de Estudiantes";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.textBoxSearch);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(8, 84);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1061, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(554, 21);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(492, 35);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.Aqua;
            this.buttonFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.ForeColor = System.Drawing.Color.Black;
            this.buttonFirst.Location = new System.Drawing.Point(121, 532);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 28);
            this.buttonFirst.TabIndex = 8;
            this.buttonFirst.Text = "Primero";
            this.buttonFirst.UseVisualStyleBackColor = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Aqua;
            this.buttonPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.ForeColor = System.Drawing.Color.Black;
            this.buttonPrev.Location = new System.Drawing.Point(204, 532);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(83, 28);
            this.buttonPrev.TabIndex = 9;
            this.buttonPrev.Text = "Anterior";
            this.buttonPrev.UseVisualStyleBackColor = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Aqua;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.Black;
            this.buttonNext.Location = new System.Drawing.Point(295, 533);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(76, 28);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Aqua;
            this.buttonLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.ForeColor = System.Drawing.Color.Black;
            this.buttonLast.Location = new System.Drawing.Point(379, 533);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(76, 28);
            this.buttonLast.TabIndex = 11;
            this.buttonLast.Text = "Último";
            this.buttonLast.UseVisualStyleBackColor = false;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPages.Location = new System.Drawing.Point(256, 493);
            this.labelPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(90, 25);
            this.labelPages.TabIndex = 12;
            this.labelPages.Text = "Páginas";
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(7, 539);
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(82, 22);
            this.numPage.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox TextBoxDegree;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonOther;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox PictureBoxProfile;
        private DataGridView dataGridView1;
        private NumericUpDown numPage;
        private Label labelPages;
        private Button buttonLast;
        private Button buttonNext;
        private Button buttonPrev;
        private Button buttonFirst;
    }
}

