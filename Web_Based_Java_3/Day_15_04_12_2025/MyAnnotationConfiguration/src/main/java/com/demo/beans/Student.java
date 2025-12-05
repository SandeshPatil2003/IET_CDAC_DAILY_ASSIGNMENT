package com.demo.beans;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

@Component
public class Student {

    @Value("101")
    private int rollNo;

    @Value("Sandesh Patil")
    private String name;

    @Value("Information Technology")
    private String department;

    public Student() {
        super();
    }

    public Student(int rollNo, String name, String department) {
        super();
        this.rollNo = rollNo;
        this.name = name;
        this.department = department;
    }

    public int getRollNo() {
        return rollNo;
    }

    public void setRollNo(int rollNo) {
        this.rollNo = rollNo;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDepartment() {
        return department;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    @Override
    public String toString() {
        return "Student [rollNo=" + rollNo + ", name=" + name + ", department=" + department + "]";
    }
}

