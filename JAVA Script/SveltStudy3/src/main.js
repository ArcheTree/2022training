import App from './App.svelte'
//.svelte - component 컴포넌트 파일이라고 한다
const app = new App({
  target: document.getElementById('app')
})

export default app
