package com.demo.dao;

import java.util.List;

import com.demo.beans.Student;

public interface StudentDao {

	boolean save(Student student);

	List<Student> showAll();

}
