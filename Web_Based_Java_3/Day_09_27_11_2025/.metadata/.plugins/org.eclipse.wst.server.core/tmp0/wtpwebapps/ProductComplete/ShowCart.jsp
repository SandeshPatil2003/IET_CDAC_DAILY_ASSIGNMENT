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

	<c:set var="grandTotal" value="0" />  
 <table>
 <tr>
    <th>Pid</th>
    <th>Pname</th>
    <th>price</th>
    <th>Quantity</th>
    <th>Amount</th>
    </tr>
    
    <c:forEach var="p" items="${cart}">
     <form action="removeproduct" method="post">
	<tr>
    <td>${p.pid}</td>
    <td>${p.pname}</td>
    <td>${p.price}</td>
    <td>${p.qty}</td>
    <td>${p.qty*p.price}</td>
   
    <td>
    <input type="hidden" name="pid" value ="${p.pid}"/>
    <input type="hidden" name="pname" value ="${p.pname}"/>
    <input type="hidden" name="price" value ="${p.price}"/>
     <input type="hidden" name="category" value ="${p.category}"/>
     <c:set var="grandTotal" value="${grandTotal + (p.qty * p.price)}" />
    <input type="hidden" name="grandTotal" value ="${grandTotal}"/>
    </td>

   <td><button type="submit">remove</button></td>
    </tr>
    </form>
    
   
    </c:forEach>
    <td>${grandTotal}</td>
 </table>
 <form action="PlaceOrder.jsp" method="post">
  <input type="hidden" name="grandTotal" value ="${grandTotal}"/>
 <button type="submit">Place order</button>
 
 </form>
 

</body>
</html>