package com.jdbcdemo.dao;

import java.sql.ResultSet;

import com.jdbcdemo.beans.Employee;

public interface EmployeeDao {

	boolean save(Employee e);

	boolean updateSal(int id, double newSal);

	boolean deleteById(int id);

	ResultSet getEmpById(int id);

	ResultSet callProcedure();

}
