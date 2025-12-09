package com.demo.SpringBootMVCCURD.dao;

import org.springframework.data.jpa.repository.JpaRepository;

import com.demo.SpringBootMVCCURD.beans.VehicleServices;

public interface VehicleServiceDao extends JpaRepository<VehicleServices, Integer>{

}
