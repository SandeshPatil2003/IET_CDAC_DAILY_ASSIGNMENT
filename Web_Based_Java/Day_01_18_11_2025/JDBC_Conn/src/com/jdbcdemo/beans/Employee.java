package com.jdbcdemo.beans;
import java.time.LocalDate;
public class Employee {
	
	private int empid;
	private String ename;
	private double sal;
	//private String hiredate;
	
	private LocalDate hiredate;

	public Employee() {
		super();
	}

	public Employee(int empid, String ename, double sal, LocalDate hiredate) {
		super();
		this.empid = empid;
		this.ename = ename;
		this.sal = sal;
		this.hiredate = hiredate;
	}

	public int getEmpid() {
		return empid;
	}

	public void setEmpid(int empid) {
		this.empid = empid;
	}

	public String getEname() {
		return ename;
	}

	public void setEname(String ename) {
		this.ename = ename;
	}

	public double getSal() {
		return sal;
	}

	public void setSal(double sal) {
		this.sal = sal;
	}

	public LocalDate getHiredate() {
		return hiredate;
	}

	public void setHiredate(LocalDate hiredate) {
		this.hiredate = hiredate;
	}

	@Override
	public String toString() {
		return "Employee [empid=" + empid + ", ename=" + ename + ", sal=" + sal + ", hiredate=" + hiredate + "]";
	}
	
	
	
	
	
	
	
	

}
