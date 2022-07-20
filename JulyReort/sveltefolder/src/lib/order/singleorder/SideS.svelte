<script>

    import sides from "../DB/sides";
    
        let sidemenu=[]
        let addsidcost = 0
        let sidecost =0
        let payment
    
        function refundadd(itemcost){
            addsidcost = itemcost
            sidecost = (sidecost-addsidcost)
            return sidecost
        }
        function join(sidemenu) {
            if (sidemenu.length === 1) return sidemenu[0];
            return `${sidemenu.slice(0, -1).join(', ')} and ${sidemenu[sidemenu.length - 1]}`;
        }
        $: sidessum = sidemenu.reduce((t, n) => t + n, 0);
        
        
        
       
   
    </script>
        <h4> 사이드 단품주문 </h4>
        <div class="grid">
            {#each sides as side(side.id)}
                <button id="d" >
                    <label class="square">
                        <input type=checkbox bind:group={sidemenu} value={side.cost}  >
                        <img src={side.image} alt = "{side.name}사진" />
                        <p>{side.name} - {side.opencost}원</p>
                    </label>
                </button>
            {/each}
        </div>
        
        <p>합산금액: {Math.round(sidessum)}</p>


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