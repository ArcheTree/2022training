<script>
    import { onMount } from "svelte";

    let busStop=[]
    let stop=[]
    let text=""
    onMount(async()=>{
    const res=await fetch("https://apis.data.go.kr/1613000/BusSttnInfoInqireService/getSttnNoList?serviceKey=x0KzQoj%2FBIV99brth41ohqqH0C5620X1PHjoinCE0HLzbf0J99nvL%2FZo3TCCzAbXXPr%2Bw8iS8bomh8QnO9kqpQ%3D%3D&pageNo=1&numOfRows=5110&_type=json&cityCode=22")
    busStop=await res.json()
    stop=busStop.response.body.items.item
    // console.log(stop)
    })

</script>

<div>
    <label>
        <input type="text" bind:value="{text}" placeholder="정류소의 정확한 이름을 입력해주세요">
        <p>{text}</p>
    </label>
    {#each stop as station}
        {#if text==station.nodenm.slice(0,1)}
            <table>
                <tr>
                    <td>정류소</td>
                    <td class="tda">{station.nodenm}</td>
                </tr>
            </table>     
        {/if}
        {#if text==station.nodenm.slice(0,2)}
            <table>
                <tr>
                    <td>정류소</td>
                    <td class="tda">{station.nodenm}</td>
                </tr>
            </table>
        {/if}
        {#if text==station.nodenm.slice(0,3)}
            <table>
                <tr>
                    <td>정류소</td>
                    <td class="tda">{station.nodenm}</td>
                </tr>
            </table>
        {/if}
        {#if text==station.nodenm.slice(0,4)}
            <table>
                <tr>
                    <td>정류소</td>
                    <td class="tda">{station.nodenm}</td>
                </tr>
            </table>
        {/if}    
        {#if text==station.nodenm.slice(0,5)}
            <table>
                <tr>
                    <td>정류소</td>
                    <td class="tda">{station.nodenm}</td>
                </tr>
            </table>
        {/if}
        {#if text==station.nodenm.slice(0,6)}
            <table>
                <tr>
                    <td>정류소</td>
                    <td class="tda">{station.nodenm}</td>
                </tr>
            </table>
        {/if}
    {/each}    
</div>

<style>
    div{
        text-align: center;
    }
</style>