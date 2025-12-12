package com.springjdbc.service;

import java.util.List;

import com.springjdbc.beans.Product;

public interface ProductService {

	List<Product> showAll();

	Product findById(int pid);

	boolean update(Product product);

	boolean delete(int pid);

}
