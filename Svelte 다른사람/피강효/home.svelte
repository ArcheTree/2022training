<script>
import {slide} from "svelte/transition"
import { page,reactionS,sequenceS } from './store.js';
let value1=false
function check1(){
    if(value1==true){
        value1=false
    }
    else value1=true
}
let value2=false
function check2(){
    if(value2==true){
        value2=false
    }
    else value2=true
}


let reacS
const target1 = reactionS.subscribe(value => {
		 reacS= value;
	});
$:if(reacS==100000){
    reacS=null
}

let secqS
const target2 = sequenceS.subscribe(value => {
		 secqS= value;
	});
    $:if(secqS==0){
    secqS=null
}


function reaction(){
    value1=false
    page.update(n=>"reaction")
}
function sequence(){
    value2=false
    page.update(n=>"sequence")
}

</script>

<div id=main>
    <div id=body>
    <h1 style="text-align: center">games</h1>

    <table>
        <tr>
            <td><p id=tag>reaction</p></td>
            <td>
            <button on:click="{reaction}">play</button>
            </td>
            <td>
                <p><button on:click={check1}>점수확인</button></p>
            </td>
        </tr>
        {#if value1}
        <tr>
            <p transition:slide>{reacS}</p>
        </tr>
        {/if}
        <tr>
            <td><p id=tag>sequence</p></td>
            <td>
            <button on:click="{sequence}">play</button>
            </td>
            <td>
                <p><button on:click="{check2}">점수확인</button></p>
            </td>
        </tr>
        {#if value2}
        <tr>
            <p transition:slide>{secqS}</p>
        </tr>
        {/if}
    </div>
</div>
<p>humanbenchmark라는 게임을 통한 가벼운 테스트를 하는 사이트의 게임을 모방해봤습니다</p>
<p>reaction=반응성 테스트</p>
<p>sequence=위치 기억능력 테스트</p>
<style>
    h1{
        margin:0;
    }
    #main{
        margin:auto;
        background-color: aquamarine;
        min-height: 500px;
    }
    #tag{
        width: min-content;
        
    }
    table{
        margin:auto;
    }
    #body{
        position:relative;
        top:100px;
    }
</style>