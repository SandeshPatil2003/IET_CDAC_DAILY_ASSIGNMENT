package com.studentregistration.dao;

import com.studentregistration.beans.Student;

public interface LoginDao {

	Student validateUser(String username, String password);

}
