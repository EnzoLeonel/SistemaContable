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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BotonLibroDiario_Click(object sender, EventArgs e)
        {
            try { 
               // LibroDiario vistaLB = new LibroDiario(this);
                //vistaLB.Visible = true;
                //this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
