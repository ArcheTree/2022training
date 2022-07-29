package com.example.demo.sevice;

import java.util.List;

import com.example.demo.dto.Geustbook;

public interface GuestbookService {

	public static final Integer LIMIT = 5;
	
	public List<Geustbook> getGuestbooks(Integer page);
	
	public void deleteGuestbook(Long id, String ip);
	
	public Geustbook putGuestbook(Geustbook guestbook, String ip);
	
	public int getGuestbookSize();
	
}
