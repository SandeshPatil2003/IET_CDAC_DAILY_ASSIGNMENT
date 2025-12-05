package com.springaop.beans;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

@Component
public class SpringUser {
	

	@Value("John Cena")
	private String name;

	public SpringUser() {
		super();
	}

	public SpringUser(String name) {
		super();
		this.name = name;
	}

	public String getName() {
		
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	public void m1() {
		System.out.println("inside m1 method of SpringUser");
	}
	
	public int m2(int x) {
		System.out.println("inside  m2 method of SpringUser "+ x);
		return x+30;
	}
	
	@Override
	public String toString() {
		
		return "SpringUser [name=" + name + "]";
	}
	

}
