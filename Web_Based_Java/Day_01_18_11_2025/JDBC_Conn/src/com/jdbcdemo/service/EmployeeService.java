package com.jdbcdemo.service;

import java.sql.ResultSet;
import java.util.Scanner;

public interface EmployeeService {

	boolean addEmployee(Scanner sc);

	boolean updateSalary(int id, double newSal);

	boolean deleteById(int id);

	ResultSet displayEmp(int id);

	ResultSet callProcedure();

}
