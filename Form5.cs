using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;


namespace Afo
{
    public partial class Form5 : Form
    {
        public class Win32
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern int LoadKeyboardLayoutA(string pwszKLID, int Flags);
        }
        public Form5()
        {
            InitializeComponent();
        }

        string ww;
        public void con(string s, int num)
        {
            OleDbConnection co = new OleDbConnection();
            co.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\daro.mdb;Persist Security Info=False;Jet OLEDB:Database Password=daro;";
            co.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = s;
            cmd.Connection = co;
            switch (num)
            {
                case 1:
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("     عملیات با موفقیت انجام شد     ");
                        }
                        catch
                        {
                            MessageBox.Show("     عملیات با موفقیت انجام نشد     ");
                        }
                        break;
                    }
                case 2:
                    {
                        OleDbDataReader dr = cmd.ExecuteReader();
                        object[] o1 = new object[6];
                        while (dr.Read())
                        {
                            dr.GetValues(o1);
                            dataGridView1.Rows.Add(o1);


                        }

                        break;
                    }




            }
            
            co.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            label0.Text = "     آماده برای اضافه کردن     ";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox7.Text = ""; 
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            label0.Text = "     آماده برای ویرایش      ";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox7.Text = ""; 
            dataGridView1.Rows.Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true ;
            label0.Text = "    آماده برای حذف       ";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox7.Text = ""; 
            dataGridView1.Rows.Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label0.Text = "    جستجو    ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (textBox1.Text == "")
            {
                err.SetError(textBox1, " دارو را وارد کنید");
                goto h;
            }
            else if (textBox2.Text == "")
            {
                err.SetError(textBox2, "نام دارو");
                goto h;
            }
            else if (textBox3.Text == "")
            {
                err.SetError(textBox3, "قیمت");
                goto h;
            }
            else if (textBox4.Text == "")
            {
                err.SetError(textBox4, "تعداد ");
                goto h;
            }
            else if (textBox5.Text == "")
            {
                err.SetError(textBox5, "تاریخ ");
                goto h;
            }

            //*************************************
            else
            {
                con("Insert Into daro Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", 1);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                label0.Text = "  اطلاعات اضافه شد  ";
            }
        h:
            {
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Win32.LoadKeyboardLayoutA("00000429", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a1, a2, a3, a4, a5, a6;
            a1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a3 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a4 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            a5 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            a6 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            con("Update daro Set name='" + a2 + "',gemte='" + a3 + "',tedad='" + a4 + "',datakh='" + a5 + "',re='" + a6 + "' Where num='" + a1 + "'", 1);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == string.Empty)
                dataGridView1.Rows.Clear();
            else
            {
                dataGridView1.Rows.Clear();
                con("Select * from daro Where num like '" + textBox7.Text + "%'", 2);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("آیا حذف شود", " عملیات حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {                
                con("Delete from daro Where num='" + ww + "'", 1);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.Refresh();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string a1, a2, a3, a4, a5, a6;
            a1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a3 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a4 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            a5 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            a6 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ww = a1;
            //button3.Enabled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 27)
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.KeyChar = Convert.ToChar(0);

                }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 27)
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.KeyChar = Convert.ToChar(0);

                }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 27)
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.KeyChar = Convert.ToChar(0);

                }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 27)
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.KeyChar = Convert.ToChar(0);

                }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 27)
                if (char.IsLetter(e.KeyChar) == false)
                {
                    e.KeyChar = Convert.ToChar(0);

                }
        }
    }
}