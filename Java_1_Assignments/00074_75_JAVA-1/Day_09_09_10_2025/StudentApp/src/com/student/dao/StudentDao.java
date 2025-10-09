package com.student.dao;

import java.util.List;

import com.student.beans.Student;

public interface StudentDao {

	boolean save(Student s);

	List<Student> getData();

	Student searchById(int id);

	boolean updateMark1(int id, double m1);

	boolean updateMark1_2(int id, double m1, double m2);

}
