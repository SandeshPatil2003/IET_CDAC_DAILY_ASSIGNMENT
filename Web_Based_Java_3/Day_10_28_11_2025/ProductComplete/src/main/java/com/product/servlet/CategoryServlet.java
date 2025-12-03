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
import java.util.List;

import com.product.beans.User;
import com.product.service.LoginService;
import com.product.service.LoginServiceImpl;
import com.product.service.*;


public class CategoryServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;


	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
	
response.setContentType("text/html");
		
		PrintWriter out = response.getWriter();
		
		ProductService pservice = new ProductServiceImpl();
		
		
		HttpSession session = request.getSession();
		
		User user = (User) session.getAttribute("customer");
		
		if(user!=null) {
			
			List<String> clist = pservice.getAllCategory();
			
			session.setAttribute("clist", clist);
			
			//request.setAttribute("clist", clist);
			
			RequestDispatcher rd = request.getRequestDispatcher("Category.jsp");
			rd.forward(request, response);	
			
			
		}
		else {
			out.println("Invalid credentials, Try again");
			RequestDispatcher rd = request.getRequestDispatcher("Login.html");
			rd.include(request, response);	
		}
		
		
	}

}
