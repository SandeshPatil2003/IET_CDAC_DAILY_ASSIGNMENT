package com.demo.SpringBootMVCCURD.service;

import java.time.LocalDate;

import com.demo.SpringBootMVCCURD.beans.Booking;
import com.demo.SpringBootMVCCURD.beans.User;
import com.demo.SpringBootMVCCURD.beans.VehicleServices;

public interface BookingService {

	Booking createBooking(User user, VehicleServices vehicleServices, LocalDate date);

}
