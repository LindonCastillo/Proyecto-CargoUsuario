using RegistroCompleto.BLL;
using RegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroCompleto.UI.Registros
{
    public partial class FormResgistroUsuarios : Form
    {
        public FormResgistroUsuarios()
        {
            InitializeComponent();
        }

   
        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Usuarios Usuario;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            Usuario = LlenaClase();
            Limpiar();

            if(UsuarioId_numericUpDown.Value == 0)
            {
                paso = UsuariosBLL.Guardar(Usuario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(Usuario);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            //MyErrorProvider.Clear();
            int id;
            int.TryParse(UsuarioId_numericUpDown.Text, out id);

            Limpiar();
            
            if (UsuariosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede eliminar este Usuario", "No Hubo Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MyerrorProvider.SetError(UsuarioId_numericUpDown, "No se puede eliminar este Usuario");
            }
              

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios Usuario = new Usuarios();
            int.TryParse(UsuarioId_numericUpDown.Text, out id);

            Limpiar();

            Usuario = UsuariosBLL.Buscar(id);

            if(Usuario != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(Usuario);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }

        }
        private void Limpiar()
        {
            UsuarioId_numericUpDown.Value = 0;
            Nombre_textBox.Text = string.Empty;
            Email_textBox.Text = string.Empty;
            NivelUsuario_numericUpDown.Value = 0; 
            Usuario_textBox.Text = string.Empty;
            Clave_textBox.Text = string.Empty;
            FechaIngreso_dateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenaClase()
        {
            Usuarios Usuario = new Usuarios();
            Usuario.UsuarioId = Convert.ToInt32(UsuarioId_numericUpDown.Value);
            Usuario.Nombres = Nombre_textBox.Text;
            Usuario.Email = Email_textBox.Text;
            Usuario.NivelUsuario = Convert.ToInt32(NivelUsuario_numericUpDown.Value);
            Usuario.Usuario = Usuario_textBox.Text;
            Usuario.Clave = Clave_textBox.Text;
            Usuario.FechaIngreso = FechaIngreso_dateTimePicker.Value;

            return Usuario;
        }

        private void LlenaCampo(Usuarios Usuario)
        {
            UsuarioId_numericUpDown.Value = Usuario.UsuarioId;
            Nombre_textBox.Text = Usuario.Nombres;
            Email_textBox.Text = Usuario.Email;
            NivelUsuario_numericUpDown.Value = Usuario.NivelUsuario;
            Usuario_textBox.Text = Usuario.Usuario;
            Clave_textBox.Text = Usuario.Clave;
            FechaIngreso_dateTimePicker.Value = Usuario.FechaIngreso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios Usuario = UsuariosBLL.Buscar((int)UsuarioId_numericUpDown.Value);
            return (Usuario != null);
        }

        private bool Validar()
        {
            bool paso = true;

            if(Nombre_textBox.Text == string.Empty)
            {
                paso = false;
            }

            if (Email_textBox.Text == string.Empty)
            {
                paso = false;
            }


            if (Usuario_textBox.Text == string.Empty)
            {
                paso = false;
            }


            if (Clave_textBox.Text == string.Empty)
            {
                paso = false;
            }
   
            return paso;
        }
    }
}
