package com.bank.beans;

 public class Account {
	static int scount,ccount,dcount;
	static {
		scount=0;
		ccount=0;
		dcount=0;
	}
	
	private String aid;
	private String fname;
	private String lname;
	private int mob;
	private String email;
	private String atype;
	private double bal;
	private String acn;
	
	
	public Account() {
		
		System.out.println("in Account default constructor");
		
		
		
		
	}
	
	
	
	@Override
	public String toString() {
		return "Account [aid=" + aid + ", fname=" + fname + ", lname=" + lname + ", mob=" + mob + ", email=" + email
				+ ", atype=" + atype + ", bal=" + bal + ", acn=" + acn + "]";
	}



	public Account( String fname, String lname, int mob, String email, String atype, double bal,
			String acn) {
		super();
		this.aid = generateId(atype);
		this.fname = fname;
		this.lname = lname;
		this.mob = mob;
		this.email = email;
		this.atype = atype;
		this.bal = bal;
		this.acn = acn;
	}



	private String generateId(String atype) {
		if (atype.equals("s")) {
			scount++;
			return atype+scount;
		}else if (atype.equals("c")) {
			ccount++;
			return atype+ccount;
		}else if(atype.equals("d")) {
			dcount++;
			return atype+dcount;
		}
		return null;
		
	}

	public static int getScount() {
		return scount;
	}

	public static void setScount(int scount) {
		Account.scount = scount;
	}

	public static int getCcount() {
		return ccount;
	}

	public static void setCcount(int ccount) {
		Account.ccount = ccount;
	}

	public static int getDcount() {
		return dcount;
	}

	public static void setDcount(int dcount) {
		Account.dcount = dcount;
	}

	public String getFname() {
		return fname;
	}

	public void setFname(String fname) {
		this.fname = fname;
	}

	public String getLname() {
		return lname;
	}

	public void setLname(String lname) {
		this.lname = lname;
	}

	public int getMob() {
		return mob;
	}

	public void setMob(int mob) {
		this.mob = mob;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getAtype() {
		return atype;
	}

	public void setAtype(String atype) {
		this.atype = atype;
	}

	public double getBal() {
		return bal;
	}

	public void setBal(double bal) {
		this.bal = bal;
	}

	public String getAcn() {
		return acn;
	}

	public void setAcn(String acn) {
		this.acn = acn;
	}

	public String getAid() {
		return aid;
	}
	
	
	
	
	

}
