package com.j.beans;

import java.time.LocalDate;

public class Product {
	
	private int pid;
	private String name;
	private int qty;
	private double price;
	private LocalDate mfgdate;
	
	
	
	public Product() {
		super();
	}



	public Product(int pid, String name, int qty, double price, LocalDate mfgdate) {
		super();
		this.pid = pid;
		this.name = name;
		this.qty = qty;
		this.price = price;
		this.mfgdate = mfgdate;
	}
	
	public Product( String name, int qty, double price, LocalDate mfgdate) {
		super();
		
		this.name = name;
		this.qty = qty;
		this.price = price;
		this.mfgdate = mfgdate;
	}



	public int getPid() {
		return pid;
	}



	public void setPid(int pid) {
		this.pid = pid;
	}



	public String getName() {
		return name;
	}



	public void setName(String name) {
		this.name = name;
	}



	public int getQty() {
		return qty;
	}



	public void setQty(int qty) {
		this.qty = qty;
	}



	public double getPrice() {
		return price;
	}



	public void setPrice(double price) {
		this.price = price;
	}



	public LocalDate getMfgdate() {
		return mfgdate;
	}



	public void setMfgdate(LocalDate mfgdate) {
		this.mfgdate = mfgdate;
	}



	@Override
	public String toString() {
		return "Product [pid=" + pid + ", name=" + name + ", qty=" + qty + ", price=" + price + ", mfgdate=" + mfgdate
				+ "]";
	}
	
	
	
	
	
	
	
	
	

}
