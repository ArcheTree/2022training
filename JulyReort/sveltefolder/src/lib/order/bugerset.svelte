<script>
import Addorders from "./addorders.svelte"
import buger from "./buger";
import Sideset from "./sideset.svelte"
import Bavergeset from "./Bavergeset.svelte"

let selectedbuger =false
let selectedoption =false
let selectedside = false
let selectedbaverge =false
function gooption(selitem,standardcost){
    selectedbuger =!selectedbuger 
    selectedoption = true
    console.log(selitem,standardcost)
     setbuger = selitem 
     setcost = standardcost
    console.log(setbuger,setcost)
}
function backhome(selitem,standardcost){
    setbuger = selitem 
    setcost = standardcost
    selectedbuger=false
    selectedoption=false
}
function goside(){
    selectedbuger = true
    selectedoption = false
    selectedside = true
}
function gobaverge(){
    selectedbuger = true
    selectedoption = false
    selectedside = false
    selectedbaverge = true
}
let setbuger 
let setcost

</script>

<h4> 세트구성 : 버거 + 감자 튀김 + 음료</h4>
<div class="grid">
    {#each buger as buge(buge.id)}
    <div class="square">
        {#if selectedbuger!==true}
        <button
        style="color: {buge.color}" 
        on:click={()=>gooption(buge.name,buge.cost)}
        >
        <img src={buge.image} alt = "{buge.name}사진" />
        <p>{buge.name}-{buge.setStand}원</p>
    </button>
    {/if}
</div>
{/each}
</div>
{#if selectedoption === true}
<button id ="canclebutton" on:click={()=>backhome("","")}>버거 변경</button>
<Addorders />
<button on:click={goside}>선택 완료</button>
{/if}
{#if selectedside===true}
<Sideset />
<button on:click={gobaverge}>선택 완료</button>
{/if}
{#if selectedbaverge===true}
<Bavergeset />
{/if}
<footer class="payment">
    <table>
      <tr>
        <td class = "selitem_name">상품</td>
        <td class = "selitem">{setbuger}세트</td>
        <td class = "selitem_name">추가옵션</td>
        <td class = "selitem_name">사이드변경</td>
        <td class = "selitem_name">음료변경</td>
      </tr>
      <tr>
        <td colspan = 2>기본 가격 : {setcost}원</td>
        <td >추가 가격 : 원</td>
        <td >추가 가격 : 원</td>
        <td >추가 가격 : 원</td>
      </tr>
    </table>
</footer>
  

<style>
.grid{
    display: grid;
	flex: 1;
	grid-template-columns: repeat(3, 4fr);
	grid-template-rows: repeat(3, 1fr);
	grid-gap: 1vmin;
    width:90%;
    margin: 0px auto;
    }
div>button {
	width: 100%;
	height: 100%;
	color: white;
	border: none;
	margin: 0;
	}
img{
    width:100%;
    height:60%;
}
h4{
    margin : 5px 0px;
    padding : 0px 10px;
}
#canclebutton{
    float: right;
    height: 30px;
    width : 100px;
}
footer{
    float:left
}
footer>table>tr>td{
    border : 3px double black;
}
.selitem{
    width : 220px;
    text-align: center;
}
.selitem_name{
    width : 80px;
    text-align: center;
}

</style>