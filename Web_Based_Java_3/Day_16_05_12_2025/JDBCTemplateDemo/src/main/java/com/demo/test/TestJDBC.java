package com.demo.test;

import java.io.Closeable;
import java.util.List; 
import java.util.Scanner;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.demo.beans.Student;
import com.demo.service.StudentService;

public class TestJDBC {

	public static void main(String[] args) {
		
		
		ApplicationContext ctx = new ClassPathXmlApplicationContext("spring-config.xml");
		
		
		
		StudentService s = (StudentService) ctx.getBean("studentServiceImpl");
		
		
		Scanner sc = new Scanner(System.in);
		
		
		byte choice=0;
		
		
		
		
		do
		{
			System.out.println("MENU");
			System.out.println("1. ADD STUDENT");
			System.out.println("2. DISPLAY ALL STUDENT");
			System.out.println("3. GET STUDENT BY ID");
			System.out.println("4. DELETE STUDENT BY ID");
			System.out.println("5. UPDATE STUDENT DETAILS");
			System.out.println("6. SORT BY ROLLNO");
			System.out.println("7. EXIT");
			System.out.print("ENTER YOUR CHOICE--");	
			
			choice=sc.nextByte();
			
			switch(choice)
			{
			
			case 1->{
				
				boolean status = s.addStudent(sc);
				
				if(status)
				{
					System.out.println("Added Student successfully");
				}
				else {
					
					System.out.println("NOT Added Student successfully");
					
				}
			}
			
			case 2->{
				
				List<Student> slist = s.displayALL();
				
				if(slist!=null)
				{
					slist.forEach(System.out::println);
				}
				else {
					
					System.out.println("not found");
					
				}
			}
			
			case 3->{
				
				System.out.println("Enter student id");
				int sid=sc.nextInt();
				
				Student s1 =s.getStudentbyId(sid);
				
				if(s1!=null)
				{
					System.out.println(s1);
				}
				else {
					
					System.out.println("not found");
					
				}
			}
			
			case 4->{
				
				System.out.println("Enter student id");
				int sid=sc.nextInt();
				
				boolean status =s.deleteStudentbyId(sid);
				
				if(status)
				{
					System.out.println("deleted");
				}
				else {
					
					System.out.println("not found");
					
				}
			}
			
			case 5->{
				
				System.out.println("Enter student id");
				int sid=sc.nextInt();
				
				
				System.out.println("enter new course");
				String course=sc.next();
				System.out.println("enter new rollno");
				int rollno=sc.nextInt();
				boolean status=s.updateStudentById(sid,course,rollno);
				if(status) {
					System.out.println("updated successfully");
				}else {
					System.out.println("not found");
				}
			}
			
			case 6->{
				
				List<Student> slist = s.displayAscRoll();
				
				if(slist!=null)
				{
					slist.forEach(System.out::println);
				}
				else {
					
					System.out.println("not found");
					
				}
			}
			

			
			case 7->{
				
				((ClassPathXmlApplicationContext) ctx).close();
				sc.close();
				System.out.println("Thank you! Exiting");
				
			}
			
			}
			
			
		}
		while(choice!=7);
		

	}


	
}
