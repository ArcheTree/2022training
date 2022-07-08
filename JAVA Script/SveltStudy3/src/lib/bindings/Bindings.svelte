<script>
    let name = "World"
    //양방향 바인딩 : 'bind:'
    let a=1
    let b=2

    let yes = false
    let mustyes = false
</script>

<lable>
    <input type=checkbox bind:checked  = {mustyes} />
    <p>[필수]가입을 위한 개인정보 확인에 동의하십니다.</p>
</lable>
<button disabled={!mustyes}>
    Next
</button><br/>
<lable>
    <input type=checkbox bind:checked  = {yes} />
    <p>[선택]마케팅 활용에 동의 하십니까.</p>
</lable>
{#if yes}
<p>광고문자나 홍보 전화가 갈 수 있습니다.</p>
{:else}
<p>마케팅 행사(할인쿠폰등등)나 정보를 받으 실수없습니다.</p>
{/if}

<p>{a} + {b} = {a+b}</p>
<label>
    A<input type = "number" bind:value={a}> 
    <input type = "range" bind:value={a} min=0 max=10> 
</label>
<label>
    B<input type = "number" bind:value={b}> 
    <input type = "range" bind:value={b} min=0 max=10> 
</label>
    <br/><br/><br/><br/>
<input bind:value={name}>

<h1>Hello {name}</h1>
<h1>binding page</h1>

<style>
    label{
        display: flex;
    }
    input,p{
        margin:6px;
    }
</style>