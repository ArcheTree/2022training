console.log("7/4 수업")

const num = Math.random()
console.log("0~1사이의 랜덤한 숫자 : "+num)
console.log("0~10사이의 랜덤함 숫자 : "+num*10)
console.log("0~10사이의 랜덤한 정수 : "+Math.floor(num*10,0))
console.log("0~50사이의 랜덤함 숫자 : "+Math.floor(num*50,0))
console.log("1~9사이의 랜덤함 숫자 : "+Math.floor(num*9+1,0))
console.log("-5~+5사이의 랜덤함 숫자 : "+Math.floor(num*10-5,0))
console.log("-25~+25사이의 랜덤함 숫자 : "+Math.floor(num*50-25,0))
//Math.ceil() -  소수점 올림해서 정수반환
//Math.round() - 소수점 반올림해서 정수반환
//Math.floor() - 소수점 내림해서 정수반환

//객체 기반의 다중 할당
const object = {
    name : "혼자 공부하는 파이썬",
    price: 18000,
    puvlisher : "한빛 미디어"
}

const {name,price} = object
console.log(name,price)

//전개 연산자 - 깊은 복사(새로운 배열을 만들고 싶을때 만듬)
//[...배열]

//얕은 복사 (같은 메모리공간 사용)
const product1=["우유","식빵"]
const product2 = product1

product2.push("고구마")
product2.push("토마토")
console.log(product1)
console.log(product2)

//깊은 복사 ->같은 내용이지만 메모리 공간은 분리(Deep copy)
const product3 = ["우유","식빵"]
const product4 =[...product3]
product4.push("Sweet Potato")
product4.push("Tomato")
console.log(product3)
console.log(product4)

const product5 = ["우유","식빵"]
const product6 =["고구마",...product5,"토마토"]
console.log(product6)
