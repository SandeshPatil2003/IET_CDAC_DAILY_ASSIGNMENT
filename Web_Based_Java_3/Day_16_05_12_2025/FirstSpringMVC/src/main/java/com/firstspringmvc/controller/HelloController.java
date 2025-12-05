package com.firstspringmvc.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class HelloController {
	
	@GetMapping("/hello")
	public String sayHello() {
		
		return "hello";
	}
	
	
	@GetMapping("/welcome")
	public ModelAndView sayWelcome()
	{
		String msg="Welcome message from john cena";
		
		return new ModelAndView("welcome","message",msg);
	}
	
	@GetMapping("/test")
	public String testdata(Model mymodel) {
		
		mymodel.addAttribute("name","John Cena");
		mymodel.addAttribute("email","johncena@gmail.com");
		
		return "testdata";
	}
	
}
