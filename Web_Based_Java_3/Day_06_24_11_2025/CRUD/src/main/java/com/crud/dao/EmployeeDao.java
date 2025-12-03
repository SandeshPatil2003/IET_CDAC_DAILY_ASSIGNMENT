package com.crud.dao;

import java.util.List;

import com.crud.beans.Employee;

public interface EmployeeDao {

	boolean saveEmp(Employee e);

	List<Employee> displayAll();

}
