------------ <실습2> ------------

CREATE USER sqlDB IDENTIFIED BY 1234 -- 사용자 이름: sqlDB, 비밀번호 : 1234
   DEFAULT TABLESPACE USERS
   TEMPORARY TABLESPACE TEMP;
   
GRANT connect, resource, dba TO sqlDB ;