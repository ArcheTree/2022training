package com.example.demo.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.demo.dto.Log;

public interface LogRepository extends JpaRepository<Log, Long>{  //이렇게 하면 SQL문 안써도 됨
	
}
