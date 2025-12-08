package com.demo.SpringBootStudent.beans;

import java.time.LocalDate;

import org.springframework.format.annotation.DateTimeFormat;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name="Student101")
public class Student {
	
	@Id
	private int sid;
	private String sname;
	@DateTimeFormat(pattern ="yyyy-MM-dd")
	private LocalDate dob;
	private String course;
	
	
	
	public Student() {
		super();
	}
	
	
	public Student(int sid, String sname, LocalDate dob, String course) {
		super();
		this.sid = sid;
		this.sname = sname;
		this.dob = dob;
		this.course = course;
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
	public LocalDate getDob() {
		return dob;
	}
	public void setDob(LocalDate dob) {
		this.dob = dob;
	}
	public String getCourse() {
		return course;
	}
	public void setCourse(String course) {
		this.course = course;
	}
	@Override
	public String toString() {
		return "Student [sid=" + sid + ", sname=" + sname + ", dob=" + dob + ", course=" + course + "]";
	}
	
	
	

}
