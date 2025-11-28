package com.product.service;

import com.product.beans.User;

public interface LoginService {

	User validateUser(String uname, String pass);

	boolean registerUser(String user, String email, String pass);

}
