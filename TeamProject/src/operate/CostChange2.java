package operate;


import java.time.DayOfWeek;
import java.time.LocalDate;

import dto.HotelVO;


public class CostChange2 {
	
	;
	//요일 숫자 변환 
	
	public double cost;  //임시지정 < 가격은 다른 곳에서 가져오도록 하기

	//주말 추가요금	
	public void plusecost(LocalDate date) {
		DayOfWeek dayOfWeek=date.getDayOfWeek();
		int WeekNumber=dayOfWeek.getValue();
		if(WeekNumber==5||WeekNumber==6){
			cost= cost*1.25;
		}
		 if(date.getMonthValue()==7||date.getMonthValue()==12) {			
			 if(date.getDayOfMonth()>14) {
				 cost=cost*1.5;
			 }else {
				
			 }
		 }else if(date.getMonthValue()==8 || date.getMonthValue()==9 ||date.getMonthValue()==1||date.getMonthValue()==2){
			 cost=cost*1.5;
		 }else {
		
		 }
	}
	
	
	public double totalCost(HotelVO hotelVO) {
			
		LocalDate bookday=LocalDate.of(hotelVO.getYear(), hotelVO.getMonth(), hotelVO.getDay());//<예약일 들어가게 하기
		for(int i=0; i<hotelVO.getNight();i++) {

			if(hotelVO.getRoom().equals("싱글")) {
				cost = 700000;           
			}else if(hotelVO.getRoom().equals("더블")) {
				cost = 100000;        
			}else if(hotelVO.getRoom().equals("트윈")) {
				cost = 120000;           
			}else if(hotelVO.getRoom().equals("스위트")) {
				cost = 300000;           
			}
			bookday=bookday.plusDays(i);
			plusecost(bookday);
//			cost+=cost;
			}
		System.out.println("결제금 : "+(int) cost+"원");
		return cost;

		}
//	public static void main(String[] args) {
//		for(int n=0;n<1;n++){
//			
//			System.out.println(n);
//		}
	




}
		
	

	
	
	



