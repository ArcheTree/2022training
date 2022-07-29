<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %> 
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>방명록 목록 연습</title>
</head>
<body>
<h1>방문록</h1>
<br/>방명록 전체 수 : ${count }<br/><br/>

	<c:forEach items="${list }" var="g">
		${g.id }<br/>
		작성자 : ${g.name }<br/>
		콘텐츠 : ${g.content }<br/>
		등록일 : ${g.regdate }<br/><br/>
	</c:forEach>
	<br />
	<c:forEach items="${pagelist }" var="page">
	<a href = "list?page=${page }">${page+1 }</a>	
	</c:forEach>
	
</body>
</html>