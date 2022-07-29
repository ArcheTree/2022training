package com.example.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.example.demo.dto.User;

@Controller
public class userController {
	@RequestMapping(				//RequestMapping은 get이든 post 든 다 받아버림
			path={"/userform", "/u"}, method=RequestMethod.GET)
	public String userform() {
		return "userform";
	}
	@RequestMapping(				//RequestMapping은 get이든 post 든 다 받아버림
			path={"/regist"}, method=RequestMethod.POST)
	public String regist(@ModelAttribute User user, ModelMap model) {
//		System.out.println(user);
		model.addAttribute("user",user);
		return "regist";
	}
}
