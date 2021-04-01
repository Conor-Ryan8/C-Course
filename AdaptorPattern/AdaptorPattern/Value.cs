 using System;

class Value
{
	private int number;
	public Value(int n)
	{
		number=n;
	}
	public void step_up(int v)
	{
		number+=v;
	}
	public void step_down(int v)
	{
		number-=v;
	}
	public int read_val()
	{ 
		return number;
	}
}