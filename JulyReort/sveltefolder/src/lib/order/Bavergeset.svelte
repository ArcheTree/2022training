<script>
import baverges from "./DB/baverges";

let bavergeitem =1
let bavergechange
</script>


<h4> 세트 : 음료 변경</h4>
<div class="grid">
    {#each baverges as baverge(baverge.id)}
        <button id="d" on:click={()=>{bavergechange= baverge.setStand}}>
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
<p>변경 금액 {bavergechange}</p>
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
</style>