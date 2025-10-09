package com.quiz.test;

import java.util.Scanner;

import com.quiz.service.QuizService;
import com.quiz.service.QuizServiceImpl;



public class TestMainQuiz {

	public static void main(String[] args) {


		Scanner sc=new Scanner(System.in);
		QuizService qservice=new QuizServiceImpl();
		byte choice=0;
		byte choice1=0,choice2=0;
		byte exitv=0;
		String password="pass1";
		do {
			
			System.out.println("Enter App Mode\n 1.Admin \n 2.User \n 3.Exit");
			
			choice=sc.nextByte();
			
			
			
			switch(choice)
			{
			
			case 1->{
					
						System.out.println("Entered Admin Mode");
						System.out.println("Enter Password");
						String epass=sc.next();
						if(epass.equals(password))
						{
							
							do {
							System.out.println("Admin Mode \n 1.Add Question \n 2.Load Quiz \n 3.Display ALL ");
							choice1=sc.nextByte();
							switch(choice1)
							{
							
							case 1->{
										System.out.println("Enter Quiz Id to add question to");
										int quizid=sc.nextInt();
										
										qservice.addQuestion(quizid);
								
								
										
							}
							
							case 2->{
										System.out.println("Enter Quiz Id to load quiz");
										int quizid=sc.nextInt();
								
										qservice.loadQuiz(quizid);
									
										
							}
							
							case 3->{
								System.out.println("Displaying ALL");
								
								System.out.println("Enter Quiz Id to display whole quiz");
								int quizid=sc.nextInt();
						
								qservice.displayAll(quizid);
							
								
					}
							
							case 4->{System.out.println("Exiting Goodbye!"); }
							
							default->{System.out.println("Invalid Choice Try Again");}
							
							
							
							
							
							}
							
							
							
								
								
								
							}
							while(choice1!=4);
						
						
						}
						
						else {System.out.println("Wrong Password");}
							
							
							
						
							
							
						}
							
			
						
			
			case 2->{
				
						System.out.println("Entered User Mode");
						
						do {
						
						System.out.println("User Mode \n 1.Display Quiz options \n 2.Choose Quiz \n 3.Exit ");
						
						choice2=sc.nextByte();
						switch(choice2)
						{
						
						case 1->{System.out.println("Options are:");
						
									qservice.displayUserOptions();
						
								}
						
						case 2->{
							
							System.out.println("Enter Quiz Id to start quiz");
							int quizid=sc.nextInt();
					
							qservice.startUserQuiz(quizid);
						}
						
						case 3->{
							System.out.println("Exiting Goodbye!");}
						
						default->{System.out.println("Invalid Choice Try Again");}
						
						
						
						
						
						}
						
						
						
							
							
							
						
						
						}
						while(choice2!=3);
						
					}
			
			
			case 3->{sc.close();System.out.println("Thank you");}
			
			default->{System.out.println("Invalid Choice!");}
			
			
			}
		

		}
		while(exitv!=1);

}
	
}
