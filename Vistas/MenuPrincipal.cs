﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaContable.Vistas;

namespace SistemaContable
{
    public partial class MenuPrincipal : Form
    {
        private Controlador controlador;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BotonLibroDiario_Click(object sender, EventArgs e)
        {
            controlador.nuevoLibroDiario();
        }

        private void botonLibroMayor_Click(object sender, EventArgs e)
        {/*
            try { 
                LibroMayor vistaLM = new LibroMayor(this);
                vistaLM.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        private void MenuPrincipal_Load(object sender, EventArgs e){}

        private void botonAjustes_Click(object sender, EventArgs e)
        {
            try { 
                AjustesMenu vistaAJ = new AjustesMenu(this,controlador);
                vistaAJ.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void setControlador(Controlador controlador)
        {
            this.controlador = controlador;
        }
    }
}
