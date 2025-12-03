package com.menucrud.service;

import java.util.List;
import java.util.Scanner;

import com.menucrud.beans.Book;

public interface BookService {

	boolean addBook(Scanner sc);

	boolean updateBookPrice(int bid, double newprice);

	List<Book> getAllBooks();

	List<Book> getSorted();

	boolean deleteBook(int bid);

}
