﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Session
{
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void bindRoleList()
        {
            this.dgvRoleList.AutoGenerateColumns = false;
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            bindRoleList();
        }
    }
}
