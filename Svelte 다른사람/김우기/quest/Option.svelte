<script>
    import {Link} from "svelte-routing"

    let a=false
    let onoff="on"
    function check(){
        a=!a
        b=false
        c=false
        d=false
    }
    let b=false
    let num=5
    function check2(){
        b=!b
        a=false
        c=false
        d=false
    }
    let c=false
    function check3(){
        c=!c
        a=false
        b=false
        d=false
    }
    let d=false
    function check4(){
        d=!d
        a=false
        b=false
        c=false
    }
    const change=['h1','h2','h3','h4','h5','p']
    let selected=change[2]
</script>

<div id="frame">
    <div id="frame2">
        <div id="main">
            <ul>
                <li class="bli"><button class="m_but" on:click="{check}">알림</button></li>
                {#if a}
                <ul>
                    <li class="sli"><button class:a_but="{onoff==='on'}" on:click="{() => onoff = 'on'}">ON</button></li>
                    <li class="sli"><button class:a_but="{onoff==='off'}" on:click="{() => onoff = 'off'}">OFF</button></li>
                </ul>
                {/if}
                <li class="bli"><button class="m_but" on:click="{check2}">소리</button></li>
                {#if b}
                    <label>
                        <input id="soundr" type="range" bind:value="{num}" min=0 max=10>
                        <input id="soundn" type="number" bind:value="{num}" min=0 max=10>
                    </label>
                {/if}
                <li class="bli"><button class="m_but" on:click="{check3}">글자</button></li>
                {#if c}
                <select id="size" bind:value={selected}>
                    {#each change as chan}
                        <option value={chan}>{chan}</option>
                    {/each}
                </select>
                <svelte:element this={selected}>I'm a {selected}</svelte:element>
                {/if}
                <li class="bli"><button class="m_but" on:click="{check4}">정보</button></li>
                {#if d}
                <form>
                    <p>본 어플리케이션은 대구, 인천, 광주, 대전/계룡, 울산, 제주의 버스노선과 정류소 기본 정보를 제공하며 이외 지역의 버스노선과 정류소의 기본 정보는 추후 업데이트될 예정입니다.</p>
                    <table id="infomation">
                        <tr>
                            <td>version</td>
                            <td>1.0.0</td>
                        </tr>
                        <tr>
                            <td>개발자</td>
                            <td>김우기</td>
                        </tr>
                        <tr>
                            <td rowspan="3">정보 제공처</td>
                            <td>공공데이터포털</td>          
                        </tr>
                        <tr>
                            <td><a href=https://www.data.go.kr/data/15098529/openapi.do target="_blank">노선 링크</a></td>
                        </tr>
                        <tr>
                            <td><a href=https://www.data.go.kr/data/15098534/openapi.do target="_blank">정류소 링크</a></td>
                        </tr>
                    </table>
                </form>
                {/if}
                <li class="bli"><Link to="home"><button class="m_but">돌아가기</button></Link></li>
            </ul>
        </div>
    </div>
</div>

<style>
    div{
        font-family: Arial, Helvetica, sans-serif;
    }
    #frame{
        position: absolute;
		display: flex;
		align-items: center;
		justify-content: center;
		width: 100%;
		height: 100%;
		top: 0;
		left: 0;
    }
    #frame2{
        position: relative;
		display: flex;
		flex-direction: column;
		width: 60%;
		height: 85%;
		border: 2vmin solid #ccebff;
        background-color: #e6f5ff;
		border-bottom-width: 3vmin;
		padding: 3vmin;
		border-radius: 2vmin;
        overflow-y: auto;
        background: -moz-linear-gradient(-45deg,  #b8e1fc 0%, #a9d2f3 10%, #90bae4 25%, #90bcea 37%, #90bff0 50%, #6ba8e5 66%, #6ba8e5 66%, #a2daf5 83%, #bdf3fd 100%); /* FF3.6-15 */
		background: -webkit-linear-gradient(-45deg,  #b8e1fc 0%,#a9d2f3 10%,#90bae4 25%,#90bcea 37%,#90bff0 50%,#6ba8e5 66%,#6ba8e5 66%,#a2daf5 83%,#bdf3fd 100%); /* Chrome10-25,Safari5.1-6 */
		background: linear-gradient(135deg,  #b8e1fc 0%,#a9d2f3 10%,#90bae4 25%,#90bcea 37%,#90bff0 50%,#6ba8e5 66%,#6ba8e5 66%,#a2daf5 83%,#bdf3fd 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */	
    }
    #main{
        width: 100%;
        height: 100%;
        display: table;
        margin-left: auto;
        margin-right: auto;
        text-align: center;
        margin-top: 60px;
    }
    .m_but{
        width: 300px;
        height: 80px;
        font-size: 1.8em;
        font-weight: 700;
        border-radius: 15px 15px 15px 15px;
        letter-spacing: 12px;
        background-color: #e6e6ff;
        box-shadow: 5px 5px 5px #0033cc;
    }
    .bli{
        list-style: none;
        margin: 50px;
    }
    ul{
        display: table;
        margin-left: auto;
        margin-right: auto;
        padding: 0;
    }
    .sli{
        list-style: none;
        float: left;
    }
    .sli > button{
        display: block;
        width: 150px;
        height: 50px;
        font-size: 1.2em;
        border-radius: 15px 15px 15px 15px;
    }
    .a_but{
        width: 150px;
        height: 50px;
        font-size: 1.2em;
        font-weight: 600;
        border-radius: 10px 10px 10px 10px;
        background-color: #ff3e00;
        color: white;
    }
    #soundr{
        width: 180px;
        height: 30px;
    }
    #soundn{
        width: 80px;
        height: 30px;
        font-size: 1.5em;
    }
    #size{
        width: 200px;
        height: 30px;
        font-size: 1.2em;
    }
    form{
        width: 300px;
        height: 200px;
        background-color: aliceblue;
        display: table;
        margin-left: auto;
        margin-right: auto;
    }
    a{
        text-decoration: none;
    }
    a:visited{
        color: black;
    }
    table{
        display: table;
        margin-left: auto;
        margin-right: auto;
    }
    td{
        border: 1px dotted;
        width: 150px;
    }
</style>