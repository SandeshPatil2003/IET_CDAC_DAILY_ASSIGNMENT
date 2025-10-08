package com.bank.beans;

import java.util.Date;

public class Shares {
	
	private int sid;
	private String sname;
	private Date dop;
	private Date dos;
	private double bprice;
	private double sprice;
	private int nofS;
	
	
	
	
	public Shares() {
		super();
	}
	
	public Shares(int sid, String sname, Date dop, Date dos, double bprice, double sprice) {
		super();
		this.sid = sid;
		this.sname = sname;
		this.dop = dop;
		this.dos = dos;
		this.bprice = bprice;
		this.sprice = sprice;
	}
	
	@Override
	public String toString() {
		return "Shares [sid=" + sid + ", sname=" + sname + ", dop=" + dop + ", dos=" + dos + ", bprice=" + bprice
				+ ", sprice=" + sprice + ", nofS=" + nofS + "]";
	}

	public int getNofS() {
		return nofS;
	}

	public void setNofS(int nofS) {
		this.nofS = nofS;
	}

	
	
	public int getSid() {
		return sid;
	}

	
	public void setSid(int sid) {
		this.sid = sid;
	}
	public String getSname() {
		return sname;
	}
	public void setSname(String sname) {
		this.sname = sname;
	}
	public Date getDop() {
		return dop;
	}
	public void setDop(Date dop) {
		this.dop = dop;
	}
	public Date getDos() {
		return dos;
	}
	public void setDos(Date dos) {
		this.dos = dos;
	}
	public double getBprice() {
		return bprice;
	}
	public void setBprice(double bprice) {
		this.bprice = bprice;
	}
	public double getSprice() {
		return sprice;
	}
	public void setSprice(double sprice) {
		this.sprice = sprice;
	}
	

}
