package operate;


import java.time.DayOfWeek;
import java.time.LocalDate;




public class CostChange {
	//요일 숫자 변환 
	private LocalDate today=LocalDate.of(2022, 8, 05);  //날짜에 예약일 넣기
	private DayOfWeek dayOfWeek=today.getDayOfWeek();
	private int WeekNumber=dayOfWeek.getValue();
		
	public static double cost = 100000;  //임시지정 < 가격은 다른 곳에서 가져오도록 하기

	 //주말추가 요금	
	public int weekendcost() {
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

	public static void main(String[] args) {  //메일 말고 다른거해서 넘어가도록 지정
	CostChange cc=new CostChange();
	LocalDate bookday=LocalDate.of(22, 8, 06);//<예약일 들어가게 하기
	System.out.println(cc.WeekNumber);
	System.out.println(cc.today);
	
	
	cc.weekendcost();
	cc.vacation(bookday);
	System.out.println("결제금 : "+(int) cost+"원");
	
	}
	
	
}


