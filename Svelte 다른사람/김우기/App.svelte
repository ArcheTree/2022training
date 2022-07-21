<script>
    import {Router, Route} from "svelte-routing"
    import InfoHome from "./lib/quest/InfoHome.svelte";
    import InfoFirst from "./lib/quest/InfoFirst.svelte";
    import Search from "./lib/quest/Search.svelte";
    import Option from "./lib/quest/Option.svelte";
    export let url=""

</script>

<Router url={url}>
    <!-- <nav>
        <Link to="/">Home</Link>
        <Link to="infomation">Infomation</Link>
        <Link to="search">Search</Link>
        <Link to="option">Option</Link>
        <Link to="/">Exit</Link>
    </nav> -->
    <div>
        <Route path="home" component={InfoHome}><InfoHome/></Route>
        <Route path="infomation" component={InfoFirst}></Route>
        <Route path="search" component={Search}></Route>
        <Route path="option" component={Option}></Route>
        <Route path="/"><InfoHome/></Route>
    </div>
</Router>


<style>

</style>
