console.log("챕터6 시작")

//객체 - 배열, 함수, 기본타입(중괄호로 감싸면 무조건 객체)
//자바 인스턴스 느낌~
// key " : " value ","  로 구성됨
const product = {
    proName : "7D 건조망고", 
    type : "당절임",
    ingredient : ["망고", "설탕", "메타중이황산나트륨", "치자황색소"],
    originCon : "필리핀", 
    "price":3900,
    "1!@#":"연습용"
}
console.log(product)
//값의 반환 2가지 No.1
console.log(product["proName"])
console.log(product["type"])
console.log(product["ingredient"])
console.log(product["originCon"])
console.log(product["price"])

//값의 젼환 2가지 No.2(key 가 숫자로시작하거나 특수문자의 경우 적용 X)
console.log(product.proName)
console.log(product.type)
console.log(product.ingredient)
console.log(product.originCon)
console.log(product.price)
//특수문자나 숫자는 안됨
console.log(product["1!@#"]) //product["1!@#"]이 배열이다 - 원하는 인덱스를 뒤에 붙히면 됨
console.log(product.ingredient[2])
console.log(product["ingredient"][3])
document.getElementById("div1").innerText=product.ingredient[3]
//for 문
for(let i = 0 ; i<product["ingredient"].length ; i++){
    console.log(product.ingredient[i])
}
//for of 문
for(const ingre of product["ingredient"]){
    console.log(ingre)
}
const pet ={
    name : "구름",
    eat : function(food){
        console.log(this.name + "이가 " + food+"를 먹는다")
        },
        getName(){
            return this.name
        }
}
pet.eat("망고")
pet.eat(product["ingredient"][3])

const student={
    name : "윤인성",
    hobby:"악기",
    //  getName:()=>{
    //      console.log(this) //  -> this가 이상한 함수 찍음
    //  } 
    a:function(){
        console.log("a")
        console.log(this)
    },
    b:()=>{
        console.log("b")
        console.log(this)
    }
}
student.toBe = "SGwannabe"  //배열추가

console.log(student)

delete student.hobby  //배열 삭제
console.log(student)

console.log(pet.getName())
//console.log(student.getName())

student.a()
student.b()  //화살표는 잘 안됨

//객체-속성 메소드
 const a=[]
 a.sample = 10
 console.log(a)

 function b(){}
    b.sample = 10
    console.log(b.sample)

    console.log(typeof(a))

    if(Array.isArray(a)){  
        console.log("배열이다")
    }
console.log(typeof(b))

    function c(callback){
        if(typeof(callback)==="function"){
            console.log("함수 맞다")
        }else{
            console.log("첫번째 매개변수는 함수만")
        }
    }
c(b)
 
// 식별자 참조 가능한 것들을 일급 객체라고 한다
//기본 자료형, 배열, 객체, 함수 

const num1 = new Number(10)
const str1 = new String("문자열")
const b1 = new Boolean(true)

const d = 273
//d.sample = 10
//console.log(d.sample)

const f = new Number(273)
f.sample = 10
console.log(f.sample)

//메소드를 추가하면 메소드체이닝 방식으로 사용
//제곱연산해주는 메소드
console.log(2**3)
console.log(2**10)
Number.prototype.power=function(n=2){
    return this.valueOf()**n
}
const t = 12
console.log("t.power() :",t.power())
console.log("t.power(3) :",t.power(3))
console.log("t.power(4) :",t.power(4))
const num2 = new Number(3)
console.log(num2)

//숫자 n번째 자릿수까지 출력하기 :toFixed()
const longTime = 123.34567
console.log(longTime.toFixed(4))

let num3 = new Number("4")
let num4 = "1일"
num3= num3*num4
console.log(num3)

if(Number.isNaN(num3)){
    console.log("Not a Number")
}else{
    console.log("숫자다")
}

const num5 = 10/0
console.log(num5)
const num6 = 10/0
console.log(num6)
console.log(Number.isFinite(num5)) //false
const num7 =7
console.log(Number.isFinite(num7)) //true
console.log(num5===Infinity)

//String 객체 내장 메소드
//문자열 양쪽 끝의 공백 없애기 : trim()
const stringA="               "
//stringA=stringA.trim()
if(stringA==""){
    console.log("아이디를 제대로 기입해주세요")
}else{
    console.log("아이디 확인중")
}
let srtingB="       공백           "
//console.log(stringB)
//console.log(stringB.trim())

//csv data 1, date2, data3
const stringC = "2022-07-11"
const arrA=stringC.split("-")
console.log(arrA[0])
console.log(arrA[1])
console.log(arrA[2])

/**Json.stringify()
 * Json
 * 1. 값 - 문자열, 삿자, 불 자료형, 함수(X)
 * 2. 문자열은 무조건 "" 
 * 3. 키도 반드시 ""
 * [] 배열[index], {key:value}객체["key"]
 */

const books=[
    {
        "name":"혼자 공부하는 파이썬",
        "price" : 18000,
        "publisher" : "한빛 미디어"
    },    {
        "name":"HTML5 웹 프로그래밍 입문",
        "price" : 26000,
        "publisher" : "한빛 아카데미"
    }
]

console.log(books[1]["price"])

const books1={
    "arr":[
        {
            "key" : "value",
            "key2" : "value2",
            "arr1":[
                {
                    "what" : "the F!",
                    "See" : "pal!"
                },
                {
                    "el" : 12
                }
            ]
        }
    ]
}
console.log(books1["arr"][0]["arr1"][0]["what"])

//문자열 ->Json 객채
//Json 문자열로 변환 Json.stringify()
const json=JSON.stringify(books)
console.log(json)
console.log(json[1])

//자바스크립트 객체로 Json.parse{}
console.log(JSON.parse(json))
console.log(JSON.parse(json)[1])