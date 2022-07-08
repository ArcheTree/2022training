console.log("확인30")

/**
 *콜백함수 - 
 1. 비동기 순서를 동기적으로??
 2. 라이브러리(모듈)를 간결, 간단하게 쓰기 위해
 call back
 함수 ->객체 ->익명함수 가능 -> 변수에다가 참조가능
 */
const noNamefunc=function(){
    console.log("익명 함수")
}
function callThreeTimes(callback){
    for(let i = 0;i<=3;i++){
        callback(i)
    }
}
function print(i){
    console.log(`${i}번째 함수 호출`)
}
callThreeTimes(print)

callThreeTimes(function(i){
    const furits=["사과","바나나","망고"]
    console.log(furits[i])
}) //함수 이름도 참조도 없는 객체 함수모음

// 화살표 함수 =람다
callThreeTimes((i)=>{
    console.log("화살표 람다 함수")
    const furits=["사과","바나나","망고"]
    console.log(furits[i])
})
callThreeTimes(i=>{
    console.log("화살표 람다 함수2")
    const furits=["사과","바나나","망고"]
    console.log(furits[i])
})  //중괄호가 함수 몸체

//forEach 문  - for와 기능 같음 어떻게 쓸지는 알아서
let numbers=[123,57,321,85,3,57,54]

numbers.forEach(function(value, index, array){
    console.log(`${index}번째 요소는 : ${value}`)
})
numbers.forEach((value, index,array)=>{
    console.log(`${index}번째 요소는 : ${value}`)
})
numbers.forEach((value, index,array)=>{
    console.log("value :"+value)
    console.log("index :"+index)
    console.log(array)
})
//제곱해서 새로운 배열생성-> forEach 문으로 간단하게 지정

numbers=numbers.map((value, index, array)=>{ // 반투명은 사용안된 변수 -> 지워도됨
    return value*value
})
console.log(numbers)
numbers.forEach(console.log)

numbers=[0,1,2,3,4,5]
//filter 리턴값의 true 인것만 모아서 새로운 배열 생성

const evenNumbers = numbers.filter((value)=>{
    return value%2===0
})
console.log(evenNumbers)

numbers=[0,1,2,3,4,5,6,7,8,9]
//메소드 체닝 연결해서 사용가능{}는 시행하는것?
numbers.filter((value)=>
    value%2===0
).map((value)=> 
    value*value
).forEach(value=>{
    console.log(value)
})

/** 타이머 함수
 * setTimeout(함수, 시간) - 특정 시간 후에 한번 출력 -> clearTimeout(타이머_ID)
 * setInterval(함수, 시간) -  특정 시간 마다 함수를 호출 ->clearInterval(타이머_ID)
 */
//시간은 밀리초 단위로 기입(1000밀리초 = 1초)
// setTimeout(()=>{
//     console.log("setTimeout 실행됨")
// },3000)

// let count=1
// let id=setInterval(()=>{
//     console.log(`setInterval 실행됨 ${count++}번 실행`)
// },6000)
// console.log("id="+id)

// setTimeout(()=>{
//     clearInterval(id)
//     console.log("인터벌 정지")
// },30001)

function mainjs(){
    {let pi = 3.14
    console.log(`파이 값은 : ${pi}`)}

    let num1=0
    console.log(num1)
    var data=10
    console.log("data: "+data)

    /**엄격 모드 */
        'use.strict'
    //비동기언어 ->각자 함수 시간차나 순서대로 실행 X 각자 알아서 로딩(독립적으로 적용)(쓰래드 적인 느낌?)
    function func1(){
        setTimeout(()=>{
            for(let i = 0 ; i<3 ; i++){
                console.log("func1 : "+i)
            }
        },1500)
    }
    function fucn2(){
        for(let i = 0 ; i<3 ; i++){
            console.log("func2 : "+i)
        }
    }
    //fucn1부터 가동 되고 func2가 가동되는 것 X  func1,2동시가 시작해서 시간걸리는 func1이 늦게 시행 
    // func1()
    // fucn2()

    //동기화로 변경
    function func3(callback){
        setTimeout(()=>{
            for(let i = 0 ; i<3 ; i++){
                console.log("func3 : "+i)
            }
            callback()
        },1500)
    }
    function fucn4(){
        for(let i = 0 ; i<3 ; i++){
            console.log("func4 : "+i)
        }
    }
  //  func3(fucn4)

    function timer(time){
        return new Promise((resolve)=>{
            setTimeout(()=>{
                resolve(time)
                console.log("타이머 실행")
            },time)
        })
    }
    // console.log("START")
    // timer(1000)
    // .then((time)=>{
    //     console.log(`${time/1000}초 후 실행`)
    //     return timer(time+1000)
    // })
    // .then((time)=>{
    //     console.log(`${time/1000}초 후 실행`)
    //     return timer(time+1000)
    // })
    // .then((time)=>{
    //     console.log(`${time/1000}초 후 실행`)
    //     console.log("END")
    // })
    // console.log("END1")
    //async.await ->길어지는 then 활용으로 대체하기위해 만들어진 코드(아직 적용 안됨 VSC에)
    async function asyncFunc(){
        console.log("start")
        let time = await timer(1000)
        console.log(`${time/1000}초 후 실행`)
        time=await timer(time+1000)
        console.log(`${time/1000}초 후 실행`)
        time=await timer(time+1000)
        console.log(`${time/1000}초 후 실행`)

        console.log("end")
    }
    //asyncFunc()
        
    //json 이용 맛보기
    fetch("https://jsonplaceholder.typicode.com/posts")
        .then((response)=>{
            return response.json()
        })
        .then(data=>{
           // console.log(data)
        })

}
mainjs()