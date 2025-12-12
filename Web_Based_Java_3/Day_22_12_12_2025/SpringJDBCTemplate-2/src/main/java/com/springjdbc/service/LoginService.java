package com.springjdbc.service;

import com.springjdbc.beans.User;

public interface LoginService {

	User validateUser(String uname, String pass);

}
