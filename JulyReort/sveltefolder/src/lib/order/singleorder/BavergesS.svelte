<script>

    import baverges from "../DB/baverges";
import { bavergecost } from "../stores";
    
        let bevergemenu=[]
        let bevergename=[]

        function ad(){
            bevergename=bevergename.slice(8)
            for(let i =0 ; i <bevergemenu.length ; i++)
            bevergename=bevergename.concat(baverges[bevergemenu[i]-1].opencost)
        }
        
        function join(bevergemenu) {
            if (bevergemenu.length === 1) return bevergemenu[0];
            return `${bevergemenu.slice(0, -1).join(', ')} and ${bevergemenu[bevergemenu.length - 1]}`;
        }
        $: bevergesum = bevergename.reduce((t, n) => t + n, 0);
        $: bavergecost.update(t=>bevergesum)
        
</script>
        <h4> 음료 단품주문 </h4>
        <div class="grid">
            {#each baverges as baverge(baverge.id)}
                <button id="d" >
                    <label class="square">
                        <input type=checkbox bind:group={bevergemenu} value={baverge.id} >
                        <img src={baverge.image} alt = "{baverge.name}사진" />
                        <p>{baverge.name} - {baverge.opencost}원</p>
                    </label>
                </button>
            {/each}
        </div>
        <p>선택 메뉴 : {Math.round(bevergesum)}</p>
 
        <button on:click={ad}>계산</button>
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