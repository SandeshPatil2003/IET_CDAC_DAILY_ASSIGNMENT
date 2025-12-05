package com.demo.beans;


public class Student {
	
	
	private int sid;
	private String sname;
	private int rollno;
	private String course;
	
	
	public Student(int sid, String sname, int rollno, String course) {
		super();
		this.sid = sid;
		this.sname = sname;
		this.rollno = rollno;
		this.course = course;
	}


	public Student() {
		super();
	}


	@Override
	public String toString() {
		return "Student [sid=" + sid + ", sname=" + sname + ", rollno=" + rollno + ", course=" + course + "]";
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


	public int getRollno() {
		return rollno;
	}


	public void setRollno(int rollno) {
		this.rollno = rollno;
	}


	public String getCourse() {
		return course;
	}


	public void setCourse(String course) {
		this.course = course;
	}
	
	
	
	
	
	
	
}
