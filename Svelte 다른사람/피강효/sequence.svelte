<script>
    import { page,sequenceS } from './store.js';
function sequence(){
    page.update(n=>"home")
}

const arr=[]
for(let i=0;i<24;i++){
    arr[i]=i
}
let select="home"
let arr2=[]
let count=3
let score=0
function start(){
    operating()
    select="start"
}
function operating(){
    for(let i=0;i<count;i++){
        arr2[i]=Math.floor(Math.random()*24)        
        for(let j=0;j<i;j++){
            if(arr2[i]==arr2[j]) {i--}
        }
    }    
}
let checks=0
let target=1
let count1=0
let color=1
function check(event){
        count1++
        color=0
   checks=event.target.value
   if(checks!=target){
        select="fail"
        reset()
        count=3
    }
    if(checks==target){
        target++
        const k=document.getElementById("inb"+(checks))
        k.style.opacity='0'
    }
    if(count1==(count)){
        select="rest"
        score++
        reset()
    }
}
function reset(){
    target=1
    count1=0
    checks=0
    color=1
    arr2=[]
    
}

function levelup(){
    count=count+1
    
    start()
}
function submit(){
    const target = sequenceS.subscribe(value => {
	   let secqS= value
    if(secqS<score){
        sequenceS.update(n=>score)
    }
});
    score=0
    sequence()
}
function trys(){
    start()
    score=0
}


</script>
<div id=body>
{#if select=="home"}
    <div id=main>
        <div id=divin>
        <button id=basicB on:click="{start}">start</button>
        <button id=basicB on:click="{sequence}">home</button>
        </div>
    </div>
{/if}
{#if select=="start"}
    <div id=main>
    {#each arr as num}
        <div id=inner value={num}>
            {#each arr2 as items,i}
                    {#if num==items}
                    <button class=inb id=inb{i+1} on:click="{check}" value={i+1}
                    style="color:rgba(0,0,0,{color})">{i+1}</button>
                    {/if}
            {/each}
        </div>
    {/each}
    </div>
{/if}
{#if select=="fail"}
    <div id=main>
        <h1>실패</h1>
        <button id=basicB on:click="{trys}">try</button>
        <button id=basicB on:click="{sequence}">home</button>
        <button id=basicB on:click="{submit}">submit</button>


    </div>
{/if}
{#if select=="rest"}
    <div id=main>
        <button id=basicB on:click="{levelup}">ready?</button>
    </div>

{/if}
</div>
<h1>현재 점수{score}</h1>
<p>설명</p>
<p>기억능력 테스트</p>
<p>숫자를 번호 순서대로 클릭해야합니다</p>
<p>주의) 클릭시 남은 숫자가 보이지않기에 충분히 기억하고 게임을 실행하세요</p>



<style>
    p{
        font-size: 1.5em;
    }
    h1{
        margin:0;
    }
    #basicB{
        width:100px;
        height:80px;
        margin:20px;
    }
    #divin{
        position: relative;
        top:300px;
        margin: auto;
        width:max-content;
        
    }
    #inner{
        width: 80px;
        margin: 20px;
        height:80px;
        padding: 0;
        border: 0;
        float: left;
    
    }
    #body{
        background-color: aquamarine;
    }
    #main{
        margin: auto;
        width:720px;
        background-color:aqua;
        height:500px;
    }
    .inb{
        border-radius: 1em;
        position: absolute;
        width:80px;
        height:80px;
        padding: 0;
        border: 0;
        font-size: 1.5em;
    }
    .inb:hover{
        background-color: darkorange
    }
    .inb:active{
        background-color: violet;
    }

</style>