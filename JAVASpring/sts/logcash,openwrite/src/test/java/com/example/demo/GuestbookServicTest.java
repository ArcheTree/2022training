package com.example.demo;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import com.example.demo.dto.Geustbook;
import com.example.demo.sevice.impl.GuestbookServiceimpl;

@SpringBootTest
public class GuestbookServicTest {
	@Autowired
	GuestbookServiceimpl guestbookServiceimpl;
	
	@Test  //자동으로 JUnit으로 실행시키는 어노테이션
	void testGetList() {
//		guestbookServiceimpl.getGuestbooks(0);
		for(Geustbook g:guestbookServiceimpl.getGuestbooks(0)) {
			System.out.println(g.toString());
		}
		
	}
//	@Test
//	void testDelete() {
//		guestbookServiceimpl.deleteGuestbook(32L, "test ip");
//	}
	
//	@Test
//	void testPut() {
//		Geustbook guestbook = new Geustbook();
//		guestbook.setName("GST name1");
//		guestbook.setContent("GST con1");
//		guestbookServiceimpl.putGuestbook(guestbook, "GST ip");
//	}
	
	@Test
	void testSize() {
		int count=guestbookServiceimpl.getGuestbookSize();
		System.out.println(count);
	}

}
