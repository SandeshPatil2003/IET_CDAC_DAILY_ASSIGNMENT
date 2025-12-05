package com.demo.beans;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

@Component
public class Address {

    @Value("${addr.house}")
    private String house;

    @Value("${addr.city}")
    private String city;

    @Value("${addr.state}")
    private String state;

    public Address() {
        super();
    }

    public Address(String house, String city, String state) {
        this.house = house;
        this.city = city;
        this.state = state;
    }

    public String getHouse() {
        return house;
    }

    public void setHouse(String house) {
        this.house = house;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getState() {
        return state;
    }

    public void setState(String state) {
        this.state = state;
    }

    @Override
    public String toString() {
        return "Address [house=" + house + ", city=" + city + ", state=" + state + "]";
    }
}
