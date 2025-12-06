<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Edit Form</title>
</head>
<body>
<h3>Edit Form</h3>

<form action="updatestudent" method="post">

Id:<input type="text" name="sid" id="s01" value=${s1.sid} readonly > <br>
Name:<input type="text" name="sname" id="s02" value=${s1.sname} > <br>
Date of Birth:<input type="text" name="dob" id="s03" value=${s1.dob} readonly> <br>
Email:<input type="text" name="email" id="s04" value=${s1.email} > <br>
Username:<input type="text" name="username" id="s05" value=${s1.username} > <br>

<button type="submit">Enter</button>
</form>
</body>
</html>