using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Windows.Forms;
using program2;
using Microsoft.VisualBasic;
using System.IO;

namespace program1
{
    public partial class Form1 : Form
    {
       
        int n = 0;
        string id,name, good,phone;
        double price;
        BindingSource bs = new BindingSource();
        OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
            //string id = Interaction.InputBox("请输入订单序号", "标题", "", -1, -1);
            //if (IsIdRight(id))
            //{
            //    MessageBox.Show("yes");
            //}
            //else
            //{
            //    MessageBox.Show("no");
            //}
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
                //form2.ShowDialog();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    if (IsIdRight(form2.textBox1.Text))
                    {
                        if (IsTelephone(form2.textBox5.Text))
                        {
                            id = form2.textBox1.Text;
                            name = form2.textBox2.Text;
                            good = form2.textBox3.Text;
                            price = double.Parse(form2.textBox4.Text);
                            phone = form2.textBox5.Text;
                            orderService.addorder(id, name, good, price, phone);
                            //orderService.Myorder[n].ID = n;
                            bs.Add(orderService.Myorder[n]);
                            myorderBindingSource.DataSource = bs;
                            n++;
                        }
                        else
                        {
                            MessageBox.Show("电话号码错误");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID不符合格式");
                    }
                }
              

                
            }
            catch (FormatException)
            {
                MessageBox.Show("价格有误，请重新操作");
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
            int m=0;
            try
            {
                string id = Interaction.InputBox("请输入订单序号", "标题", "", -1, -1);
                m = orderService.Myorder.FindIndex(a => a.ID.Equals(id));
                try
                {

                    Form2 form2 = new Form2();
                    form2.Text = "订单修改";
                    //form2.ShowDialog();
                    if (form2.ShowDialog() == DialogResult.OK)
                    {
                        if (IsIdRight(form2.textBox1.Text))
                        {
                            if (IsTelephone(form2.textBox5.Text))
                            {
                                orderService.Myorder[m].ID = form2.textBox1.Text;
                                orderService.Myorder[m].Name = form2.textBox2.Text;
                                orderService.Myorder[m].Good = form2.textBox3.Text;
                                orderService.Myorder[m].Price = double.Parse(form2.textBox4.Text);
                                orderService.Myorder[m].Phone = form2.textBox5.Text;
                                //myorderBindingSource.DataSource = orderService.Myorder;
                                if (dataGridView1.InvokeRequired)
                                {
                                    dataGridView1.Invoke(new Action(() => dataGridView1.Refresh()));
                                }
                            }
                            else
                            {
                                MessageBox.Show("电话号码错误");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID不符合格式");
                        }

                    }
                }
                //dataGridView1.Update();
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("订单序号不在范围");
                }
                catch (FormatException)
                {
                    MessageBox.Show("数字输入有误，请重新操作");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入数字");
                
            }
            catch
            { }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            orderService.Export();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"序列化.xml");
                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"..\..\序列化.xslt");
                xt.Transform("序列化.xml", @"..\..\序列化.html");

                //XmlDocument doc = new XmlDocument();
                //doc.Load(@"序列化.xml");

                //XPathNavigator nav = doc.CreateNavigator();
                //nav.MoveToRoot();

                //XslCompiledTransform xt = new XslCompiledTransform();
                //xt.Load(@"序列化.xslt");

                //FileStream outFileStream = File.OpenWrite(@"序列化.html");
                //XmlTextWriter writer = new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                //xt.Transform(nav, null, writer);
                MessageBox.Show("已导出为.html文件");

            }
            catch (XmlException )
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException )
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
        }


        public bool IsTelephone(string str_telephone)

        {

            return Regex.IsMatch(str_telephone, @"^[1][3,5]\d{9}$");

        }
        public bool IsIdRight(string id)
        {
            return Regex.IsMatch(id, @"^[2][0][1][0-9]((0[1-9])|1[0-2])((0[1-9])|([1,2][0-9])|(3[0,1]))\d{3}$");
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
