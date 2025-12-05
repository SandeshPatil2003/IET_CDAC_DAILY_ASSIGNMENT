package com.demo.beans;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component("student1")
public class Student {

    @Value("${stud.id}")
    private int id;

    @Value("${stud.name}")
    private String name;

    @Value("${stud.branch}")
    private String branch;

    @Autowired
    private Address address;

    public Student() {
        super();
    }

    public Student(int id, String name, String branch, Address address) {
        this.id = id;
        this.name = name;
        this.branch = branch;
        this.address = address;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getBranch() {
        return branch;
    }

    public void setBranch(String branch) {
        this.branch = branch;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }

    @Override
    public String toString() {
        return "Student [id=" + id + ", name=" + name + ", branch=" + branch + ", address=" + address + "]";
    }
}
