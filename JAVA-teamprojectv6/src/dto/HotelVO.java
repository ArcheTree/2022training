package dto;

import java.io.Serializable;

public class HotelVO implements Serializable{
	
	private String room;
	private String name;
	private String phoneNum;
	private int night;
	private double cost;
	private String booknumber;
	private int year;
	private int month;
	private int day;
	

	public String getRoom() {
		return room;
	}
	public void setRoom(String room) {
		this.room = room;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPhoneNum() {
		return phoneNum;
	}
	public void setPhoneNum(String phoneNum) {
		this.phoneNum = phoneNum;
	}
	public int getNight() {
		return night;
	}
	public void setNight(int night) {
		this.night = night;
	}
	public double getCost() {
		return cost;
	}
	public void setCost(double cost) {
		this.cost = cost;
	}
	public String getBooknumber() {
		return booknumber;
	}
	public void setBooknumber(String booknumber) {
		this.booknumber = booknumber;
	}
	public int getYear() {
		return year;
	}
	public void setYear(int year) {
		this.year = year;
	}
	public int getMonth() {
		return month;
	}
	public void setMonth(int month) {
		this.month = month;
	}
	public int getDay() {
		return day;
	}
	public void setDay(int day) {
		this.day = day;
	}
	
	@Override
	public String toString() {
		return "HotelVO [예약번호 : "+booknumber+", 예약자=" + name + ", Room=" + room + ", 연락처=" + phoneNum + ", 이용기간=" + night + ", "
				+ "체크인="+ year+"-"+month+"-"+day+ ", 결제금=" + cost + "]\n";
	}
	public void print() {
	
		System.out.println(toString());
	}
	
}
