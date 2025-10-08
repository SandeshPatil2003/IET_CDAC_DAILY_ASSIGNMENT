package CollectionDemo.src.com.demo.service;
import CollectionDemo.src.com.demo.beans.*;

import java.util.List;

//import com.demo.beans.Employee;

public interface EmployeeService {

	boolean addNewEmployee();

	List<Employee> displayAll();

	Employee searchById(int eid);

	boolean deleteById(int eid);

	List<Employee> findByName(String nm);

}
