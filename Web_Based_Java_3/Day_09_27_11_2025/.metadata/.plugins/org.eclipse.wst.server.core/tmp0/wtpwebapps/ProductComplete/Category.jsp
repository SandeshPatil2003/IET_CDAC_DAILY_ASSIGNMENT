<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
    <%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<form action="products" method="post">
	
	
	<select name="categoryDropdown" id="categoryDropdown">
	
	<c:forEach var="c" items="${clist}">
	  <option value="${c}">${c}</option>
	
	  	</c:forEach>
	</select>
	
	<button type="submit">Show products</button>
	</form>

</body>
</html>