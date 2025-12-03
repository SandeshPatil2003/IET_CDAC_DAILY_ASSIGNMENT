package com.product.dao;

import com.product.beans.User;

public interface LoginDao {

	User validateUser(String uname, String pass);

	boolean registerUser(String user, String email, String pass);

}
