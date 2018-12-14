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

namespace PalcoNet.ABMGrado
{
    public partial class ModificacionGradoForm : Form
    {
        private Form callerForm;

        public ModificacionGradoForm(Form callerForm)
        {
            InitializeComponent();
            this.callerForm = callerForm;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
