package Vehicle;


import java.util.Date;

public class Vehicle
{
	private int vid;
	private String oname;
	private String vtype;
	private Date dpurchase;
	
	//getter
	
	public int getVid()
	{
		return vid;
	}
	public String getOname()
	{
		return oname;
	}
	public String getVtype()
	{
		return vtype;
	}
	public Date getDpurchase()
	{
		return dpurchase;
	}
	
	//setter
	
	public void setVid(int id)
	{
		vid=id;
	}
	
	public void setOname(String name)
	{
		oname=name;
	}
	public void setVtype(String type)
	{
		vtype=type;
	}
	public void setDpurchase(Date d)
	{
		dpurchase=d;
	}
	
	// Default Constructor
	
	public Vehicle() 
	{
		vid=0;
		oname=null;
		vtype=null;
		dpurchase=null;
	}
	
	public Vehicle(int id,String name,String type,Date d)
	{
		vid=id;
		oname=name;
		vtype=type;
		dpurchase=d;
	}
	
	public String toString()
	{
		return "Vid :"+vid+" Owner Name :"+oname+" Vehicle Type :"+vtype+" Date of Purchase :"+dpurchase+"\n";
	}
	
	
	
}

