package com.demo.service;

import java.util.List;
import java.util.Scanner;

import com.demo.beans.Student;

public interface StudentService {

	boolean addStudent(Scanner sc);

	List<Student> displayALL();

	Student getStudentbyId(int sid);

	boolean deleteStudentbyId(int sid);

	boolean updateStudentById(int sid, String course, int rollno);

	List<Student> displayAscRoll();

}
