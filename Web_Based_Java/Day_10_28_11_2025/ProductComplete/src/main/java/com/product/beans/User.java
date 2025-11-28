package com.product.beans;

public class User {
	
	private String uname;
	private String email;
	
	
	
	public User() {
		super();
	}
	
	
	
	public User(String uname, String email) {
		super();
		this.uname = uname;
		this.email = email;
	}
	
	
	
	public String getUname() {
		return uname;
	}
	public void setUname(String uname) {
		this.uname = uname;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	
	
	
	@Override
	public String toString() {
		return "User [uname=" + uname + ", email=" + email + "]";
	}
	
	

}
