import Vue from 'vue'
import App from './App.vue'

import 'primevue/resources/themes/nova/theme.css';
import 'primevue/resources/primevue.min.css';
import 'primeicons/primeicons.css';

import WelcomePage from './components/WelcomePage/WelcomePage.vue'
import LoginPage from './components/LoginPage/LoginPage.vue'
import router from './router'

import Button from 'primevue/button';


Vue.config.productionTip = false
Vue.component("WelcomePage", WelcomePage);
Vue.component("LoginPage", LoginPage); 
Vue.component("PrimeButton", Button);


new Vue({
  router,
  render: h => h(App),
}).$mount('#app')