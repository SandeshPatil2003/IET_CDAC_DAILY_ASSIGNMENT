package com.demo.service;

import java.util.List;
import java.util.Scanner;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.demo.beans.Student;
import com.demo.dao.StudentDao;

@Service
public class StudentServiceImpl implements StudentService {
	
	
	@Autowired
	StudentDao sdao;

	@Override
	public boolean addStudent(Scanner sc) {
		
		System.out.println("Enter student id");
		int sid=sc.nextInt();
		
		System.out.println("Enter student name");
		String sname=sc.next();
		
		System.out.println("Enter student rollno");
		int rollno=sc.nextInt();
		
		System.out.println("Enter student course");
		String course=sc.next();
		
		return sdao.save(new Student(sid,sname,rollno,course));
		
		
		
		
		
	}

	@Override
	public List<Student> displayALL() {
		
		return sdao.showAll();
	}

	@Override
	public Student getStudentbyId(int sid) {
		
		return sdao.getStudentById(sid);
	}

	@Override
	public boolean deleteStudentbyId(int sid) {
		
		
		
		return sdao.removeById(sid);
	}

	@Override
	public boolean updateStudentById(int sid, String course, int rollno) {
		
		
		return sdao.updateStudentById(sid,course,rollno);
	}

	@Override
	public List<Student> displayAscRoll() {
		
		
		
		return sdao.displayAscRoll();
	}

	

}
