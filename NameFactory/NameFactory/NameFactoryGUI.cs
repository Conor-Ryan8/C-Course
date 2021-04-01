using System;
using System.Drawing;
using System.Windows.Forms;

class GFrame:Form 
{
	private Label l1=new Label();
	private Label l2=new Label();
	private Label l3=new Label();
	private TextBox t1=new TextBox();
	private TextBox t2=new TextBox();
	private TextBox t3=new TextBox();
	private Button b_compute=new Button();
	private Button b_clear=new Button();
    private Font f=new Font("Times New Roman",10,FontStyle.Bold);
    private NameFactory nfactory = new NameFactory();
    public GFrame():base()
    {  
        l1.Text="Enter Name";
        l2.Text="First Name";
        l3.Text="Last Name";
        l1.Font=f;
        l2.Font=f;
        l3.Font=f;
        b_compute.Text= "Compute";
        b_clear.Text= "Clear";
        l1.SetBounds(10,10,100,43);
        t1.SetBounds(120,10,120,43);
        l2.SetBounds(10,50,100,43);
        t2.SetBounds(120,50,120,43);
        l3.SetBounds(10,90,100,43);
        t3.SetBounds(120,90,120,43); 
        b_compute.SetBounds(30,140,90,33);
        b_clear.SetBounds(150,140,90,33); 
        b_compute.Click += new EventHandler(this.button1_Click);
        b_clear.Click += new EventHandler(this.button3_Click);
        Controls.Add(l1);
        Controls.Add(t1);                
        Controls.Add(l2);
        Controls.Add(t2);           
        Controls.Add(l3);
        Controls.Add(t3); 
        Controls.Add(b_compute);
        Controls.Add(b_clear);
    }
    private void button1_Click(object sender, EventArgs e)
    {
        string myname=t1.Text;
        Namer namer = nfactory.getNamer(myname);
        t2.Text=namer.getFirst();
        t3.Text=namer.getLast();
    }
    private void button3_Click(object sender, EventArgs e)
    {
        t1.Text="";
        t2.Text="";
        t3.Text="";
    }
}
class Test
{
    public static void Main()
    {
       Application.Run(new GFrame());

    }
}