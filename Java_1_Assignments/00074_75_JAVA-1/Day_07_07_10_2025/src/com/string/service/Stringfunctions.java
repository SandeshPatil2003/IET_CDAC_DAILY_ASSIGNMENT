package com.string.service;

import java.util.Arrays;

public class Stringfunctions {

	public static void main(String[] args) {
		
		
		String s= new String("Hello World!");
		
		String s1="Test";
		String s2="Test";
		String s3=s2;
		String s4= new String("Test");
		String s5 = "Hello from CDAC..";
		String s6 = "hello from cdac";
		
		String s7="xxx,yyy,zzz-rrr";
		String s8="Testdoc";
		
		
		System.out.println("s1==s2 :"+(s1==s2));
		System.out.println("s4==s2 :"+(s4==s2));
		System.out.println("s1.equals(s2) :"+s1.equals(s2));
		System.out.println("s4.equals(s2) :"+s4.equals(s2));
		System.out.println("s8.compareTo(s2) :"+s8.compareTo(s2));
		
		System.out.println("s1.toUpperCase() :"+s1.toUpperCase());
		
		System.out.println("s1.toLowerCase() :"+s1.toLowerCase());
		
		System.out.println("s1.charAt(3) :"+s1.charAt(3));
		
		System.out.println("s5.contains(\"from\") :"+s5.contains("from"));
		
		String [] a=s6.split(" ");
		System.out.println("s6.split(\" \") :"+Arrays.toString(a));
//		for(String a1:a) {
//		
//		
//		System.out.println("s6.split(\" \") :"+a1);}
		
		System.out.println("s6.startswith(\"he\") :"+s6.startsWith("he"));
		
		System.out.println("s5.endswith(\"..\") :"+s5.endsWith(".."));
		
		String[]a2;
		
		a2=s7.split(",");
		
		System.out.println("s7.split(\" \") :"+Arrays.toString(a2));
		
		String a3=String.join(":", a2);
		
		System.out.println("String a3=String.join(\":\", a2) : a3="+a3);

		StringBuffer sb = new StringBuffer("Hello");
		
		System.out.println("String Buffer :"+sb);
		
		sb.append("CDAC");
		System.out.println("String Buffer after append :"+sb);

		
		StringBuilder sbd = new StringBuilder("test");
		
		System.out.println("String Builder :"+sbd);
		
		sbd.append("Fail");
		System.out.println("String Builder aftre append :"+sbd);

	}

}
