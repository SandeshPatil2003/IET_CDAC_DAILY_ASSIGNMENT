<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

<h3>${message}</h3>
<form action="validate" method="post">
Email : <input type="email" id="email" name="email" />
Password : <input type="password" id="password" name="password" />

<button type="submit">Login</button>

<a href="register.jsp">SignUp</a>


</form>
</body>
</html>