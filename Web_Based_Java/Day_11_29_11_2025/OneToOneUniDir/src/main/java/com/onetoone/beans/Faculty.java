package com.onetoone.beans;

import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

import javax.persistence.OneToOne;

@Entity
public class Faculty {
	
	@Id
	@GeneratedValue
	private int fid;
	private String fname;
	private String subject;
	
	@OneToOne( fetch=FetchType.LAZY)
	private Course course;
	
	
	
	public Faculty(String fname, String subject, Course course) {
		super();
		this.fname = fname;
		this.subject = subject;
		this.course = null;
	}

	


	public Faculty(int fid, String fname, String subject) {
		super();
		this.fid = fid;
		this.fname = fname;
		this.subject = subject;
	}
	
	public Faculty( String fname, String subject) {
		super();
		
		this.fname = fname;
		this.subject = subject;
	}
	
	
	public Faculty() {
		super();
	}
	public int getFid() {
		return fid;
	}
	public void setFid(int fid) {
		this.fid = fid;
	}
	public String getFname() {
		return fname;
	}
	public void setFname(String fname) {
		this.fname = fname;
	}
	public String getSubject() {
		return subject;
	}
	public void setSubject(String subject) {
		this.subject = subject;
	}
	
	
	public Course getCourse() {
		return course;
	}


	public void setCourse(Course course) {
		this.course = course;
	}

	
	@Override
	public String toString() {
		return "Faculty [fid=" + fid + ", fname=" + fname + ", subject=" + subject + "]";
	}
	
	
	

}
