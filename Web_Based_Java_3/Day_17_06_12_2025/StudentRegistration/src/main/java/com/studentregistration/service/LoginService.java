package com.studentregistration.service;

import org.springframework.stereotype.Service;

import com.studentregistration.beans.Student;


public interface LoginService {

	Student validateUser(String username, String password);

}
