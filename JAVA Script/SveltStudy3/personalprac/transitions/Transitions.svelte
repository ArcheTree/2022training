<script>
import { elasticOut } from "svelte/easing";

import { fade} from "svelte/transition";

let visiable = true

// function spin(node,{duration}){
//     return{
//         duration,
//         CSS:t =>{
//             const eased = elasticOut(t)
//             return `transform:scale(${eased}) rotate(${eased*1080}deg);
//                     color: hsl(
//                         ${Math.trunc(t*360)},
//                         ${Math.min(100,1000-100*t)}%,
//                         ${Math.min(50,500-500*t)}%
//                         )`
//         }
//      }
// }


function typewriter(node, { speed = 1 }) {
    const valid =(
        node.childNodes.length===1 &&
        node.childNodes[0].nodeType ===Node.TEXT_NODE
    )
    if(!valid){
        throw new Error(`This trasition only works on elements with a single text node child`)
    }
    const text = node.textConstent;
    const duration = (text.length/(speed * 0.01))
    return {
        duration,
        tick: t =>{
            const i = Math.trunc(text.length*t);
            node.textContent = text.slice(0,i)
        }
    };
}


</script>
<label>
<input type="checkbox" bind:checked ={visiable}>
visiable
</label>

{#if visiable}
	<p transition:typewriter>
		The quick brown fox jumps over the lazy dog
	</p>
{/if}



