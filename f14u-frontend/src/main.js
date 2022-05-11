import Vue from 'vue'
import App from './App.vue'

import 'primevue/resources/themes/nova/theme.css';
import 'primevue/resources/primevue.min.css';
import 'primeicons/primeicons.css';
import 'vue-good-table/dist/vue-good-table.css'

import WelcomePage from   './components/WelcomePage/WelcomePage.vue'
import LoginPage from     './components/LoginPage/LoginPage.vue'
import RegisterPage from  './components/RegisterPage/RegisterPage.vue'
import StewardLandingPage from './components/StewardLandingPage/StewardLandingPage';
import HeaderPage from './components/HeaderPage/HeaderPage.vue'
import router from './router'
import VueGoodTablePlugin from 'vue-good-table';

import Button from 'primevue/button';
import Card from 'primevue/card';
import InputText from 'primevue/inputtext';
import Password from 'primevue/password';
import Dropdown from 'primevue/dropdown';
import CarPopup from './components/CarPopup/CarPopup.vue'
import StewardPopup from './components/StewardPopup/StewardPopup.vue'
import Dialog from 'primevue/dialog'
import CascadeSelect from 'primevue/cascadeselect';

Vue.config.productionTip = false
Vue.component("HeaderPage",HeaderPage);
Vue.component("WelcomePage", WelcomePage);
Vue.component("LoginPage", LoginPage); 
Vue.component("RegisterPage",RegisterPage);
Vue.component("StewardLandingPage", StewardLandingPage);
Vue.component("PrimeButton", Button);
Vue.component("PrimeCard", Card);
Vue.component("InputText",InputText);
Vue.component("PrimePassword",Password);
Vue.component("PrimeDropdown",Dropdown);
Vue.component("CascadeSelect",CascadeSelect);
Vue.component("CarPopup", CarPopup);
Vue.component("StewardPopup", StewardPopup);
Vue.component("PrimeDialog", Dialog);
Vue.use(VueGoodTablePlugin);

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')