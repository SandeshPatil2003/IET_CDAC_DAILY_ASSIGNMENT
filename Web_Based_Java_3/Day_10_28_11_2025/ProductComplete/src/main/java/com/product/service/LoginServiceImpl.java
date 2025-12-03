package com.product.service;

import com.product.beans.User;
import com.product.dao.*;


public class LoginServiceImpl implements LoginService{

		LoginDao ldao = new LoginDaoImpl();
	@Override
	public User validateUser(String uname, String pass) {
		
		return ldao.validateUser(uname,pass);
	}
	@Override
	public boolean registerUser(String user, String email, String pass) {
	
		return ldao.registerUser(user,email,pass);
	}

}
