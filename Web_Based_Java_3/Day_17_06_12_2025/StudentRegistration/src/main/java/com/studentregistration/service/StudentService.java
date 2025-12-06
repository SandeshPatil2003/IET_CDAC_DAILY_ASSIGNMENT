package com.studentregistration.service;

import java.util.List;

import com.studentregistration.beans.Student;

public interface StudentService {

	List<Student> getAllStudent();

	boolean insertStudent(Student s1);

	Student getById(int s1);

	boolean updateStudent(Student s1);

	boolean deleteById(int sid);

}
