<script>


import addoptions from "./DB/addoptions";
import { flip } from 'svelte/animate';
import { onDestroy } from "svelte";

let totalcost = 0
let addcost


function payadd(itemcost){
    totalcost += itemcost
    console.log(totalcost)
    return totalcost
}
function refundadd(itemcost){
    totalcost -= itemcost
    return totalcost
}

onDestroy(()=>{
    alert(`선택하신 옵션으로 ${totalcost/2}원을 추가결제가 필요합니다.`)
    for(let i =0; i<addoptions.length;i++){
        addoptions[i]["addition"]=false
    }

})


</script>

<h5>버거 옵션 추가</h5>
<div id="left">
    <h3> 선택가능</h3>
    {#each addoptions.filter(t => !t.addition)  as addoption (addoption.id)}
        <button class="d" animate:flip on:click={()=>payadd(addoption.cost)}>
            <label>
                <input type=checkbox bind:checked={addoption.addition} 
                >
                {addoption.name}
                <img src={addoption.image} alt = "{addoption.name}사진" />
                <p>+{addoption.cost}원</p>
            </label>
        </button>
    {/each}
</div>
<div id = "right">
    <h3>추가 옵션</h3>
    {#each addoptions.filter(t => t.addition)  as addoption (addoption.id)}
        <button class="d" animate:flip on:click={()=>refundadd(addoption.cost)}>
            <label>
                <input type=checkbox bind:checked={addoption.addition}  >
                <img src={addoption.image} alt = "{addoption.name}사진" />
                {addoption.name} 
                <div>
                <p> +{addoption.cost} 원</p>
                </div>	
            </label>
        </button>
        {/each}
</div>
<footer>
    <table>
        <tr>
            <td class = "selitem_name">추가구매</td>
        </tr>
        <tr>
            <td>
                <div id="payoption">
                {#each addoptions as addoption}
                    {#if addoption.addition } 
                        <div class="ed">{addoption.name}추가</div>
                 
                    {/if}
                {/each}
                    <div  id = "totalpay">
                        <p>추가결제금 : {totalcost/2}</p>
                    </div>
                </div>
            </td>
        </tr>
    </table>

</footer>

<style>
#left, #right {
	float: left;
	width: 50%;
	padding: 0 1em 0 0;
	box-sizing: border-box;
}
.d{
    width:100%;
    display: block;
    border-radius: 2px;
    left: 0;
    border : 0px;
    margin-bottom: 5px;
}
label{
	top: 0;
	left: 0;
    height : 50px;
	display: block;
	font-size: 1em;
	line-height: 1;
	padding: 0em;
	margin:  auto;
	border-radius: 2px;

	user-select: none;
}
h5{
    margin: 0px;
}
input { 
    margin: 0;
    float: left;
}

#right>button {		
    background-color: rgb(180,240,100);
}
img{
    width:50x;
    height : 50px;
    float: left;
}
label>div>p {
    font-weight: 800;
    margin-top:0px;
}
label>p {
    float: right;
    font-weight: 800;
    margin-top:0px;
}
footer{
    float:left
}
footer>table>tr>td{
    border : 1px double black;
}

.selitem_name{
    width : 500px;
    text-align: center;
}
.ed{
    float : left;
    display:block;
    border: 1px solid black;
    padding: 5px;
    margin: 3px;
}
label>div{
    float: right;

}
#totalpay{
    float: right;
    padding: 5px;
    margin: 3px;
}
</style>