package operate;


import java.time.DayOfWeek;
import java.time.LocalDate;

import dto.HotelVO;


public class CostChange {
	
	//요일 숫자 변환 
	
	public double cost=0;  //임시지정 < 가격은 다른 곳에서 가져오도록 하기

	//주말 추가요금	
	public int weekendcost(LocalDate date) {
		DayOfWeek dayOfWeek=date.getDayOfWeek();
		int WeekNumber=dayOfWeek.getValue();
		if(WeekNumber==5||WeekNumber==6){
	 cost= cost*1.25;
		}
		return (int) cost;
	}
	//성수기 추가요금
	
	public int vacation(LocalDate date) {
				
		if(date.getMonthValue()==7||date.getMonthValue()==12) {			
			if(date.getDayOfMonth()>14) {
				cost=cost*1.5;
			}
		}else if(date.getMonthValue()==8 || date.getMonthValue()==9 ||date.getMonthValue()==1||date.getMonthValue()==2){
			cost=cost*1.5;
		}return (int) cost;
		
	}

	
	
	public double totalCost(HotelVO hotelVO) {
			
		LocalDate bookday=LocalDate.of(hotelVO.getYear(), hotelVO.getMonth(), hotelVO.getDay());//<예약일 들어가게 하기
	
			if(hotelVO.getRoom().equals("싱글")) {
				cost = 700000;           
			}else if(hotelVO.getRoom().equals("더블")) {
				cost = 100000;        
			}else if(hotelVO.getRoom().equals("트윈")) {
				cost = 120000;           
			}else if(hotelVO.getRoom().equals("스위트")) {
				cost = 300000;           
			}
	
			weekendcost(bookday);
			vacation(bookday);

		System.out.println("결제금 : "+(int) cost+"원");
		return cost;

		}
	
		
	

	
	
	
}