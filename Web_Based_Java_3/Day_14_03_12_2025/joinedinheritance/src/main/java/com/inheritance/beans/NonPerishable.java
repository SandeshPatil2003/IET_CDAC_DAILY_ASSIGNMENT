package com.inheritance.beans;

import java.time.LocalDate;

import javax.persistence.Column;
import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity(name="102NonPerishable")
public class NonPerishable extends Product {
	
	
	
	@Column(name="Years_Of_Guarantee")
	private int guarantee;

	public NonPerishable() {
		super();
	}

	public NonPerishable(int pid, String pname, int qty, double price, LocalDate mfgdate,int guarantee) {
		super(pid,pname,qty,price,mfgdate);
		this.guarantee = guarantee;
	}
	
	public NonPerishable( String pname, int qty, double price, LocalDate mfgdate,int guarantee) {
		super(pname,qty,price,mfgdate);
		this.guarantee = guarantee;
	}

	public int getGuarantee() {
		return guarantee;
	}

	public void setGuarantee(int guarantee) {
		this.guarantee = guarantee;
	}

	@Override
	public String toString() {
		return super.toString()+"NonPerishable : guarantee=" + guarantee + "]";
	}
	
	
	
	
	
	

}
