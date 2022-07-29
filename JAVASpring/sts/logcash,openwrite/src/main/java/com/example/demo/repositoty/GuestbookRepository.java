package com.example.demo.repositoty;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.demo.dto.Geustbook;

public interface GuestbookRepository extends JpaRepository<Geustbook, Long> {

}
