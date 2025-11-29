package com.onetoone.test;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;

import com.onetoone.beans.Course;
import com.onetoone.beans.Faculty;

public class TestMain {

	public static void main(String[] args) {
		
		
		SessionFactory sf = new Configuration().configure().buildSessionFactory();
		
		Session session = sf.openSession();
		
		Transaction tr = session.beginTransaction();
		
		
		Faculty f1 = new Faculty("rahul","html");
		
		Course c1 = new Course("WedDev",2,f1);
		f1.setCourse(c1);
		
		
		session.save(f1);
		session.save(c1);
		
		tr.commit();
		
		
		
	
		
		session.close();
		sf.close();
		
		

	}

}
