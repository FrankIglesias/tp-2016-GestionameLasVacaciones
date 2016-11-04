﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = RolManager.mostrarTodasLasFuncionalidades();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) || this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor introduzca un nombre o seleccione una funcionalidad para agregar");
            }
            else
            {
                DataGridViewSelectedRowCollection seleccion = this.dataGridView1.SelectedRows;
                foreach (DataGridViewRow funcionalidad in seleccion)
                {
                    RolManager.agregarRolYFuncionalidad(this.txtNombre.Text, Convert.ToString(funcionalidad.Cells[1].Value));
                }

                MessageBox.Show("Las funcionalidades han sido agregadas al rol exitosamente");
            }
        }
    }
}