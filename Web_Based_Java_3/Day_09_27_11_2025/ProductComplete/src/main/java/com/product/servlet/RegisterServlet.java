package com.product.servlet;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

import com.product.service.LoginService;
import com.product.service.LoginServiceImpl;

/**
 * Servlet implementation class RegisterServlet
 */
public class RegisterServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
	//	doGet(request, response);
		
		response.setContentType("text/html");
		
		PrintWriter out = response.getWriter();
		
		String user = request.getParameter("user");
		String email = request.getParameter("email");
		String pass = request.getParameter("pass");
		
		LoginService lservice = new LoginServiceImpl();
		
		boolean status = lservice.registerUser(user,email,pass);
		
		if(status) {
			out.println("Registration successful try login,");
			
			
			RequestDispatcher rd = request.getRequestDispatcher("Login.html");
			rd.include(request, response);	
			
		}
		else{
			out.println("Registration unsuccessful try again,");
			RequestDispatcher rd = request.getRequestDispatcher("Register.html");
			rd.include(request, response);	
		}
		
		
		
	}

}
