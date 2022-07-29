package com.example.demo.dto;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Geustbook {
	
	@Id    //이게... 아마 PK지정?
	@GeneratedValue(strategy = GenerationType.AUTO)  //자동으로 숫자 늘려가며 id 부여(시퀀스인듯)
	private Long id;
	
	private String name;
	private String content;
	private Date regdate;
	
	public Long getId() {
		return id;
	}
	public void setId(Long id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getContent() {
		return content;
	}
	public void setContent(String content) {
		this.content = content;
	}
	public Date getRegdate() {
		return regdate;
	}
	public void setRegdate(Date regdate) {
		this.regdate = regdate;
	}
	
	@Override
	public String toString() {
		return "Geustbook [id=" + id + ", name=" + name + ", content=" + content + ", regdate=" + regdate + "]";
	}
	
	
}
