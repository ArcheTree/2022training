<script>


    let size =1
    let flavours=[
        "마카다미아"
    ]

    let sizeType=[
        "싱글 레귤러",
        "더블 레귤러",
        "파인트"
    ]

    let manu=[
        "마카다미아",
        "아몬드봉봉",
        "엄마는 외계인",
        "슈팅스타",
        "피스타치오 아몬드"
    ]
    console.log(manu.join("--"))
    function getFlavours(flavours){
        if(flavours.length===1){ 
            return flavours[0]
        }else{
        return `${flavours.slice(0,-1).join(",")} 그리고 ${flavours[flavours.length-1]}`
        }
    }
</script>
<h2>Size</h2>
<label> 
    <input type=radio bind:group={size} name="Size" value={1}>
    싱글 레귤러
</label>
<label> 
    <input type=radio bind:group={size} name="Size" value={2}>
    더블 레귤러
</label>
<label> 
    <input type=radio bind:group={size} name="Size" value={3}>
    파인트
</label>

<h2>Flavours</h2>
{#each manu as flavour}
<label>
    <input type=checkbox bind:group={flavours} name = "flavours" value={flavour}>
    {flavour}
</label>
{/each}
{#if flavours.length===0}
<p>최소한 하나의 맛을 선택해 주세요</p>
{:else if flavours.length>size}
<p>사이즈를 확인해주세요</p>
{:else}
<p>
    주문하신 사이즈 : {sizeType[size-1]}<br/>
    선택한 맛 : {#each flavours as flavour}
    <span>{flavour}</span>
    {/each}<br/><br/><br/>
    선택한 맛2 : {getFlavours(flavours)}
</p>
<button>주문하기</button>
{/if}

<h1>Froupinputs</h1>