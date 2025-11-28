package com.product.dao;

import java.util.List;

import com.product.beans.Product;

public interface ProductDao {

	List<String> getAllCategory();

	List<Product> fetchProductBycat(String selectedcat);

}
