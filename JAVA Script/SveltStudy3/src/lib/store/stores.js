//js파일에 store를 만드는 것
import { derived, readable, writable } from "svelte/store";
 
//writable(스토어)는 변수로 읽기, 쓰기가 가능함
export const count = writable(0)
//initial - 초기값, null,undefined 사용가능
//start-첫 구독자가 발생했을때 호출되는 함수
//(start 안에서 매개변수와 역할을 함) set-관찰하고 있는 값이 변경 될대 콜백하는 함수
//(start 안에서 매개변수와 역할을 함) stop-모든 구독자가 구독을 중단했을때 호출되는 함수
export const time = readable(new Date(), function start(set){
    const interval = setInterval(()=>{
        set(new Date())
    },1000)   //이 메소드는 초단위로 현재 시간을 알려줌
    return function stop(){
        clearInterval(interval)
    }
})
// const start = new Date()
// //Derived stores - 기존 스토어를 재사용
// export const elapsed = derived(time,$time=>{
//     Math.round($time-(start/1000))
// })

export const name=writable("World")
export const greeting=derived(
    name,$name=>`Hello ${$name}!`
)