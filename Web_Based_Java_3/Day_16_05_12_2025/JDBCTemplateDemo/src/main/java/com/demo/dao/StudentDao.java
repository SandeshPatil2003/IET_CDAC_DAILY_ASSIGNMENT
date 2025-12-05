package com.demo.dao;

import java.util.List;

import com.demo.beans.Student;

public interface StudentDao {

	boolean save(Student student);

	List<Student> showAll();

	Student getStudentById(int sid);

	boolean removeById(int sid);

	boolean updateStudentById(int sid, String course, int rollno);

	List<Student> displayAscRoll();

}
