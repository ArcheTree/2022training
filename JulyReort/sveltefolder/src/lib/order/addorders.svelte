<script>


import addoptions from "./addoptions";
import { flip } from 'svelte/animate';

export let totalcost = 0
let addcost

// let sum
// function totalcost() {
//    sum= addcost.reduce((t, n) => t + n, 0);
// 	}

function payadd(itemcost){
    addcost = itemcost
    totalcost = totalcost + addcost
    return totalcost
}
function refundadd(itemcost){
    addcost = itemcost
    totalcost = (totalcost-addcost)
    return totalcost
}


</script>

<h5>버거 옵션 추가</h5>
<div id="left">
    <h3> 선택가능</h3>
    {#each addoptions.filter(t => !t.addition)  as addoption (addoption.id)}
        <label
            animate:flip
        >
		<input type=checkbox bind:checked={addoption.addition}  >
        {addoption.name}   
        <img src={addoption.image} alt = "{addoption.name}사진" />
        <p>+{addoption.cost}원</p>
		</label>
    {/each}
</div>
<div id = "right">
    <h3>추가 옵션</h3>
    {#each addoptions.filter(t => t.addition)  as addoption (addoption.id)}
        <label
            animate:flip
        >
		<input type=checkbox bind:checked={addoption.addition} >
        <img src={addoption.image} alt = "{addoption.name}사진" />
        {addoption.name}   
        <div>
        <p> +{addoption.cost} 원</p>
            <button on:click|once={()=>payadd(addoption.cost)}>확정</button>
            <button on:click|once={()=>refundadd(addoption.cost)}>취소</button>
	    </div>	
    </label>
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
                    {#if addoption.addition}
                    <table>
                        <tr>
                            <td class="ed">{addoption.name}추가</td>
                           
                        </tr>
                    </table>
                    {/if}
                    {/each}
                    <p>추가결제금 : {totalcost}</p>
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
label {
	top: 0;
	left: 0;
	display: block;
	font-size: 1em;
	line-height: 1;
	padding: 0.5em;
	margin: 0 auto 0.5em auto;
	border-radius: 2px;
	background-color:#ffffff;
	user-select: none;
}

input { margin: 0 }

#right label {		
    background-color: rgb(180,240,100);
}
img{
    width:50x;
    height : 50px;
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
    width:180px;
    border: 1px solid black;
}
label>div{
    float: right;

}

</style>