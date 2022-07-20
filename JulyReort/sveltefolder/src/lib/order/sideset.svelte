<script>
    import sides from "./DB/sides";
    let sideitem = 1 
    let sidechange
    let sidename
    import { onDestroy } from "svelte";

    onDestroy(()=>{alert(`선택하신 옵션으로 ${sidechange}원을 추가결제가 필요합니다.`)})
</script>

<h4> 세트 : 사이드메뉴 변경</h4>
<div class="grid">
    {#each sides as side(side.id)}
        <button id="d" on:click={()=>{sidechange= side.setStand 
                                        sidename = side.name }}>
            <label class="square">
                <input type=radio bind:group={sideitem} value={side.id}
                style="color: {side.color}" 
                >
                <img src={side.image} alt = "{side.name}사진" />
                <p>{side.name} - {side.setStand}원</p>
            </label>
        </button>
    {/each}
</div>
<footer>
    <table>
        <tr>
            <td class = "selitem_name">사이드메뉴 선택</td>
            <td class = "selitem">{sidename}</td>
        </tr>
        <tr>
            <td colspan = 2>추가 가격 : {sidechange}원</td>
        </tr>
    </table>
</footer>

<style>
.grid{
    display: grid;
	flex: 1;
	grid-template-columns: repeat(3, 4fr);
	grid-template-rows: repeat(2, 1fr);
	grid-gap: 1vmin;
    width:90%;
    margin: 0px auto;
    }
div>button>label>p{
    text-align: center;
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