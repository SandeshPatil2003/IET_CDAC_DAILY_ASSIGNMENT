<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
${message}

<form action="validateuser" method="post">

UserName:<input type="text" id="uname" name="uname" />
<br />
Password:<input type="password" id="pass" name="pass" />
<br />
<button type="submit">Login</button>
</form>

<a href="register.jsp">SignUp</button>
</body>
</html>