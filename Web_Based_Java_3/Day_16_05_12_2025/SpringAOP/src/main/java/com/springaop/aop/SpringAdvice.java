package com.springaop.aop;

import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.After;
import org.aspectj.lang.annotation.Around;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.springframework.stereotype.Component;

@Component
@Aspect
public class SpringAdvice {
	
	@Before("execution (* com.springaop.beans.M*.m*(..))")
	
	
	public void beforeAdvice() {
		
		
		System.out.println("in  Before Advice");
		
		
	}
	
	@After("execution (* com.springaop.beans.M*.m*(..))")
	public void afterAdvice() {
		
		
		System.out.println("in After Advice");
	}
	
	
	@Around("execution (* com.springaop.beans.M*.m*(..))")
	public Object aroundadvice(ProceedingJoinPoint jpoint) throws Throwable {
		
		
		System.out.println("in Around Advice before Function call");
		
		Object ob=jpoint.proceed(); 
		
		System.out.println("in Around Advice after Function call");
		
		return ob;
		
	}

}
