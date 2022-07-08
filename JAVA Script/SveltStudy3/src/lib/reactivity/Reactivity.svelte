<script>
    let name = "World"
    function changName(){
        name = "Svelte"
    }
    function recoverName(){
        name = "World"
    }
    let count = 0
    $: if (count >= 10 ) {
        alert('count is dangerously high!');
        count = 9;
    }else if(count<=-15){
        alert('count is dangerously low!;')
        count = -14;
    }
    function incrementCount(){
        ++count
    }
    function resetCount(){
        count=0
    }
    function decrementCount(){
        --count
    }
    //watch(주시한다. 계속 확인한다) ,computed
    let doubled = count*2
    $: doubled1 = count*2
    //렌더링 되는 기준은 데이터 바인딩된 식별자의 새로운 값이 대입될때


  
</script>
<div>
    
    <p>{count} doubled is {doubled}</p>
    <p>{count} doubled is {doubled1}</p>
    <button on:click={incrementCount}>Clicked {count} {count===1?"time":"times"}</button>
    <!-- times = 복수 count >1
        time count === 1  -> 들어갈 자리에 함수 넣을 수 있음
    -->
    <button on:click={resetCount}>Reset count</button>
    <button on:click={decrementCount}>Minus count</button>
</div>
<div>
    
    <button on:click={changName}>Change Name</button>
    <button on:click={recoverName}>Recover Name</button>

</div>


<h1>Hello {name}</h1>
<h1>Reactivity</h1>
