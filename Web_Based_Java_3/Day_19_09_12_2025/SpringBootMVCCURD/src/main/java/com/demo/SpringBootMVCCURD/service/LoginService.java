package com.demo.SpringBootMVCCURD.service;

import com.demo.SpringBootMVCCURD.beans.User;

public interface LoginService {

	User validateUser(String email, String password);

}
