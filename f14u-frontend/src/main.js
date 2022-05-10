import Vue from 'vue'
import App from './App.vue'

import 'primevue/resources/themes/nova/theme.css';
import 'primevue/resources/primevue.min.css';
import 'primeicons/primeicons.css';
import 'vue-good-table/dist/vue-good-table.css'

import WelcomePage from   './components/WelcomePage/WelcomePage.vue'
import LoginPage from     './components/LoginPage/LoginPage.vue'
import RegisterPage from  './components/RegisterPage/RegisterPage.vue'
import StewardLandingPage from './components/StewardLandingPage/StewardLandingPage.vue'
import HeaderPage from './components/HeaderPage/HeaderPage.vue'
import VueGoodTablePlugin from 'vue-good-table';
import router from './router'
import Dialog from 'primevue/dialog'

import Button from 'primevue/button';
import Card from 'primevue/card';
import InputText from 'primevue/inputtext';
import Password from 'primevue/password';
<<<<<<< HEAD
import CascadeSelect from 'primevue/cascadeselect';
import StewardPopup from './components/StewardPopup/StewardPopup.vue'
=======
import Dropdown from 'primevue/dropdown';
import CarPopup from './components/CarPopup/CarPopup.vue'
import Dialog from 'primevue/dialog'
>>>>>>> b88ce641c8ca2fb2f5a0a8080531ce9ac497f516

Vue.config.productionTip = false
Vue.component("WelcomePage", WelcomePage);
Vue.component("LoginPage", LoginPage); 
Vue.component("RegisterPage",RegisterPage);
Vue.component("PrimeButton", Button);
Vue.component("PrimeCard", Card);
Vue.component("InputText",InputText);
Vue.component("PrimePassword",Password);
<<<<<<< HEAD
Vue.component("CascadeSelect",CascadeSelect);
Vue.component("StewardLandingPage",StewardLandingPage);
Vue.component("HeaderPage",HeaderPage);
Vue.component("StewardPopup", StewardPopup);
Vue.component("PrimeDialog", Dialog);
Vue.use(VueGoodTablePlugin);
=======
Vue.component("PrimeDropdown",Dropdown);
Vue.component("CarPopup", CarPopup);
Vue.component("PrimeDialog", Dialog);
>>>>>>> b88ce641c8ca2fb2f5a0a8080531ce9ac497f516

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')