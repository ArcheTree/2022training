<script>

import { page,reactionS } from './store.js';
function reset(){
    count=0
    k=0
    date1=null
    date2=null
    clearInterval(stops)
}

let select="main"
let count=0 //realtime
let stops
let k=0//targettime
function start(){
    k=Math.floor(Math.random()*500+1000)
    select="during"
    stops=setInterval(()=>{
        count++
    },1)
}
function stop(){
    date2=new Date()
    fix()
}
function fix(){
    score=date2-date1

}
let date1
let date2
$:if(count>=k&&count>10){
    date1=new Date()
    select="end"
    clearInterval(stops)

}
let score=0
function end(){
    select="ending"
    stop()
}
function fails(){
    select="fails"
    stop()
}
function restart(){
    select="main"   
    count=0 //realtime
    k=0//targettime
    reset()
}

function home(){
    page.update(n=>"home")
}
let reading
function submit(){
    reset()
    
    const target = reactionS.subscribe(value => {
	   let reacS= value
        reading=reacS
       if(reacS>score){
        reactionS.update(n=>score)
    }
    });
    
    home()
}
$:console.log(score)
$:console.log(reading)
</script>

<div id=main>
{#if select=="main"}
    <div id=main_start on:click="{start}">
        <div id=in>
            <h1>준비되면 화면을 클릭하세요</h1>
        </div>   
    </div>
{/if}
{#if select=="during"}
    <div id=main_during on:click="{fails}">
        <div id=in>
            <h1>기달리셈</h1>
        </div>   
    </div>
{/if}
{#if select=="end"}
    <div id=main_end on:click="{end}">
        <div id=in>
            <h1>누르셈</h1>
        </div>    
    </div>
{/if}
{#if select=="ending"}
<div id=main_ending>
        <div id=in>
        <h1>your score{score}</h1>
        <button on:click="{submit}">submit</button>
        <button on:click="{restart}">try</button>
        </div>
</div>   

{/if}
{#if select=="fails"}
    <div id=main_fails>
        <div id=in>
        <h1>too fast</h1>
        <button on:click="{home}">home</button>
        <button on:click="{restart}">try</button>
        </div>
    </div>
{/if}
</div>
<p>설명</p>
<p>반은속도 테스트</p>
<p>화면이 바뀔때 클릭을 통해 반응속도를 측정한다(단위 밀리세컨)</p>

<style>
    p{
        font-size: 1.5em;
    }
    h1{
        text-align: center;
        margin:0;
    }

    #main_start{
        background-color: aquamarine;
        height:500px;
    }
    #main_during{
        background-color:tomato;
        height:500px;
    }
    #main_end{
        background-color: aquamarine;
        height:500px;
    }
    #main_ending{
        background-color: aquamarine;
        height:500px;
    }
    #main_fails{
        background-color: aquamarine;
        height:500px;
    }
    #in{
        position:relative;
        top:100px;
        width:max-content;
        margin: auto;
    }
    button{
        position: relative;
        top:100px;
        width:100px;
        height:60px;
    }
</style>