package dto;


public class HotelVO {
	
	private String room;
	private String name;
	private int phoneNum;
	private int night;
	private int checkIn;
	private int cost;
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
	public int getPhoneNum() {
		return phoneNum;
	}
	public void setPhoneNum(int phoneNum) {
		this.phoneNum = phoneNum;
	}
	public int getNight() {
		return night;
	}
	public void setNight(int night) {
		this.night = night;
	}
	public int getCheckIn() {
		return checkIn;
	}
	public void setCheckIn(int checkIn) {
		this.checkIn = checkIn;
	}
	public int getCost() {
		return cost;
	}
	public void setCost(int cost) {
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
				+ "예약일="+ year+"-"+month+"-"+day+ ", 비용=" + cost + "]";
	}
	public void print() {
	
		System.out.println(toString());
	}
	

	
}
