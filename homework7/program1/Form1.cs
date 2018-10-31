using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program2;
using Microsoft.VisualBasic;
namespace program1
{
    public partial class Form1 : Form
    {
       
        int n = 0;
        string name, good;
        double price;
        BindingSource bs = new BindingSource();
        OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.Text = "订单添加";
                form2.ShowDialog();
                /*if (form2.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("添加成功");
                }*/
                name = form2.textBox1.Text;
                good = form2.textBox2.Text;
                price = double.Parse(form2.textBox3.Text);

                orderService.addorder(name, good, price);
                orderService.Myorder[n].ID = n;
                bs.Add(orderService.Myorder[n]);
                myorderBindingSource.DataSource = bs;
                n++;
            }
            catch (FormatException)
            {
                MessageBox.Show("订单有误，请重新操作");
            }
            catch
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Order p = orderService.serchbyname(textBox1.Text);
                
                MessageBox.Show(p.Name+"先生购买了"+p.Good+"，共"+p.Price+"万元");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("无此订单");
            }
            catch { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Order p = orderService.serchbygood(textBox2.Text);

                MessageBox.Show(p.Name + "先生购买了" + p.Good + "，共" + p.Price + "万元");

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("无此订单");
            }
            catch { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Interaction.InputBox("请输入订单序号", "标题", "文本内容", -1, -1);
                int m = int.Parse(str);
                Form2 form2 = new Form2();
                form2.Text = "订单修改";
                form2.ShowDialog();
                /*if (form2.ShowDialog() == DialogResult.OK)
               {
                   MessageBox.Show("修改成功");
               }*/
                orderService.Myorder[m].Name = form2.textBox1.Text;
                orderService.Myorder[m].Good = form2.textBox2.Text;
                orderService.Myorder[m].Price = double.Parse(form2.textBox3.Text);
                myorderBindingSource.DataSource = orderService.Myorder;
                //dataGridView1.Update();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("订单序号不在范围");
            }
            catch (FormatException)
            {
                MessageBox.Show("数字输入有误，请重新操作");
            }
            catch
            { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
