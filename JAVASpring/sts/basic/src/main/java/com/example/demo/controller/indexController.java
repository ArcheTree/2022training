package com.example.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class indexController {

	@GetMapping(path="/")  //path에 "/" 로 기입하면 최상위 주소로 연결
	public String getIndex() {
//		System.out.println("/주소 요청 됨");
		return "index"; //index로 리턴할경우 조건에 맞는 인덱스를 찾음
	}
}
