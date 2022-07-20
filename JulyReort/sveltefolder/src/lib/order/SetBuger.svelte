<script>
import { onMount,onDestroy } from "svelte";

import buger from "./DB/buger";

let setbuger 
let setcost
let bugeritem=1
let setbugercost

function gooption(selitem,standardcost){
    console.log(selitem,standardcost)
     setbuger = selitem 
     setcost = standardcost
    console.log(setbuger,setcost)
}

onDestroy(()=>{alert(`선택하신 상품은 ${setbuger} 이고 기본가격은 ${setbugercost}입니다.`)})


</script>
<div class="grid">
    {#each buger as buge(buge.id)}
        <button id="d" style="background-color: {buge.color}" on:click={()=>{setbugercost=buge.setStand}}>
            <label class="square" >
                <input type=radio bind:group={bugeritem} value={buge.id} 
                on:click={()=>gooption(buge.name,buge.cost)}
                >        
                <img src={buge.image} alt = "{buge.name}사진" />
                <p>{buge.name}-{buge.setStand}원</p>
            </label>
        </button>
    {/each}
</div>

    <footer class="payment">
        <table>
        <tr>
            <td class = "selitem_name">상품</td>
            <td class = "selitem">{setbuger}세트</td>
        </tr>
        <tr>
            <td colspan = 2>기본 가격 : {setbugercost}원</td>

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
    color:white;
	border: none;
	margin: 0;
	}
img{
    width:100%;
    height:60%;
}
footer{
    width:80%;
    float:left;
    margin-left: 20px;
    margin-top: 20px;

}
footer>table>tr>td{
    border : 3px double black;
    height : 33px;
}
footer>table{
    width:100%;
}
.selitem{
    width : 80%;
    text-align: center;
}
.selitem_name{
    width : 20%;
    text-align: center;
}
</style>