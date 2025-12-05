package com.springaop.test;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.springaop.beans.SpringUser;

public class TestAOP {

	public static void main(String[] args) {
		
		
		ApplicationContext ctx=new ClassPathXmlApplicationContext("spring-config.xml");
		
		
		
		SpringUser user1=(SpringUser)ctx.getBean("springUser");
		
		
		System.out.println(user1);
		
		
		user1.m1();
		
		
		
		int ans=user1.m2(33);
		
		
		System.out.println("Answer : "+ans);
		
		
		System.out.println(user1.getName());

	}

}
