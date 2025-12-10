package com.movies.movies.service;

import com.movies.movies.beans.User;

public interface LoginService {

	User validateUser(String uname, String password);

}
