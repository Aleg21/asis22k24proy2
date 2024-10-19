﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class MDI_Produccion : Form
    {
        public MDI_Produccion()
        {
            InitializeComponent();
            ocultaSubMenu();
        }

        // Ocultar submenús al iniciar
        private void ocultaSubMenu()
        {
            if (panelMenuProcesos.Visible == true)
                panelMenuProcesos.Visible = false;
        }

        // Mostrar u ocultar submenús
        private void muestraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultaSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Funcionalidades de botones de procesos
        // Botón de mantenimiento
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Produccion produccion = new Frm_Mantenimiento_Produccion();
            produccion.Show();
        }

        // Botón de órdenes de producción
        private void btnOrdenesProduccion_Click(object sender, EventArgs e)
        {
            Frm_Ordenes_De_Produccion OP = new Frm_Ordenes_De_Produccion();
            OP.Show();
        }

        // Botón de maquinaria
        private void btnMaquinaria_Click(object sender, EventArgs e)
        {
            // Puedes agregar funcionalidad aquí
        }

        // Botón de empleados (enlace a RRHH)
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Frm_Enlace_RRHH RRHH = new Frm_Enlace_RRHH();
            RRHH.Show();
        }

        // Botón de cierre
        private void btnCierre_Click(object sender, EventArgs e)
        {
            Frm_Cierre Cierre = new Frm_Cierre();
            Cierre.Show();
        }

        // Botón de implosión/explosión de materiales
        private void btnImplosionExplosion_Click(object sender, EventArgs e)
        {
            Frm_Implosion_Explosion_Materiales IEM = new Frm_Implosion_Explosion_Materiales();
            IEM.Show();
        }

        // Botón de sistema de producción
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Frm_Sistema_Produccion SP = new Frm_Sistema_Produccion();
            SP.Show();
        }

        // Botón de enlace a contabilidad y cierre (Pólizas)
        private void btnPolizas_Click(object sender, EventArgs e)
        {
            Frm_Enlace_Contabilidad_Cierre Polizas = new Frm_Enlace_Contabilidad_Cierre();
            Polizas.Show();
        }

        // Botón de conversiones
        private void btnConversiones_Click(object sender, EventArgs e)
        {
            Frm_Conversiones Conv = new Frm_Conversiones();
            Conv.Show();
        }

        // Botón de series
        private void btnSeries_Click(object sender, EventArgs e)
        {
            Frm_Series Series = new Frm_Series();
            Series.Show();
        }

        // Botón de lotes
        private void btnLotes_Click(object sender, EventArgs e)
        {
            Frm_Lotes Lotes = new Frm_Lotes();
            Lotes.Show();
        }
        #endregion

        // Mostrar el submenú de procesos
        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProcesos);
        }
    }
}
