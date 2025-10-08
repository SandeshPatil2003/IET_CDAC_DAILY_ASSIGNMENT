package com.bank.beans;

import java.util.Arrays;

public class DematAcc extends Account {
	
	private int nofSTotal;
	private Shares sList [];
	
	
	
	
	
	
	
	
	
	
	@Override
	public String toString() {
		return super.toString()+"DematAcc [nofSTotal=" + nofSTotal + ", sList=" + Arrays.toString(sList) + "]";
	}


	public DematAcc() {
		super();
	}
	
	
	public DematAcc(String fname, String lname, int mob, String email, String atype, double bal,
			String acn, int nofSTotal, Shares[] sList) {
		super(fname,lname,mob,email,atype,bal,acn);
		this.nofSTotal = nofSTotal;
		this.sList = sList;
	}


	public int getNofSTotal() {
		return nofSTotal;
	}
	public void setNofSTotal(int nofSTotal) {
		this.nofSTotal = nofSTotal;
	}
	public Shares[] getSList() {
		return sList;
	}
	public void setSList(Shares[] sList) {
		this.sList = sList;
	}

}
