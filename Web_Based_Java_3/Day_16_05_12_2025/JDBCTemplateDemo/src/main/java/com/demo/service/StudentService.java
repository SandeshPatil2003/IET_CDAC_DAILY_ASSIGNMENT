package com.demo.service;

import java.util.List;
import java.util.Scanner;

import com.demo.beans.Student;

public interface StudentService {

	boolean addStudent(Scanner sc);

	List<Student> displayALL();

}
