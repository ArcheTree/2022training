<script>
    import { onMount } from "svelte";

    let bus=[]
    let busInfo=[]
    let busStop=[]
    let stop=[]
    let bustext="정보 없음"

    onMount(async()=>{
    const res=await fetch("https://apis.data.go.kr/1613000/BusRouteInfoInqireService/getRouteNoList?serviceKey=x0KzQoj%2FBIV99brth41ohqqH0C5620X1PHjoinCE0HLzbf0J99nvL%2FZo3TCCzAbXXPr%2Bw8iS8bomh8QnO9kqpQ%3D%3D&pageNo=1&numOfRows=846&_type=json&cityCode=39")
    bus=await res.json()
    busInfo=bus.response.body.items.item
    console.log(busInfo)
    })
    onMount(async()=>{
    const res=await fetch("https://apis.data.go.kr/1613000/BusSttnInfoInqireService/getSttnNoList?serviceKey=x0KzQoj%2FBIV99brth41ohqqH0C5620X1PHjoinCE0HLzbf0J99nvL%2FZo3TCCzAbXXPr%2Bw8iS8bomh8QnO9kqpQ%3D%3D&pageNo=1&numOfRows=4076&_type=json&cityCode=39")
    busStop=await res.json()
    stop=busStop.response.body.items.item
    console.log(stop)
    })

    let a=false
    function open(){
        a=!a
        b=false
        c=false
        d=false
        e=false
        text=""
    }
    let b=false
    function open2(){
        b=!b
        a=false
        c=false
        d=false
        e=false
        text=""
    }
    let c=false
    function open3(){
        c=!c
        a=false
        b=false
        d=false
        e=false
        text=""
    }
    let d=false
    function open4(){
        d=!d
        a=false
        b=false
        c=false
        e=false
        text=""
    }
    let e=false
    function open5(){
        e=!e
        a=false
        b=false
        c=false
        d=false
        text=""
    }
    let text=""

</script>

<div>
    <div>
        <div id="seardiv">
            <h3>제주 버스</h3>
            <ul id="searul">
                <li class="searli"><button on:click="{open}">유형</button></li>
                <li class="searli"><button on:click="{open2}">번호</button></li>
                <li class="searli"><button on:click="{open3}">기점</button></li>
                <li class="searli"><button on:click="{open4}">종점</button></li>
                <li class="searli"><button on:click="{open5}">정류소</button></li>
            </ul>
        </div>
        <div id="inputdiv">
            <ul id="inputul">
                <li class="inputli">
                    {#if a}
                    <label>
                        <input type="text" bind:value="{text}" placeholder="버스 유형을 입력해주세요">
                    </label>
                    {#each busInfo as info}
                        {#if text==info.routetp}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                    {/each}             
                    {/if} 
                </li>
                <li class="inputli">
                    {#if b}
                    <label>
                        <input type="text" bind:value="{text}" placeholder="버스 번호를 입력해주세요">
                    </label>  
                    {#each busInfo as info}
                        {#if text==info.routeno}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                    {/each}           
                    {/if}
                </li>
                <li class="inputli">
                    {#if c}
                    <label>
                        <input type="text" bind:value="{text}" placeholder="기점의 이름을 입력해주세요">
                    </label>  
                    {#each busInfo as info}
                        {#if text==info.startnodenm.slice(0,1)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.startnodenm.slice(0,2)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.startnodenm.slice(0,3)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.startnodenm.slice(0,4)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.startnodenm}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                    {/each}            
                    {/if}
                </li>
                <li class="inputli">
                    {#if d}
                    <label>
                        <input type="text" bind:value="{text}" placeholder="종점의 이름을 입력해주세요">
                    </label>   
                    {#each busInfo as info}
                        {#if text==info.endnodenm.slice(0,1)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.endnodenm.slice(0,2)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.endnodenm.slice(0,3)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.endnodenm.slice(0,4)}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==info.endnodenm}
                            <table>
                                <tr>
                                    <td class="tda">{info.routetp}</td>
                                    <td class="tda">{info.routeno}</td>
                                </tr>
                                <tr>
                                    <td class="tda">{info.startnodenm}</td>
                                    <td class="tda">{info.endnodenm}</td>
                                </tr>
                            </table>
                        {/if}
                    {/each}            
                    {/if}
                <li class="inputli">
                    {#if e}
                    <label>
                        <input type="text" bind:value="{text}" placeholder="정류소의 이름을 입력해주세요">
                    </label>
                    {#each stop as station}
                        {#if text==station.nodenm.slice(0,1)}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>     
                        {/if}
                        {#if text==station.nodenm.slice(0,2)}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==station.nodenm.slice(0,3)}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==station.nodenm.slice(0,4)}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>
                        {/if}    
                        {#if text==station.nodenm.slice(0,5)}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==station.nodenm.slice(0,6)}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>
                        {/if}
                        {#if text==station.nodenm.slice(0,7)}
                        <table>
                            <tr>
                                <td class="tdb">{station.nodenm}</td>
                            </tr>
                        </table>
                        {/if}
                        {#if text==station.nodenm}
                            <table>
                                <tr>
                                    <td class="tdb">{station.nodenm}</td>
                                </tr>
                            </table>
                        {/if}
                    {/each}                              
                    {/if}               
                </li>
            </ul>
        </div>
    </div>
</div>

<style>
    #seardiv{
        display: table;
        margin-left: auto;
        margin-right: auto;
    }
    #searul{
        display: table;
        margin-left: auto;
        margin-right: auto;
        padding: 0;
    }
    .searli{
        list-style: none;
        float: left;
    }
    #inputul{
        width: 100%;
        height: 50px; 
        padding: 0;
    }
    .inputli{
        list-style: none;
        margin: 10px;     
    }
    input{
        width: 300px;
        height: 30px;
        font-size: 1em;
    }
    button{
        border-radius: 3px 3px 3px 3px;
        width: 166px;
        height: 40px;
        background-color: #e6ffff;
        font-size: 1em;
        font-weight: 700;
        letter-spacing: 5px;
    }
    button:focus{
        background-color: lightgreen;
    }
    table{
        border: 2px solid;
        margin: 10px;
        display: table;
        margin-left: auto;
        margin-right: auto;
        background-color: aliceblue;
    }
    .tda{
        width: 320px;
        border: 1px dotted;
        font-weight: 700;
    }
    .tdb{
        width: 450px;
        font-weight: 700;
    }
</style>