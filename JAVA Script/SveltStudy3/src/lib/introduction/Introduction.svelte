<script>
//data.binding
    //document.getElementById("greeting").textContent="Hellow Svelte"
    let name = "world" //h1 이용
    import src from "../../assets/image.gif" //img 이용
import Nested from "./Nested.svelte"
    console.log(src) //img 이용
    let danceManName = "Rick Astley"
        //컴포넌트 코드가 html 변환 =>렌더링(Rendering)
        let string = `This string conains some <strong>HTML!</string>`
           


</script>

<p>{string}</p>
<p>{@html string}</p>
<!-- @html 쓰면 html 문법 적용 -->
<h1>Introduction</h1>
<h1>Hellow {name. toUpperCase()}</h1>
<!--<img src={src} alt = "dancing of {danceManName}" />
    속성과 식별자가 같을 떄 속성 생략 가능-->
    <img {src} alt="dancing of {danceManName}" />


    <p>This is a paragraph.</p>
    <Nested />
    <!--Nested></Nested--> 
   
<style>
    h1 {
        color : #0066ff;
    }
    img:hover{
        transform : scale(1.5)
    }
    p {
        color :  brown;
        font-family : "Comic Sans MS",cursive;
        font-size: 2em;
    }
</style>