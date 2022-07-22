<script>
import buger from "../DB/buger";
import { bugercost } from "../stores";

    let bugers=[]
    let buc =[]
    

    function ad(){
        buc=buc.slice(8)
        for(let i =0 ; i <bugers.length ; i++)
        buc=buc.concat(buger[bugers[i]-1].cost)
        bugercost.update(t=>sum)
    }

function join(bugers) {
		if (bugers.length === 1) return bugers[0];
		return `${bugers.slice(0, -1).join(', ')} and ${bugers[bugers.length - 1]}`;
	}
$:sum = buc.reduce((t, n) => t + n, 0);



</script>
    
    <h4> 버거 단품 주문</h4>
    <div class="grid">
        {#each buger as buge(buge.id)}
            <button id="d"  >
                <label class="square" >
                    <input type=checkbox bind:group={bugers} value={buge.id} >
                    <img src={buge.image} alt = "{buge.name}사진" />
                    <p>{buge.name} - {buge.cost}원</p>
                </label>
            </button>
        {/each}

    </div>
    <button on:click={ad}>계산</button>
    <p>합산 금액 : {sum}</p>
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