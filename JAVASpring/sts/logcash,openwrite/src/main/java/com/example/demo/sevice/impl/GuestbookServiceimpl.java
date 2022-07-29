package com.example.demo.sevice.impl;

import java.util.Date;
import java.util.List;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.example.demo.dao.GuestbookDao;
import com.example.demo.dao.LogDao;
import com.example.demo.dto.Geustbook;
import com.example.demo.dto.Log;
import com.example.demo.sevice.GuestbookService;

@Service
public class GuestbookServiceimpl implements GuestbookService {

	@Autowired
	GuestbookDao guestbookDao;
	
	@Autowired
	LogDao logDao;
	
	@Override
	public List<Geustbook> getGuestbooks(Integer page) {
		return guestbookDao.getGuestbooksSome(page,GuestbookService.LIMIT);
	}

	@Override
	@Transactional(readOnly=false) //일의 단위를 하나로 묶음 중간에 오류나면 다시 롤백함(실행전으로) -> 주석처리하면 삭제되고 오류떠서 로그기록은 안됨(오류전은 실행됨)
	public void deleteGuestbook(Long id, String ip) {
		guestbookDao.deleteGuestbook(id);
		//if(true) throw new RuntimeException();
		Log log=new Log();
		log.setIp(ip);
		log.setMethod("delete");
		log.setRegdate(new Date());
		logDao.putLog(log);
	}

	@Override
	@Transactional(readOnly=false)
	public Geustbook putGuestbook(Geustbook guestbook, String ip) {
		guestbook.setRegdate(new Date());
		Geustbook sGuestbook = guestbookDao.putGuestbook(guestbook);
		Log log=new Log();
		log.setIp(ip);
		log.setMethod("put");
		log.setRegdate(new Date());
		logDao.putLog(log);
		return sGuestbook;
	}

	@Override
	public int getGuestbookSize() {
		return guestbookDao.getGuestbookSize().intValue();
	}

}
