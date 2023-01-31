import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'
import VueAxios from 'vue-axios'
import axios from 'axios'


Vue.config.productionTip = false

// JS de bootstrap
Vue.use(BootstrapVue)
Vue.use(IconsPlugin)
// axios
Vue.use(VueAxios, axios)

// CSS de bootstrap
// Import Bootstrap and BootstrapVue CSS files (order is important)
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
