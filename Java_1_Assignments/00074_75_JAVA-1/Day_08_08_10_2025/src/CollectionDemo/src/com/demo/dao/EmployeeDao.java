package CollectionDemo.src.com.demo.dao;

import java.util.List;

import CollectionDemo.src.com.demo.beans.Employee;

public interface EmployeeDao {

	boolean save(Employee e);

	List<Employee> findAll();

	Employee findById(int eid);

	boolean removeById(int eid);

	List<Employee> findByName(String nm);

}
