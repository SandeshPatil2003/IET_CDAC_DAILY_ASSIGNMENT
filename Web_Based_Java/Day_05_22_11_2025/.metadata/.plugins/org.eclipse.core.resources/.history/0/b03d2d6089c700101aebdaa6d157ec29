package com.crud.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.time.LocalDate;

import java.time.format.DateTimeFormatter;

import com.crud.service.EmployeeService;
import com.crud.service.EmployeeServiceImpl;
import com.crud.service.LoginService;
import com.crud.service.LoginServiceImpl;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import com.crud.beans.*;


@WebServlet("/add")
public class AddEmployee extends HttpServlet {
	private static final long serialVersionUID = 1L;

  
  
	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType("text/html");
		
		PrintWriter out = response.getWriter();
		
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy");
		int empid= Integer.parseInt(request.getParameter("empid"));
		String ename= request.getParameter("ename");
		double sal= Double.parseDouble(request.getParameter("sal"));
		
		LocalDate ldt = LocalDate.parse(request.getParameter("hdate"),formatter);
		
		Employee e = new Employee(empid,ename,sal,ldt);
		
		
		EmployeeService lservice = new EmployeeServiceImpl();
		
		boolean status = lservice.addEmp(e);
		
		
		
		
		
	}

}
