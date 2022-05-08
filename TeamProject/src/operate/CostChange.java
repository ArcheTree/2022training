package operate;


import java.time.DayOfWeek;
import java.time.LocalDate;

import dto.HotelVO;


public class CostChange {
	
	//���� ���� ��ȯ 
	
	public double cost=0;  //�ӽ����� < ������ �ٸ� ������ ���������� �ϱ�

	//�ָ� �߰����	
	public int weekendcost(LocalDate date) {
		DayOfWeek dayOfWeek=date.getDayOfWeek();
		int WeekNumber=dayOfWeek.getValue();
		if(WeekNumber==5||WeekNumber==6){
	 cost= cost*1.25;
		}
		return (int) cost;
	}
	//������ �߰����
	
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
			
		LocalDate bookday=LocalDate.of(hotelVO.getYear(), hotelVO.getMonth(), hotelVO.getDay());//<������ ���� �ϱ�
	
			if(hotelVO.getRoom().equals("�̱�")) {
				cost = 700000;           
			}else if(hotelVO.getRoom().equals("����")) {
				cost = 100000;        
			}else if(hotelVO.getRoom().equals("Ʈ��")) {
				cost = 120000;           
			}else if(hotelVO.getRoom().equals("����Ʈ")) {
				cost = 300000;           
			}
	
			weekendcost(bookday);
			vacation(bookday);

		System.out.println("������ : "+(int) cost+"��");
		return cost;

		}
	
		
	

	
	
	
}