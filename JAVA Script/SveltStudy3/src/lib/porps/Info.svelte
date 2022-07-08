<script>
    export let name
    export let verson
    export let speed
    export let website

</script>
<p>
    The <code>{name}</code> package is {speed} fast
    Download version {verson} from
    <a href = "https://www.npmjs.com/package/{name}">
        npm
    </a>
    and <a href = {website}>learn more here</a>
</p>
<code>
    글꼴도 콘솔 글꼴처럼 나온다
    엔터
</code>
<pre>
    입력한 대로 자유롭게 보여두는 태그
    
    줄바꿈도 가능하며 태그도 그대로 표현
</pre>
<h1>Information</h1>