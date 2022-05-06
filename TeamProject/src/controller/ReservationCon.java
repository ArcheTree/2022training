package controller;

import service.Management;
import view.HotelView;

public class ReservationCon {
	
	

	public static void main(String[] args) {
		HotelView hv=new HotelView();
		Management mng=new Management();
		mng.readResrve();
//		hv.Reservation();
				
	}


}
