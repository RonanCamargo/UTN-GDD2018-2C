﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Factory.Form;

namespace PalcoNet.ABMGrado
{
    public partial class ABMGradoPublicacionForm : Form
    {
        private Form callerForm;

        public ABMGradoPublicacionForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbABM.SelectedItem != null)
            {
                NavigableFormUtil.ForwardTo(this, ABMGradoDePublicacionFactory.CrearForm(cmbABM.SelectedItem.ToString(), this));
            }
            else
            {
                MessageBoxUtil.ShowError("Seleccione una acción.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
