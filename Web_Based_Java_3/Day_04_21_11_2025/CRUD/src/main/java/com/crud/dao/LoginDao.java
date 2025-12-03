package com.crud.dao;

import com.crud.beans.MyUser;

public interface LoginDao {

	boolean validateUser(String uname, String pass);

}
