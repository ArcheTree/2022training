package com.example.demo;

import static org.assertj.core.api.Assertions.assertThat;

import java.util.Date;
import java.util.List;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import com.example.demo.dao.GuestbookDao;
import com.example.demo.dto.Geustbook;

@SpringBootTest
public class GuestbookTest {
	
	@Autowired
	GuestbookDao guestbookDao;
	
	@Test
	void testGuestbookDao() {
		//guestbook dao put test -자료입력 TEST
//		Geustbook guestbook=new Geustbook();
//		guestbook.setContent("test contented");
//		guestbook.setName("F");
//		guestbook.setRegdate(new Date());
//		guestbookDao.putGuestbook(guestbook);
		
		//guestbook table all search
//		for(Geustbook gb:guestbookDao.getGuestbooks()) {
//			System.out.println(gb);
//		}
		
		//자료 대량 입력
//		for(int i =0;i<30;i++) {
//			Geustbook guestbook=new Geustbook();
//			guestbook.setContent("test contented"+i);
//			guestbook.setName("F"+i);
//			guestbook.setRegdate(new Date());
//			guestbookDao.putGuestbook(guestbook);
//		}
		
		//자료 제한하여 출력(갯수로 나눈page,갯수)
		for(Geustbook gb:guestbookDao.getGuestbooksSome(2,5)) {
			System.out.println(gb);
		}
		// 총 갯수 확인
//		List<Geustbook> guestbooks=guestbookDao.getGuestbooks();
//		Long totalSize=guestbookDao.getGuestbookSize();
//		System.out.println("totalSize : "+totalSize);
//		System.out.println(guestbooks.size());
//		assertThat(guestbooks.size()).isEqualTo(totalSize.longValue());
		
//		Long totalSize=guestbookDao.getGuestbookSize();
//		Long totalSize2=guestbookDao.getGuestbookSize();
//		guestbookDao.deleteGuestbook(31L);
//		assertThat(totalSize).isEqualTo(totalSize2.longValue());
	}
	

}
