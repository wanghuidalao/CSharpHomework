using System;
using System.Windows.Forms;
using System.Drawing;
public class Form1 : Form
{
    TextBox txt = new TextBox();
    TextBox txt2 = new TextBox();
    Button btn = new Button();
    Label lal = new Label();

    public void init()
    {
        this.Controls.Add(txt);
        this.Controls.Add(txt2);
        this.Controls.Add(btn);
        this.Controls.Add(lal);
        txt.Dock = System.Windows.Forms.DockStyle.Top;
        txt2.Dock = System.Windows.Forms.DockStyle.Top;
        btn.Dock = System.Windows.Forms.DockStyle.Right;
        lal.Dock = System.Windows.Forms.DockStyle.Bottom;
        btn.Text = "求积";
        lal.Text = "结果标签";
        this.Size = new Size(300, 140);

        btn.Click += new System.EventHandler(this.button1_click);
    }

    public  void button1_click(object sender, EventArgs e)
    {
        string s = txt.Text;
        string n = txt2.Text;
        double a = double.Parse(s);
        double b = double.Parse(n);
        double sq = a * b;
        lal.Text = "两个数的乘积为：" + sq;
    
    }
    static void Main()
    {
        Form1 f = new Form1();
        f.Text = "Form1";
        f.init();
        Application.Run(f);
    }
}