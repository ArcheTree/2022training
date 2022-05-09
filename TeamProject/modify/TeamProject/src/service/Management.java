package service;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;
import dto.HotelVO;
import operate.Booknumber;
import operate.Receipt;



public class Management {
	
	
	List<HotelVO> hotelList=new ArrayList<HotelVO>();
	Booknumber bn=new Booknumber();
	Scanner sc=new Scanner(System.in);
	private Path hotelFile=Paths.get("hotelList.bin");

	
	public Management() {
		try {
			hotelFile=Files.createFile(hotelFile);
		} catch (IOException e) {
			// TODO Auto-generated catch block
//			e.printStackTrace();
			System.out.println("파일 로드 성공");
			readResrve();
		}
	}

	public List<HotelVO> getHotellist() {
		return hotelList;
	}

	public void setHotellist(List<HotelVO> hotelList) {
		this.hotelList = hotelList;
	}

	// DB생성
	public void createSetting(String room, int night, int year, int month, int day) {
		HotelVO hotelVO=new HotelVO();
		hotelVO.setRoom(room);
		hotelVO.setNight(night);
		hotelVO.setYear(year);
		hotelVO.setMonth(month);
		hotelVO.setDay(day);
	}
	
	public void createRervation(HotelVO hotelVO) {
		
		hotelList.add(hotelVO);
		writeReserve();

	
	}

	//파일로 저장
	//writeReserve(HotelVO hotelVO)-> hoteldVO 인트턴스 불러오기(HotelView에서 만든 인스턴스)
	public void writeReserve() {
		try(ObjectOutputStream oo=
				new ObjectOutputStream(Files.newOutputStream(hotelFile))){
			oo.writeObject(hotelList);
			System.out.println("파일 저장 성공");
		}catch(IOException e) {
			System.out.println("파일 저장 실패");
		}
//		try(FileWriter tw=new)
	}
	
	//파일 불러 오기
	public void readResrve() {
		try(ObjectInputStream oi=
				new ObjectInputStream(Files.newInputStream(hotelFile))){
			hotelList=(List<HotelVO>)oi.readObject();
			System.out.println("파일 불러오기 성공");
		}catch(ClassNotFoundException e) {
			System.out.println("아직 저장 된 것은 없습니다");
		}catch(IOException e) {
			System.out.println("저장된 것이 없거나 파일 읽기 실패");
		}
		//처음 실행하여 저장된 것이 없을 때
		if(hotelList==null) {
			hotelList=new ArrayList<>();
		}
	}
	public void putResreve(HotelVO hotelVO) {
		Iterator<HotelVO> itr=hotelList.iterator();
		while(itr.hasNext()) {
			HotelVO arrhotelVO=itr.next();
			if(arrhotelVO.getBooknumber()==hotelVO.getBooknumber()) {
				arrhotelVO.setRoom(hotelVO.getRoom());
				arrhotelVO.setNight(hotelVO.getNight());
				arrhotelVO.setYear(hotelVO.getYear());
				arrhotelVO.setMonth(hotelVO.getMonth());
				arrhotelVO.setDay(hotelVO.getDay());
			}
		}
	}
	public void getReservation(String booknumbker) {
		for(HotelVO hotelVO:hotelList) {
			if(hotelVO.getBooknumber()!=null&&hotelVO.getBooknumber().equals(booknumbker)) {
				hotelVO.print();
			}else {
				System.out.println("없는 예약번호 입니다.");	
			}
		}

	}
	
	public void getHotelLists(List<HotelVO> hotelList) {
			Iterator<HotelVO> itr=hotelList.iterator();
			while(itr.hasNext()) {
				HotelVO hotelVO=itr.next();
				System.out.println(hotelVO.toString());
			}
	}
	
	public void makeReserve(){

	}


}
