﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu.UI.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Admin_QLKH admin_QLKH = new Admin_QLKH();
            Admin_QLSP admin_QLSP = new Admin_QLSP();
            Admin_QLHoaDon admin_QLHoaDon = new Admin_QLHoaDon();
            Admin_QLDNH admin_QLDNH = new Admin_QLDNH();
            tabPage1.Controls.Add(admin_QLKH);
            tabPage2.Controls.Add(admin_QLSP);
            tabPage3.Controls.Add(admin_QLHoaDon);
            tabPage4.Controls.Add(admin_QLDNH);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
