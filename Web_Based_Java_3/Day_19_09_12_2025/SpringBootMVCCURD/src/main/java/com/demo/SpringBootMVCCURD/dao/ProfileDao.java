package com.demo.SpringBootMVCCURD.dao;

import org.springframework.data.jpa.repository.JpaRepository;

import com.demo.SpringBootMVCCURD.beans.User;

public interface ProfileDao extends JpaRepository<User, Integer>{

}
