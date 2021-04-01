using System;
using System.Windows.Forms;
using System.Drawing;

abstract class Decorator : Panel 
{
    protected Control ctrl; 
    public Decorator(Control c) 
    {
        this.Size=c.Size;
        ctrl=c;
        Controls.Add(c);
        c.Paint += new PaintEventHandler( paint); 
    }
	virtual public void paint(object sender, PaintEventArgs pe){}
}
class SlashDecorator : Decorator 
{
    public SlashDecorator(Control c):base(c){}
    override public void paint(object sender, PaintEventArgs pe)
    {
        Pen aPen = new Pen(Color.Black , 1);
        Graphics g = pe.Graphics;
        int x2 = this.Size.Width; 
        int y2 = this.Size.Height;
        g.DrawLine(aPen,0,0,x2,y2);
    }
}
class CrossDecorator : Decorator
{
    public CrossDecorator(Control c) : base(c) { }
    override public void paint(object sender, PaintEventArgs pe)
    {
        Pen aPen = new Pen(Color.Red, 1);
        Graphics g = pe.Graphics;
        int x2 = this.Size.Width;
        int y2 = this.Size.Height;
        g.DrawLine(aPen, 0, 0, x2, y2);
        g.DrawLine(aPen, x2, 0, 0, y2);
    }
}
class GFrame:Form 
{
    private Button cbutton=new Button();
	private Button dbutton=new Button();
	private SlashDecorator d;
    private CrossDecorator c;
    public GFrame():base()
    {  
        cbutton.Text="cbutton";
        dbutton.Text="dbutton";
        d = new SlashDecorator(dbutton);
        c = new CrossDecorator(cbutton);
        d.SetBounds(100,10,d.Size.Width,d.Size.Height);
        c.SetBounds(10,10, c.Size.Width, c.Size.Height);
        Controls.Add(c);
        Controls.Add(d);
	}
}
 public class Test92
{
	public static void Main(string[] args)
    {
		Application.Run(new GFrame());
	}
}