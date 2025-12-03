package com.onetoone.test;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;

import com.onetoone.beans.*;

public class TestGetCourse {

	public static void main(String[] args) {
		
		
		SessionFactory sf = new Configuration().configure().buildSessionFactory();

		Session session = sf.openSession();
		
		Transaction tr = session.beginTransaction();
		
		System.out.println("Before get");
		
		
		
		Course c1 = session.get(Course.class, 7);
		Faculty f1 = session.get(Faculty.class, 6);
		//Course c2 = new Course("java",4,f1);
		
		//session.save(c2);
		
		System.out.println("After get");
		
		
		tr.commit();
		
		System.out.println(c1);
		System.out.println(f1);
		
		session.close();
		sf.close();
		
	
	}

}
