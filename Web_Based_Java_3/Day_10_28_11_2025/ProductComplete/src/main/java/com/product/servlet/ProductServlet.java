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
import java.util.ArrayList;
import java.util.List;

import com.product.beans.*;
import com.product.service.ProductService;
import com.product.service.ProductServiceImpl;


public class ProductServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	

		PrintWriter out = response.getWriter();
		
		ProductService pservice = new ProductServiceImpl();
		
		
		HttpSession session = request.getSession();
		
		String selectedcat = request.getParameter("categoryDropdown");
		
		
		User user = (User) session.getAttribute("customer");
		
		if(user!=null) {

			List<Product> plist  = pservice.fetchProductsByCat(selectedcat);
		     
		     session.setAttribute("plist", plist);
		     
		     
			RequestDispatcher rd = request.getRequestDispatcher("Product.jsp");
			rd.forward(request, response);	
			
			
		}
		else {
			out.println("Invalid credentials, Try again");
			RequestDispatcher rd = request.getRequestDispatcher("Login.html");
			rd.include(request, response);	
		}
		
		
		
		
		
	}

}
