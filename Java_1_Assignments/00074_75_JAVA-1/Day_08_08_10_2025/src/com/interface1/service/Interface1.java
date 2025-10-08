package com.interface1.service;

public interface Interface1 {
	
	  int a =4;
	  int b=6;
	  
	  void m1();
	  
	   default int f1()
	  {
		  int c=9;
		  return c;
	  };
	

}
