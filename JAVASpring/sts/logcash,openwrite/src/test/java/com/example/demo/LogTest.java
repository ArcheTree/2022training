package com.example.demo;

import static org.assertj.core.api.Assertions.assertThat;


import java.util.Date;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import com.example.demo.dao.LogDao;
import com.example.demo.dto.Log;

@SpringBootTest
public class LogTest {
	
	@Autowired
	LogDao logDao;
	
	@Test
	void testLog() {
		Log log=new Log();
		log.setIp("Test ip");
		log.setMethod("set");
		log.setRegdate(new Date());
		Log savedLog=logDao.putLog(log);
		Log savedLog2=new Log();		
		assertThat(log).isEqualTo(savedLog2);  //비교하는것 jUnit에서 확인 가능 하지만 자료는 DB에 입력됨
	}

}
