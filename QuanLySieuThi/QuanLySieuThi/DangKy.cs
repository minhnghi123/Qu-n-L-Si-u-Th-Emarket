﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = txt_tk.Text.ToString().Trim();
            string mk = txt_mk.Text.ToString().Trim();
            string remk = txt_remk.Text.ToString().Trim();
           
            if (tk == "" || mk == "" || remk == "" )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string sql = "Select count(*) from tknhanvien where tk ='" + tk + "'";
                string sql1 = "Insert into tknhanvien values('" + tk + "','" + mk + "')";
                if (mk == remk)
                {
                    if (mk.Length < 6)
                    {
                        MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        chuoiketnoi.Themdangky(sql, tk, mk, sql1);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Phần Nhập lại và phần mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                main1 a = new main1();
                a.Show();
                this.Close();
            }
        }
    }
}
