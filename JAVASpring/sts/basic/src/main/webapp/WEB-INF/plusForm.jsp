<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>plusForm.jsp</title>
</head>
<body>
<!-- 자바스크립트전에 사용하던방식 // tomcat 거치지 않으면 브라우저에 함수 그대로 뜸-->
	<!-- 
	get -주소창에 데이터가 노출(대놓고)
	post - 주소창에 데이터 노출 안됨(하지만 확인방법은 존재-온라인 패킷을 통해 전달되기에 그 패킷에서 확인가능-패킷보호를 위해'https'를 사용)
	  -->
	<!--  form method="get" action ="plus"-->
	<form method="post" action ="plus">
		value1:<input type="text" name="value1" autocomplete="off"><br />
		value2:<input type="text" name="value2" autocomplete="off"><br />
		<input type="submit" value="확인">
	</form>
<div>
<a href="/">Home</a>
</div>

</body>
</html>