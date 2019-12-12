﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;
using MaterialSkin;

namespace Sistema_Control_Estudiantil
{
    public partial class StudentLogin : Form
    {
        private Sections Sections { get; set; }

        public StudentLogin(Sections sections)
        {
            Sections = sections;
            InitializeComponent();
        }

        private void btnStudentOption_Click(object sender, EventArgs e)
        {
            Sections.LoginStudentEvent(txtUsuario.Text);
        }
    }
}
