<script>

    let value = "HTML도 작성가능"
    let answer = ""
    let selected
    let questions = [
        {id : 1, text : `초등학교 명은?`},
        {id : 2, text : `어머니 성함이?`},
        {id : 3, text : `반려동물 이름은?`}
    ]
    // 실질적인 APP은 '페치' 라이브러리로 DB에서 받아옴

    function handleSubmit(){
        alert(`질문 : ${selected.id}, ${selected.text}
             답 : ${answer}`)
    }
    function initSelect(){
        console.log(selected)
        answer=""
    }
    const list=[
        {id:1, text:"A"},
        {id:2, text:"B"},
        {id:3, text:"C"}
    ]
    let selList=[]
    let html="Hello World!!"
</script>
<div contenteditable="true" bind:innerHTML={html}></div>
<h1 contenteditable="true" bind:innerHTML={html}></h1>

<select multiple bind:value={selList}>
    {#each list as item}
        <option value = {item}>{item.text}</option>
    {/each}
</select>
{#each selList as selItem}
    <p>{selItem.text}</p>
    
{/each}


<form on:submit|preventDefault={handleSubmit}>
    <select bind:value={selected} on:change={initSelect}>
        {#each questions as question}
            <option value={question}>
                {question.text}
            </option>
        {/each}
    </select>
    <input bind:value={answer}>
    <input type=submit disabled={!answer}>
</form>

<p>{@html value}</p>
<textarea bind:value></textarea>
<h1>Binding 2</h1>

<style>
    textarea{
        width: 100%;
        height: 300px;
    }
    input, select{
        display : block;
        margin : 10px;
    }
</style>