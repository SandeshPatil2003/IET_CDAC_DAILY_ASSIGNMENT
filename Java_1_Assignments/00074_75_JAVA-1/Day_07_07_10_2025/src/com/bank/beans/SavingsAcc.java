package com.bank.beans;

public class SavingsAcc extends Account{
	
	 private static double irate;
	 private static double mab;
	 static {
			irate=0.04;
			mab=20000;
		}
	 private int cbnum;
	 
	 
	  
	 
	


	@Override
	public String toString() {
		return super.toString()+"SavingsAcc [cbnum=" + cbnum + "]";
	}



	public SavingsAcc() {
		super();
	}
	
	
	
	public SavingsAcc( String fname, String lname, int mob, String email, String atype, double bal,
			String acn,int cbnum) {
		super(fname,lname,mob,email,atype,bal,acn);
		
		this.cbnum = cbnum;
	}



	public double getIrate() {
		return irate;
	}
	
	public double getMab() {
		return mab;
	}
	
	public int getCbnum() {
		return cbnum;
	}
	public void setCbnum(int cbnum) {
		this.cbnum = cbnum;
	}
	

}
