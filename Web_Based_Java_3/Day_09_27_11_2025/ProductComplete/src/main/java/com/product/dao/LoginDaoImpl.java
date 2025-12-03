package com.product.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.product.beans.User;

public class LoginDaoImpl implements LoginDao{
	
	static Connection conn = null;
	
	static {
		conn = DBUtil.getMyConnection();
	}

	@Override
	public User validateUser(String uname, String pass) {
		
		try {
			PreparedStatement valuser = conn.prepareStatement("Select username, email from productusers where username =? and password = ?");
			
			valuser.setString(1, uname);
			valuser.setString(2, pass);
			
			ResultSet rs = valuser.executeQuery();
			
			if(rs.next()) {
				User user = new User(rs.getString(1),rs.getString(2));
				return user;
			}
		
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	
	
	
	@Override
	public boolean registerUser(String user, String email, String pass) {
		
		
		try {
			PreparedStatement reguser = conn.prepareStatement("INSERT INTO productusers values(default,?,?,?)");
			
				
			reguser.setString(1, user);
			reguser.setString(2, email);
			reguser.setString(3, pass);
			
			int n = reguser.executeUpdate();
			
			return n>0;
		
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return false;
	}

}
