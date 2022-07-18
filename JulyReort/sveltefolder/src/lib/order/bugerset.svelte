<script>
import Addorders from "./addorders.svelte"
import buger from "./buger";

let selectedbuger =false
let selbugername
let bugercost

function alte(selbugername,bugercost){
    selectedbuger =!selectedbuger 
    console.log(selbugername,bugercost)
}

</script>

<h4> 세트구성 : 버거 + 감자 튀김 + 음료</h4>
<div class="grid">
    {#each buger as buge(buge.id)}
    <div class="square">
        {#if selectedbuger!==true}
        <button
        style="color: {buge.color}" 
        on:click={()=>alte(buge.name,buge.cost)}
        >
        <img src={buge.image} alt = "{buge.name}사진" />
        <p>{buge.name}-{buge.setStand}원</p>
    </button>
    {/if}
</div>
{/each}
</div>
{#if selectedbuger === true}
<button id ="canclebutton" on:click={()=>alte(null,null)}>버거 변경</button>
<Addorders />
{/if}
    <!-- bind:value={buge.cost} -->

<style>
.grid{
    display: grid;
	flex: 1;
	grid-template-columns: repeat(3, 1fr);
	grid-template-rows: repeat(3, 1fr);
	grid-gap: 1vmin;
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
</style>