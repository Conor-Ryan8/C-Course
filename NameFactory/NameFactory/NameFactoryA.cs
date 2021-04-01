class Namer 
{
	protected string last;   //store last name here
	protected string first;  //store first name here
	public string getFirst() 
	{
		return first; //return first name
	}
	public string getLast() 
	{
		return last; //return last name
	}
}
class FirstFirst : Namer 
{	
	//split first last
	public FirstFirst(string s) 
	{
		int i = s.LastIndexOf(" "); //find sep space
		if (i > 0) 
		{
			//left is first name
			first = s.Substring(0, i).Trim();
			//right is last name
			last =s.Substring(i+1).Trim();
		}
		else 
		{
			first = ""; // put all in last name
			last = s; // if no space
		}
	}
}
class LastFirst : Namer 
{
	//split last, first
	public LastFirst(string s)
	{
		int i = s.IndexOf(",");           //find comma
		if (i > 0)
		{
			//left is last name
			last = s.Substring(0, i).Trim();
			//right is first name
			first = s.Substring(i + 1).Trim();
		}
		else
		{
			last = s; // put all in last name
			first = ""; // if no comma
		}
	}
 }
class NameFactory 
{
	//returns an instance of LastFirst or FirstFirst
	//depending on whether a comma is found
	public Namer getNamer(string entry) {
		int i = entry.IndexOf(","); 
                                            //comma determines order
		if (i>0)
			return new LastFirst(entry); 
                                                  //return one class
		else
			return new FirstFirst(entry); 
                                                 //or the other
		}
     }




