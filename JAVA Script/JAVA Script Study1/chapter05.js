console.log("함수 쳅터")

/*
익명 함수
*/
const 함수 = function(){
    console.log('함수 내부의 코드입니다.-----1')
    console.log('함수 내부의 코드입니다.-----2')
    console.log('함수 내부의 코드입니다.-----3')
    console.log('')
}

/*선언적 함수 */
function funcName(){
    console.log("선언적 함수1")
    console.log("선언적 함수2")
    console.log("선언적 함수3")
}

함수()

//함수 호출 - function call(func call)
funcName()

const func1 = function(){
    console.log("익명함수 1")
    console.log("익명함수 2")
    console.log("익명함수 3")
}

func1()

console.log(typeof 함수)
console.log(함수);

//즉시호출 함수 IIFE( 이피)
(function func2(){
    console.log("func2 called")
})()

function f(x){
    return x*x
}
console.log(f(3)) //3*3
console.log(f(4)) //4*4
console.log(f(15)) //15*15
console.log(f(20)) //20*20
console.log(f("문자"))  //NaN - 숫자아님

/* 윤년 2월 29일까지 있는 해
 * 4년 주기로 발생 y%4==0
 * 100년주기로는 발생 안함(4년 주기라도) y%100==0
 * 400년 주기로는 윤년 맞음(100년 주기라도) y%400==0
 */

function isLeapYear(year){
    return((year%4===0)&&(year%100!==0))||(year%400===0)
}
if(isLeapYear(2022)){
    console.log("2월은 29일까지")
}else{
    console.log("2월은 28일까지")
}

console.log(`2023? == ${isLeapYear(2023)}`)
console.log(`2030? == ${isLeapYear(2030)}`)
console.log(`2124? == ${isLeapYear(2124)}`)
console.log(`2024? == ${isLeapYear(2024)}`)


/**
 *  자바-
 * 같은 이름의 함수 정의 가능
 * 단, 매개변수의 개수, 매개변수의 타입이 다를때
 * -- 메소드 오버로딩
 */
/** 점 3개 찍어 (...) variableName->나머지 매개변수 */

function f1(...items){
    console.log(items)
    for(const item of items){
        console.log(item)
    }
}
f1(1)
f1(1,2)
f1(1,2,3)
f1(1,2,3,4)

//최소값 구하기

function min(...numbers){
    let num = numbers[0]
    for(const item of numbers){
        if(num>item){
            num=item
        }
    }
    return num
}
console.log(min(12,32,145,3,15,7,2315,23,57))

/**
 * 전개 연산자
 * 배열을 전개 한다
 */
const array=[1,2,3,4]
console.log(array[0]+","+array[2])
console.log(min(...array))
console.log(...array)

//시급 계산기

function earnings(name, wage=9160, hour=40){  //기본값 입력가능 변수=기본값
    console.log(`# ${name}님의 급여 정보`)
    console.log(`- 시급 ${wage}원`)
    console.log(`- 근무시간 ${hour}시간`)
    console.log(`- 급여 : ${wage*hour}원`)
}

earnings("김자바",18520,52)
earnings("김씨샵")             // 넣지 않으면 기본값으로 들어감
