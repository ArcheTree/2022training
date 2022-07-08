console.log("7/5예제 연습")



// const 구름 = {
//     이름 : "구름",
//     나이 : 6,
//     종족 : "강아지"
// }

// const  별 = {...구름,
// 이름 : "별",
// 나이 : 1
// }

// console.log(JSON.stringify(구름))
// console.log(JSON.stringify(별))

document.addEventListener("DOMContentLoaded",()=>{
    document.getElementById("justh1").innerText = "hellow Dom"     
    })

function prac (){
    const header = document.querySelectorAll("h1")

    header.forEach((header) => {
        
        header.textContent = "HEADERS!!!"
        header.style.color = "white"
        header.style.backgroundColor = "black"
        header.style.padding = "10px"
    });


}
prac()


