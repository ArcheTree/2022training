package service;

import java.util.List;

import dto.HotelVO;
import operate.Booknumber;
import operate.CostChange;
import operate.Receipt;
import operate.ViewRoom;
import view.HotelView;

public class ReservationCon {
	HotelView hotelView=new HotelView();	
	Management mng=new Management();
	Receipt rec=new Receipt();
	CostChange cc=new CostChange();
	
	public void makeReservation() {
		int manu;
		while(true) {
			manu=hotelView.ReservationManu();
			HotelVO hotelVO=new HotelVO();
			//main loop
			switch(manu){
				case 0:
					System.out.println(mng.getHotellist());
					break;
					
				case 1:
					//예약 실행
					hotelView.ReservationStart();
					hotelVO.setName(hotelView.name);
					hotelVO.setPhoneNum(hotelView.phoneN);
					hotelView.roomChice();
					hotelVO.setRoom(ViewRoom.room);
					hotelView.Checkinday();
					hotelVO.setYear(hotelView.year);
					hotelVO.setMonth(hotelView.month);
					hotelVO.setDay(hotelView.day);
					hotelView.night();
					hotelVO.setNight(hotelView.night);
					hotelVO.setBooknumber(Booknumber.bookNumber());
					cc.totalCost(hotelVO);
					hotelVO.setCost(CostChange.totalCost);
					
					mng.createRervation(hotelVO);
					rec.Room(hotelVO);
					break;
					
				case 2:
					//예약 조회
					hotelView.reservationCheck();
					mng.getReservation(hotelView.book);

					break;
					
				case 3:
					//예약 수정
					hotelView.reservationUpdate();
					hotelVO.setBooknumber(hotelView.book);
					hotelView.roomChice();
					hotelVO.setRoom(ViewRoom.room);
					hotelView.Checkinday();
					hotelVO.setYear(hotelView.year);
					hotelVO.setMonth(hotelView.month);
					hotelVO.setDay(hotelView.day);
					hotelView.night();
					hotelVO.setNight(hotelView.night);
					cc.totalCost(hotelVO);
					hotelVO.setCost(CostChange.totalCost);
					mng.reviseResreve(hotelVO);
					mng.getReservation(hotelView.book);

					break;
				
				case 4:
					hotelView.reserveCancel();
					hotelVO.setBooknumber(hotelView.book);
					mng.deleteReservation(hotelVO);
					break;
					
				case 5:
					System.out.println("이용해주셔서 감사합니다.");
					System.out.println();
					System.out.println("\t종료");
					return;
					
			}
		}
	}
	



}
