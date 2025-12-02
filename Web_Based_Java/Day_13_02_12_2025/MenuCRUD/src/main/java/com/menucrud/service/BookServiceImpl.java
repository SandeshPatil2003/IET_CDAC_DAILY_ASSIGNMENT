package com.menucrud.service;

import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.HashSet;
import java.util.List;
import java.util.Scanner;
import java.util.Set;

import com.menucrud.beans.Author;
import com.menucrud.beans.Book;
import com.menucrud.dao.BookDao;
import com.menucrud.dao.BookDaoImpl;

public class BookServiceImpl implements BookService {

	AuthorService aservice = new AuthorServiceImpl();
	BookDao bdao = new BookDaoImpl();


	@Override
	public boolean addBook(Scanner sc) {
		
		System.out.println("Enter book name :");
		String bname = sc.next();
		
		System.out.println("Enter price of book :");
		double price = sc.nextDouble();
		
		System.out.println("Enter publish date as (dd/mm/yyyy)");
		String date = sc.next();
		
		DateTimeFormatter dt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
		
		LocalDate ld = LocalDate.parse(date,dt);
		
		Book b = new Book(bname,price,ld);
		
		
		char ch ='y';
		Set<Author> aset = new HashSet<>();
		Set<Book> bset = new HashSet<>();
		
		bset.add(b);
		Author a = null;
		
		do {
			
			System.out.println("Enter Author id to add author : ");
			int id = sc.nextInt();
			
			 a =  aservice.getAuthorById(id);
			
			if(a!=null) {
				aset.add(a);
				a.setBset(bset);
			}
			else {
				
				System.out.println("Author doesnt exist,  add author ");
				//char c = sc.next().charAt(0);
				
				//if(c == 'y' ||c=='Y') {
					
				//boolean status = aservice.addAuthor();
				
				 a = aservice.addAuthor();
				
				if(a!=null) {
					System.out.println("Author added successfully.");
						aset.add(a);
						a.setBset(bset);
				}
				else {
					System.out.println("author not added");
				}
				//}
				//else {
					
			//	}
			
			}

			//sc.nextLine();
			System.out.println("Do you want to add another author (y/n)");
			ch = sc.next().charAt(0);
			
		}while(ch=='y'||ch=='Y');
		
		b.setAset(aset);
		
		
		
		return bdao.saveBook(b);
	}


	@Override
	public boolean updateBookPrice(int bid, double newprice) {
		// TODO Auto-generated method stub
		return bdao.updateBookPrice(bid,newprice);
	}


	@Override
	public List<Book> getAllBooks() {
		
		return bdao.getAllBooks();
	}
}
