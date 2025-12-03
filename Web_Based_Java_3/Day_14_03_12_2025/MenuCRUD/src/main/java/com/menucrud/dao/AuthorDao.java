package com.menucrud.dao;

import com.menucrud.beans.Author;

public interface AuthorDao {

	Author getAuthorById(int id);

	Author saveAuthor(Author a);

}
