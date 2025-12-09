package com.demo.SpringBootMVCCURD.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.servlet.ModelAndView;

import com.demo.SpringBootMVCCURD.beans.User;
import com.demo.SpringBootMVCCURD.dao.ProfileDao;

@Service
public class ProfileServiceImpl implements ProfileService{
	
	@Autowired
	ProfileDao pdao;

	@Override
	public User updateProfile(User user) {
		
		Optional<User> opu = pdao.findById(user.getUid());
		
		if(opu.isPresent()) {
		User u = opu.get();
		
		u.setDob(user.getDob());
		u.setEmail(user.getEmail());
		
		return pdao.save(u);
		
		//return new ModelAndView("redirect:/profile/editprofile","message","Tu update ho gaya bhai!");
		}
		return null;
		
		//return new ModelAndView("redirect:/profile/editprofile","message","Tu exist nahi karta be");
	}

}
