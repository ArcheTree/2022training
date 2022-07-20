<script>
import buger from "../DB/buger";

    let bugers=[]
    let buc =[]
    let i

function join(bugers) {
		if (bugers.length === 1) return bugers[0];
		return `${bugers.slice(0, -1).join(', ')} and ${bugers[bugers.length - 1]}`;
	}
$: sum = bugers.reduce((t, n) => t + n, 0);


</script>
    
    <h4> 버거 단품 주문</h4>
    <div class="grid">
        {#each buger as buge(buge.id)}
            <button id="d"  >
                <label class="square" >
                    <input type=checkbox bind:group={bugers} value={buge.cost}  >
                    <img src={buge.image} alt = "{buge.name}사진" />
                    <p>{buge.name} - {buge.cost}원</p>
                </label>
            </button>
        {/each}

    </div>
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