﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QLDV
{
    public partial class Form_MainChiDoan : Form
    {
        public Form_MainChiDoan()
        {
            InitializeComponent();
        }

        private void btnQuanlydoanphi_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Quản Lý Đoàn Phí Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_QuanLyDoanPhiChiDoan dv = new Form_QuanLyDoanPhiChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnTimkiemdoanvien_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Tìm Kiếm Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_TimKiemDoanVienChiDoan dv = new Form_TimKiemDoanVienChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {
        }

        private void btnQuanlydoanvien_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Quản Lý Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_QuanLyDoanVienChiDoan dv = new Form_QuanLyDoanVienChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnQuanlykiluatdoanvien_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Quản Lý Kỷ Luật Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_QuanLyKyLuatChiDoan dv = new Form_QuanLyKyLuatChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnXuatdanhsachdoanvien_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Xuất Danh Sách Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_XuatDanhSachDoanVienChiDoan dv = new Form_XuatDanhSachDoanVienChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnXuatdanhsachkyluat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Xuất Danh Sách Đoàn Viên Bị Kỷ Luật");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_XuatDanhSachDoanVienBiKyLuatChiDoan dv = new Form_XuatDanhSachDoanVienBiKyLuatChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnXuatchuadongdoanphi_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Xuất Danh Sách Đoàn Viên Chưa Đóng Đoàn Phí");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_XuatDanhSachDoanVienChuaDongDoanPhiChiDoan dv = new Form_XuatDanhSachDoanVienChuaDongDoanPhiChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnTimkiemchuadongdoanphi_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Tìm Kiếm Đoàn Viên Chưa Đóng Đoàn Phí");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_TimKiemDoanVienChuaDongDoanPhiChiDoan dv = new Form_TimKiemDoanVienChuaDongDoanPhiChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Đánh Giá Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_DanhGiaChiDoan dv = new Form_DanhGiaChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void Form_MainChiDoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tabControl1_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát tab này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelItem1.Text = DateTime.Now.ToString();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Đổi Mật Khẩu");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_DoiMatKhauChiDoan dv = new Form_DoiMatKhauChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Thống Kê Giới Tính Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_ThongKeGioiTinhDoanVienChiDoan dv = new Form_ThongKeGioiTinhDoanVienChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Thống Kê Xếp Loại Đoàn Viên");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_ThongKeXepLoaiDoanVienChiDoan dv = new Form_ThongKeXepLoaiDoanVienChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnDoimatkhau_Click_1(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Đổi Mật Khẩu");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_DoiMatKhauChiDoan dv = new Form_DoiMatKhauChiDoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void Office2007Blue_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
        }

        private void Office2007Sliver_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
        }

        private void Office2007Black_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
        }

        private void Office2007VistaGlass_Click_2(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
        }

        private void Office2010Black_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
        }

        private void Office2010Blue_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
        }

        private void Office2010Sliver_Click_2(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
        }

        private void Visual2010Blue_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
        }

        private void VisualStudio2010Blue_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
        }

        private void VisualStudio2012Light_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
        }

        private void VisualStudio2012Dark_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
        }

        private void Windows7Blue_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
        }

        private void Office2016_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
        }

        private void Metro_Click_2(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }

        private void Metro2_Click_1(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }
        private void OfficeMobile2014_Click_2(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            Form_Login FG = new Form_Login();
            FG.Show();
            this.Hide();
        }

        private void btnThongtinphanmem_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Thông Tin Phần Mềm");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_ThongTinPhanMem dv = new Form_ThongTinPhanMem();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Xuất danh sách đánh giá đoàn viên ");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_Xuatdanhgiachidoan dv = new Form_Xuatdanhgiachidoan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }

        private void btnhuongdansudung_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabItem tb = tabControl1.CreateTab("Hướng dẫn sử dụng phần mềm");
            DevComponents.DotNetBar.TabControlPanel pn = (DevComponents.DotNetBar.TabControlPanel)tb.AttachedControl;
            tabControl1.SelectedTab = tb;
            Form_Huongdan dv = new Form_Huongdan();
            dv.FormBorderStyle = FormBorderStyle.None;
            dv.AutoScroll = true;
            dv.TopLevel = false;
            dv.Parent = tabControl1.SelectedPanel;
            dv.Show();
            dv.Dock = DockStyle.Fill;
            pn.Controls.Add(dv);
        }
    }
}
