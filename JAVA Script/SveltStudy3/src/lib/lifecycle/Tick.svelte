<script>
import { tick } from "svelte";


    let text = "Select some text and hit the tab key to toggle uppercase"
    async function handleKeydown(event){
        if(event.key!=="Tab"){
            return
        }
        event.preventDefault()  //텝의 기본기능 막기-표준에서는 불가능
        // @ts-ignore
        const {selectionStart, selectionEnd, value}=this    //this는 textarea를 가르킴(아래 있는 객체)     
        const selection  =value.slice(selectionStart,selectionEnd)
        //정규 표현식 '/[패턴]/' ->문자열에서 특정 문자 패턴을 찾기위한 것(만들어진것을 많이 씀) 뒤에 .test는 표현식에대해  T,F를 구별하는 존재하는 표현식(만들었으면 test대신 넣어야함)
        const replacement=/[a-z]/.test(selection)? selection.toUpperCase():selection.toLowerCase()
        text=value.slice(0,selectionStart)+replacement+value.slice(selectionEnd)
        //렌더링이 종료 ->selectionStart와 End가 사라짐
        await tick()  //await 는 async 메소드에서만 사용가능
        this.selectionStart = selectionStart
        this.selectionEnd = selectionEnd
    }

</script>
<textarea value={text} on:keydown={handleKeydown}></textarea>
<h1>Tick prz</h1>

<style>
    textarea{
        width : 100%;
        height: 200px;
    }
</style>