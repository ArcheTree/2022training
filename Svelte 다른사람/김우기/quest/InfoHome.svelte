<script>
    import {Link} from "svelte-routing"

    import src from "./image/bus-g5abd6b404_640.png"
    function exit(){
        if(!confirm("종료하시겠습니까>")){
        }else{
            alert("종료합니다.");
        }
    }
</script>

<div id="frame">
    <div id="frame2">
        <h1>버스  TAGO</h1>
        <div id="main">
            <img {src} alt="버스 이미지">
            <div id="path">
                <ul>
                    <li><Link to="infomation"><button>노선 정보</button></Link></li>
                    <li><Link to="search"><button>찾기</button></Link></li>
                    <li><Link to="option"><button>설정</button></Link></li>
                    <li><button on:click="{exit}">종료</button></li>
                </ul>
            </div>
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
        background: -moz-linear-gradient(-45deg,  #b8e1fc 0%, #a9d2f3 10%, #90bae4 25%, #90bcea 37%, #90bff0 50%, #6ba8e5 66%, #6ba8e5 66%, #a2daf5 83%, #bdf3fd 100%); /* FF3.6-15 */
		background: -webkit-linear-gradient(-45deg,  #b8e1fc 0%,#a9d2f3 10%,#90bae4 25%,#90bcea 37%,#90bff0 50%,#6ba8e5 66%,#6ba8e5 66%,#a2daf5 83%,#bdf3fd 100%); /* Chrome10-25,Safari5.1-6 */
		background: linear-gradient(135deg,  #b8e1fc 0%,#a9d2f3 10%,#90bae4 25%,#90bcea 37%,#90bff0 50%,#6ba8e5 66%,#6ba8e5 66%,#a2daf5 83%,#bdf3fd 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */	
    }
    #main{
        text-align: center;
    }
    h1{
        text-align: center;
        font-size: 3.5em;
        font-weight: 900;
        letter-spacing: 25px;
        margin-top: 0;
        margin-bottom: 20px;
    }
    img{
        width: 600px;
        height: 300px;
        display: table;
        margin-left: auto;
        margin-right: auto;
    }
    ul{
        padding: 0;
    }
    li{
        list-style: none;
        margin: 30px;
        align-content: center;
    }
    button{
        border-radius: 15px 15px 15px 15px;
        font-size: 2em;
        font-weight: 900;
        width: 400px;
        height: 75px;
        background-color: #e6e6ff;
        box-shadow: 5px 5px 5px #0033cc;
    }
</style>