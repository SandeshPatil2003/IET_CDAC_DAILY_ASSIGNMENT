package com.springresourcebuilding.test;

import java.util.Locale;
import java.util.Scanner;

import org.springframework.context.ApplicationContext;
import org.springframework.context.MessageSource;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.context.support.ResourceBundleMessageSource;

public class TestLocalMain {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		ApplicationContext ctx=new ClassPathXmlApplicationContext("spring-config.xml");
        MessageSource ms=(MessageSource)ctx.getBean(ResourceBundleMessageSource.class);
        System.out.println("1. MH Marathi \n2. US English\n3. UK English\nchoice:");
        int choice=sc.nextInt();
        Locale locale=null;
        switch(choice) {
        case 1:{
        	locale=new Locale("Marathi","MH");
        	System.out.println("Country name :"+locale.getCountry()+"\n language: "+locale.getLanguage());
        	break;
        	
        }
        case 2:{
        	locale=Locale.US;
        	System.out.println("Country name :"+locale.getCountry()+"language: "+locale.getLanguage());
        	break;
        }
        case 3:{
        	locale=Locale.UK;
        	
        	System.out.println("Country name :"+locale.getCountry()+"language: "+locale.getLanguage());
        	break;
        }
        	
        }
       
        String msg1=ms.getMessage("msg.pay", null,locale);
        String welcomemsg=ms.getMessage("msg.welcome",new Object[] {"JOHN"}, locale);
        String billmsg=ms.getMessage("msg.billmsg",null, locale);
        String currency=ms.getMessage("msg.currency",null, locale);
        
       
        
        System.out.println(msg1);
        System.out.println(welcomemsg);
        System.out.println(billmsg);
        double amount=sc.nextDouble();
        System.out.println("Your bill amount : "+currency+" "+ amount+" "+"is receieved");
        
        sc.close();
        
	}

}
