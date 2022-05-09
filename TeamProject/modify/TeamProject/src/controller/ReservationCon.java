package controller;

import dto.HotelVO;
import view.HotelView;

public class ReservationCon {
	HotelView hotelView=new HotelView();	
	public void makeReservation() {
		int manu;
		while(true) {
			manu=hotelView.ReservationManu();
			HotelVO hotelVO=new HotelVO();
			switch(manu){
				case 1:
					hotelView.ReservationStart();
					hotelView.roomChice();
					
			}
		}
	}
	



}
