package com.demo.SpringBootMVCCURD.dao;

import org.springframework.data.jpa.repository.JpaRepository;

import com.demo.SpringBootMVCCURD.beans.Booking;

public interface BookingDao  extends JpaRepository<Booking, Integer>{

}
