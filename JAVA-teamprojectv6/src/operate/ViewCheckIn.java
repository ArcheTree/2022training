package operate;

import java.time.LocalDate;
import java.util.InputMismatchException;
import java.util.Scanner;


public class ViewCheckIn {

	LocalDate ld=LocalDate.now();
		//체크인 날짜
	public void CheckInYear(int year) {
		//년도 문자열 예외처리		
		//현재 시간보다 과거 날짜 처리 불가
		if(ld.getYear()<=year){
			System.out.println(year+"년");		
			System.out.println("월을 선택해주세요");
		}else {
			System.out.println("예약할 수 없습니다.");
		}
			
	}
	public void CheckInMonth(int month) {
		//월 문자열 예외처리
		if(month<=12) {
			System.out.println(month+"월");
			System.out.println("일을 선택해주세요");
		}else {
			System.out.println("예약할 수 없습니다.");
		}
		
	}
	
	public void CheckInDay(int day) {
		//일 문자열 예외처리
		if(day<=31) {
			System.out.println(day+"일");
		}else {
			System.out.println("기간에 맞는 숫자를 선택해주세요");
		}
	}


}
