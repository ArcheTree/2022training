<script>
    import {Link} from "svelte-routing"
    import DaeguSearch from "./DaeguSearch.svelte"
    import DaejeonSearch from "./DaejeonSearch.svelte"
    import GwangjuSearch from "./GwangjuSearch.svelte"
    import IncheonSearch from "./IncheonSearch.svelte"
    import UlsanSearch from "./UlsanSearch.svelte"
    import JejuSearch from "./JejuSearch.svelte"
    import src from "./image/bus-g5abd6b404_640.png"

    let a=false
    let b=false
    let c=false
    let d=false
    let e=false
    let f=false

    function dgop(){
        a=!a
        b=false
        c=false
        d=false
        e=false
        f=false
    }
    function icop(){
        b=!b
        a=false
        c=false
        d=false
        e=false
        f=false
    }
    function gjop(){
        c=!c
        a=false
        b=false
        d=false
        e=false
        f=false
    }
    function d_gop(){
        d=!d
        a=false
        b=false
        c=false
        e=false
        f=false
    }
    function ulop(){
        e=!e
        a=false
        b=false
        c=false
        d=false
        f=false
    }
    function jjop(){
        f=!f
        a=false
        b=false
        c=false
        d=false
        e=false
    }
</script>

<div id="frame">
    <div id="reg_sel">
        <h1>버스 찾기</h1>
        <ul>
            <li><button on:click="{dgop}">대구</button></li>
            <li><button on:click="{icop}">인천</button></li>
            <li><button on:click="{gjop}">광주</button></li>
            <li><button on:click="{d_gop}">대전/계룡</button></li>
            <li><button on:click="{ulop}">울산</button></li>
            <li><button on:click="{jjop}">제주</button></li>
            <li><Link to="home"><button>돌아가기</button></Link></li>
        </ul>
        {#if !a && !b && !c && !d && !e && !f}
            <img {src} alt="버스 이미지">
        {/if}
        <div id="reg_info">
            {#if a}
                <DaeguSearch/>
            {:else if b}
                <IncheonSearch/>
            {:else if c}
                <GwangjuSearch/>
            {:else if d}
                <DaejeonSearch/>
            {:else if e}
                <UlsanSearch/>
            {:else if f}
                <JejuSearch/>
            {/if}
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
    #reg_sel{
        text-align: center;
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
    h1{
        text-align: center;
        font-size: 3em;
        font-weight: 900;
        letter-spacing: 20px;
        margin-top: 0;
    }
    #reg_info{
        width: 100%;
        height: 100%;
        text-align: center;
        align-content: center;
    }
    ul{
        display: table;
        margin-left: auto;
        margin-right: auto;
        padding: 0;
    }
    li{
        list-style: none;
        float: left;
    }
    button{
        border-radius: 3px 3px 3px 3px;
        width: 160px;
        height: 50px;
        background-color: #e6e6ff;
        font-size: 1.2em;
        font-weight: 700;
        letter-spacing: 5px;
        box-shadow: 5px 5px 5px #0033cc;
    }
    button:focus{
        background-color: #ffffcc;
    }
    img{
        width: 700px;
        height: 600px;
        display: table;
        margin-top: 60px;
        margin-left: auto;
        margin-right: auto;
        opacity: 0.3;
    }
</style>