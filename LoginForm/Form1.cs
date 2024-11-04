using LoginForm.models;
using LoginForm.models.resourses;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtUser.Text.Trim() == "")
            {
                MetroMessageBox.Show(this, "No puede estar vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            User user = new User();

            {

                user.Password = txtPassword.Text;

            }


            UserService service = new UserService();

            if (service.ValidateUser(user.Username, user.Password))

            {

                MetroMessageBox.Show(this, "Bienvenido", "TE AMO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MetroMessageBox.Show(this, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
         
           




        }

    }
}
