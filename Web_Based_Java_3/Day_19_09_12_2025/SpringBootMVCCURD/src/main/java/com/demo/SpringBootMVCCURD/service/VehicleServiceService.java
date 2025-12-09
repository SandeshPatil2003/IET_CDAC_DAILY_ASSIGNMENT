package com.demo.SpringBootMVCCURD.service;

import java.util.List;

import com.demo.SpringBootMVCCURD.beans.VehicleServices;

public interface VehicleServiceService {

	List<VehicleServices> getAllService();

	VehicleServices getServiceById(int sid);

}
