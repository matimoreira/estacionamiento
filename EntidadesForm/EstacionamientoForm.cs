using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EntidadesForm
{
    public partial class EstacionamientoForm : Form
    {
        private Estacionamiento estacionamiento;
        public EstacionamientoForm()
        {
            InitializeComponent();
        }

        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            estacionamiento  = new Estacionamiento(100, 150, 30);

            lblEspaciosDisponibles.Text = estacionamiento.EspaciosDisponibles.ToString();
            lblEspaciosOcupados.Text = estacionamiento.CantidadEstacionados.ToString();
            lblPrecioHora.Text = estacionamiento.PrecioHora.ToString();
            lblTotalFacturado.Text = estacionamiento.TotalFacturado.ToString();
            lblTotalEspacios.Text = estacionamiento.Capacidad.ToString();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            estacionamiento.IngresoDetectado(txbPatente.Text);

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems.Add(txbPatente.Text);
            listViewItem.SubItems.Add(estacionamiento.getFechaHora(txbPatente.Text).ToString());

            LvwReservas.Items.Add(listViewItem);

            lblEspaciosDisponibles.Text = estacionamiento.EspaciosDisponibles.ToString();
            lblEspaciosOcupados.Text = estacionamiento.CantidadEstacionados.ToString();
        }

        private void btnEgresar_Click(object sender, EventArgs e)
        {
                        
            if (LvwReservas.SelectedItems.Count > 0)
            {
                //quita el elemento seleccionado de la lista y cambia los valores
                ListViewItem listViewItemSelected = LvwReservas.SelectedItems[0];
                string patente = listViewItemSelected.SubItems[1].Text;
                estacionamiento.EgresoDetectado(patente);
                
                //actualiza valores
                lblEspaciosDisponibles.Text = estacionamiento.EspaciosDisponibles.ToString();
                lblEspaciosOcupados.Text = estacionamiento.CantidadEstacionados.ToString();
                lblTotalFacturado.Text = estacionamiento.TotalFacturado.ToString();

                //lista
                listarVehiculoEstacionados();
            }
        }
        private void listarVehiculoEstacionados()
        {
            LvwReservas.Items.Clear();
            foreach (var patete in estacionamiento.VehiculosEstacionados())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems.Add(patete);
                listViewItem.SubItems.Add(estacionamiento.getFechaHora(patete).ToString());

                LvwReservas.Items.Add(listViewItem);
            }
        }
    }
}
