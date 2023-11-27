import  { createApp } from "vue";
import App from "./App.vue";
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue-next/dist/bootstrap-vue-next.css'

import "./assets/main.css";

import store from './store'

import router from './router'

const app = createApp(App)

app.use(store)

app.use(router)

app.mount('#app')