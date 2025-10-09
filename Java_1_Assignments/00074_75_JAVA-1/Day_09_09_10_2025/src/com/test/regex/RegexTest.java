package com.test.regex;

public class RegexTest {

	public static void main(String[] args) {
		
		
		String awords = "Alligators aggressively advanced, approaching, and, almost always, appearing at alarming angles.";
		
		System.out.println(awords.matches(".*a.*"));
		System.out.println(awords.matches("^A.*"));
		System.out.println(awords.matches(".*es.$"));
		
		
		
	}

}
