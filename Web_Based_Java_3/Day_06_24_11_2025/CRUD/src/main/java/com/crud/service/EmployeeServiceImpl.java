package com.crud.service;

import java.util.List;

import com.crud.beans.Employee;
import com.crud.dao.EmployeeDao;
import com.crud.dao.EmployeeDaoImpl;

public class EmployeeServiceImpl implements EmployeeService {
	
	private EmployeeDao edao;

	public EmployeeServiceImpl() {
		super();
		this.edao = new EmployeeDaoImpl();
	}

	@Override
	public boolean addEmp(Employee e) {
		// TODO Auto-generated method stub
		return edao.saveEmp(e);
	}

	@Override
	public List<Employee> getAllEmployees() {
		// TODO Auto-generated method stub
		return edao.displayAll();
	}

	
	
	

}
