<script>
import baverges from "./DB/baverges";
import { onDestroy } from "svelte";

let bavergeitem =1
let bavergechange
let bavername


onDestroy(()=>{alert(`선택하신 상품은 ${bavername} 이고 추가가격은 ${bavergechange}원 입니다.`)})
</script>


<h4> 세트 : 음료 변경</h4>
<div class="grid">
    {#each baverges as baverge(baverge.id)}
        <button id="d" on:click={()=>{bavergechange= baverge.setStand
                                        bavername = baverge.name}}>
            <label class="square">
                <input type=radio bind:group={bavergeitem} value={baverge.id}
                style="color: {baverge.color}" 
                >
                <img src={baverge.image} alt = "{baverge.name}사진" />
                <p>{baverge.name} - {baverge.setStand}원</p>
            </label>
        </button>
    {/each}
</div>
<footer>
    <table>
        <tr>
            <td class = "selitem_name">음료 선택</td>
            <td class = "selitem">{bavername}</td>
        </tr>
        <tr>
            <td colspan = 2>변경 금액 {bavergechange}원</td>
        </tr>
    </table>
</footer>
<p></p>
<style>
.grid{
    display: grid;
	flex: 1;
	grid-template-columns: repeat(4, 4fr);
	grid-template-rows: repeat(3, 1fr);
	grid-gap: 1vmin;
    width:90%;
    margin: 0px auto;
}
div>button>label>p{
    text-align: center;
    margin: 5px auto;
}
img{
    width:100%;
    height:60%;
}
h4{
    margin : 5px 0px;
    padding : 0px 10px;
}
#d{
    width: 100%;
    height: 100%;
}
footer{
    width:80%;
    float:left;
    margin-left: 20px;
    margin-top: 35px;

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