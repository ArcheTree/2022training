<script>
    import sides from "./DB/sides";
    let sideitem = 1 
    let sidechange
    
</script>

<h4> 세트 : 사이드메뉴 변경</h4>
<div class="grid">
    {#each sides as side(side.id)}
        <button id="d" on:click={()=>{sidechange= side.setStand}}>
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

<p>변경 금액 {sidechange}</p>

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
</style>