using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_CargoUsuario.BLL;
using Proyecto_CargoUsuario.Entidades;

namespace Proyecto_CargoUsuario.UI.Registros
{
    public partial class rCargo : Form
    {
        public rCargo()
        {
            InitializeComponent();
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Cargos Cargo;
            bool paso = false;

            if (!Validar())
            {
                return;
            }

            Cargo = LlenaClase();

            if (CargoId_numericUpDown.Value == 0)
            {
                paso = CargosBLL.Guardar(Cargo);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar el Cargo que no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosBLL.Modificar(Cargo);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(CargoId_numericUpDown.Text, out id);

            Limpiar();

            if (CargosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se puede eliminar este Cargo", "No Hubo Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);         

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            Cargos Cargo;
            int id = Convert.ToInt32(CargoId_numericUpDown.Value);

            Limpiar();
            Cargo = CargosBLL.Buscar(id);

            if (Cargo != null)
            {
                LlenaCampo(Cargo);
                MessageBox.Show("Cargo Encontrado");
            }
            else
                MessageBox.Show("Cargo No Encontrado");

        }

        private void Limpiar()
        {
            CargoId_numericUpDown.Value = 0;
            Descripcion_textBox.Text = string.Empty;
        }

        private Cargos LlenaClase()
        {
            Cargos Cargo = new Cargos();
            Cargo.CargoId = Convert.ToInt32(CargoId_numericUpDown.Value);
            Cargo.Descripcion = Descripcion_textBox.Text;

            return Cargo;
        }

        private void LlenaCampo(Cargos Cargo)
        {
            CargoId_numericUpDown.Value = Cargo.CargoId;
            Descripcion_textBox.Text = Cargo.Descripcion;

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargos Cargo = CargosBLL.Buscar((int)CargoId_numericUpDown.Value);
            return (Cargo != null);
        }

        private bool Validar()
        {
            bool paso = true;

            if(string.IsNullOrEmpty(Descripcion_textBox.Text))
            {
                MessageBox.Show("No Puede dejar el campo Descripción", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = false;
            }

            return paso;
        }
    }
}
