package com.product.servlet;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

import java.io.IOException;
import java.io.PrintWriter;

import com.product.service.*;
import com.product.beans.*;


public class LoginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;


	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		response.setContentType("text/html");
		
		PrintWriter out = response.getWriter();
		
		String uname = request.getParameter("user");
		String pass = request.getParameter("pass");
		
		LoginService lservice = new LoginServiceImpl();
		
		User user = lservice.validateUser(uname,pass);
		
		HttpSession session = request.getSession();
		
		if(user!=null) {
			session.setAttribute("customer",user);
			
			RequestDispatcher rd = request.getRequestDispatcher("category");
			rd.forward(request, response);	
			
			
		}
		else {
			out.println("Invalid credentials, Try again");
			RequestDispatcher rd = request.getRequestDispatcher("Login.html");
			rd.include(request, response);	
		}
		
		
		
		
	}

}
