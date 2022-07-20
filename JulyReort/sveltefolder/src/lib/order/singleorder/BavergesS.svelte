<script>

    import baverges from "../DB/baverges";
    
        let bevergemenu=[]
        let bevergename=[]

    

        function join(bevergemenu) {
            if (bevergemenu.length === 1) return bevergemenu[0];
            return `${bevergemenu.slice(0, -1).join(', ')} and ${bevergemenu[bevergemenu.length - 1]}`;
        }
        $: bevergesum = bevergemenu.reduce((t, n) => t + n, 0);
        
</script>
        <h4> 음료 단품주문 </h4>
        <div class="grid">
            {#each baverges as baverge(baverge.id)}
                <button id="d" >
                    <label class="square">
                        <input type=checkbox bind:group={bevergemenu} value={baverge.cost} >
                        <img src={baverge.image} alt = "{baverge.name}사진" />
                        <p>{baverge.name} - {baverge.opencost}원</p>
                    </label>
                </button>
            {/each}
        </div>
        <p>선택 메뉴 : {Math.round(bevergesum)}</p>
 

        <button on:click={()=>{alert(`결제하실 가격은 ${Math.round(bevergesum)}입니다.`)}}>가격확인</button>
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