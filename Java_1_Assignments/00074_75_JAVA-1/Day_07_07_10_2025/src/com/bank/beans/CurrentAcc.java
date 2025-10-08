package com.bank.beans;

public class CurrentAcc extends Account{
	
	private static double irate;
	private static double mab;
	
	static {
		irate=0.01;
		mab=1000;
	}
	
	private int nofTDay;
	private double avgABal;
	
	
	
	public CurrentAcc() {
		super();
	}

	public CurrentAcc(String fname, String lname, int mob, String email, String atype, double bal,
			String acn,int nofTDay, double avgABal) {
		super(fname,lname,mob,email,atype,bal,acn);
		this.nofTDay = nofTDay;
		this.avgABal = avgABal;
	}
	
	
	
	
	
	
	public static double getIrate() {
		return irate;
	}
	
	public static double getMab() {
		return mab;
	}
	
	

	public int getNofTDay() {
		return nofTDay;
	}
	public void setNofTDay(int nofTDay) {
		this.nofTDay = nofTDay;
	}
	public double getAvgABal() {
		return avgABal;
	}
	public void setAvgABal(double avgABal) {
		this.avgABal = avgABal;
	}
	
	@Override
	public String toString() {
		return super.toString()+"CurrentAcc [nofTDay=" + nofTDay + ", avgABal=" + avgABal + "]";
	}

}
