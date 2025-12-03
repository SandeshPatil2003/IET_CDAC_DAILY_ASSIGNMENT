package com.crud.service;

import java.util.List;

import com.crud.beans.Employee;

public interface EmployeeService {

	boolean addEmp(Employee e);

	List<Employee> getAllEmployees();

}
