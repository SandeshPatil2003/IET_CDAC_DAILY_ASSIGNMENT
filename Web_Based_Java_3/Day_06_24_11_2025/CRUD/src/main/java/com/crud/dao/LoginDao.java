package com.crud.dao;

import com.crud.beans.MyUser;

public interface LoginDao {

	boolean validateUser(String uname, String pass);

	boolean replacep(String uname, String oldp, String newp);

	boolean addUser(String uname, String pass);

	boolean registerUser(String name, String email, String gender, String hobbies, String city);

}
