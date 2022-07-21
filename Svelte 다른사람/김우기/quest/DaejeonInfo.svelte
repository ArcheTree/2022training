<script>
    import { onMount } from "svelte";
    import src from "./image/Glowing ring.gif"

    let bus=[]
    let busInfo=[]
    onMount(async()=>{
    const res=await fetch("https://apis.data.go.kr/1613000/BusRouteInfoInqireService/getRouteNoList?serviceKey=x0KzQoj%2FBIV99brth41ohqqH0C5620X1PHjoinCE0HLzbf0J99nvL%2FZo3TCCzAbXXPr%2Bw8iS8bomh8QnO9kqpQ%3D%3D&pageNo=1&numOfRows=120&_type=json&cityCode=25")
    bus=await res.json()
    console.log(bus)
    busInfo=bus.response.body.items.item
    console.log(busInfo)
    })   
    let text="정보 없음"
</script>

<div id="d_gb_info">
    <h2>대전/계룡 버스 노선</h2>
    <div>
        {#each busInfo as info}
            <table>
                <tr>
                    <td class="tda">{info.routetp}</td>
                    <td class="tda">{info.routeno}</td>
                </tr>
                <tr>
                    <td class="tda">{info.startnodenm}</td>
                    <td class="tda">{info.endnodenm}</td>
                </tr>
                <tr>
                    <td class="tda">
                        {#if info.startvehicletime==null}
                            {text}
                        {:else}
                            {info.startvehicletime}
                        {/if}
                    </td>
                    <td class="tda">
                        {#if info.endvehicletime==null}
                            {text}
                        {:else}
                            {info.endvehicletime}
                        {/if}
                    </td>
                </tr>
            </table>
        {:else}
            <img {src} alt="loading">
        {/each} 
    </div>
</div>

<style>
    h2{
        text-align: center;
        font-size: 1.5em;
        font-weight: 900;
        letter-spacing: 10px;
    }
    table{
        border: 2px solid;
        margin: 15px;
        display: table;
        margin-left: auto;
        margin-right: auto;
        background-color: aliceblue;
    }
    td{
        border: 1px dotted;
    }
    .tda{
        width: 320px;
        font-weight: 700;
    }
    img{
        border-radius: 30px 30px 30px 30px;
    }
</style>