package service;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import dto.HotelVO;
import operate.Booknumber;
import view.HotelView;


public class Management {
	List<HotelVO> hotellist=new ArrayList<>();
	Booknumber bn=new Booknumber();
	Scanner sc=new Scanner(System.in);
	
	public List<HotelVO> getHotellist() {
		return hotellist;
	}

	public void setHotellist(List<HotelVO> hotellist) {
		this.hotellist = hotellist;
	}

	// DB생성
	public void createRervation(HotelVO hotelVO) {
		writeReserve(hotelVO);
		hotellist.add(hotelVO);
		hotelVO.print();
		
	}

		//파일로 저장
		//writeReserve(HotelVO hotelVO)-> hoteldVO 인트턴스 불러오기(HotelView에서 만든 인스턴스)
	public void writeReserve(HotelVO hotelVO) {
		try(ObjectOutputStream oo=
				new ObjectOutputStream(new FileOutputStream(hotelVO.getBooknumber()+".txt")))
		{oo.writeObject(hotellist);
			System.out.println("파일 저장 성공");
		}catch(IOException e) {
			e.getMessage();
			System.out.println("파일 저장 실패");
		}
	}
	
	//파일 불러 오기
	public void readResrve() {
		try(ObjectInputStream oi=
				new ObjectInputStream(new FileInputStream(sc.nextInt()+".txt"))){
			hotellist=(List<HotelVO>)oi.readObject();
			System.out.println("파일 불러오기 성공");
		}catch(ClassNotFoundException e) {
			System.out.println("아직 저장 된 것은 없습니다");
		}catch(IOException e) {
			System.out.println("저장된 것이 없거나 파일 읽기 실패");
		}
		//처음 실행하여 저장된 것이 없을 때
		if(hotellist==null) {
			hotellist=new ArrayList<>();
		}
	}
	public void makeReserve(){
		
	
	}
	
	

}
