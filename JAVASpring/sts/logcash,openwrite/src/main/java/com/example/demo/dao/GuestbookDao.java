package com.example.demo.dao;


import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.stereotype.Repository;

import com.example.demo.dto.Geustbook;
import com.example.demo.repositoty.GuestbookRepository;

@Repository
public class GuestbookDao {

	@Autowired
	private GuestbookRepository guestbookRepository;
	
	public Geustbook putGuestbook(Geustbook guestbook) {
		return guestbookRepository.saveAndFlush(guestbook);
	}
	
	public List<Geustbook> getGuestbooks(){
		return guestbookRepository.findAll();
	}
	
	public List<Geustbook> getGuestbooksSome(Integer page, Integer limit){
		Pageable pageable = PageRequest.of(page, limit,Sort.by("id").descending());
		return guestbookRepository.findAll(pageable).getContent();
//		PageRequest pageRequest=PageRequest.of(page, limit);  // 한페이지에 최대 몇개의 자료를 불러올것인가 지정(자동으로 연결)
//		List<Geustbook> guestbooks = new ArrayList<>();
//		guestbookRepository.findAll(pageRequest).forEach(g->guestbooks.add(g));
//		return guestbooks;
	
	}
	
	public Long getGuestbookSize() {
		return guestbookRepository.count();
	}
	
	public void deleteGuestbook(Long id) {
		guestbookRepository.deleteById(id);
	}
}
