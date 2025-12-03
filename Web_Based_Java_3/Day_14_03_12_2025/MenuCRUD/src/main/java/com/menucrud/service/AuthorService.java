package com.menucrud.service;

import com.menucrud.beans.Author;

public interface AuthorService {

	Author getAuthorById(int id);

	Author addAuthor();

}
