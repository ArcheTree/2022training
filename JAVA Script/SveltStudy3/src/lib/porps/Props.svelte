<script>
    import Nested from "./Nested.svelte"
    import Info from "./Info.svelte"


//props = 부모 컴포넌트에서 자식 컴포넌트에 데이터를 넘기는것

const pkg={
    name:"svelte",
    verson:3,
    speed : "blazing",
    website:"https://svelte.dev"
}
</script>

<h1>Props</h1>
<!--Nested answer ={23}/-->
<Nested />
<Nested answer="'DO your self'"/>

<Info name={pkg.name} verson={pkg.verson} speed={pkg.speed} website={pkg.website}/>
<Info {...pkg} />
