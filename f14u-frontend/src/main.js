import Vue from 'vue'
import App from './App.vue'

import 'primevue/resources/themes/nova/theme.css';
import 'primevue/resources/primevue.min.css';
import 'primeicons/primeicons.css';

import WelcomePage from   './components/WelcomePage/WelcomePage.vue'
import LoginPage from     './components/LoginPage/LoginPage.vue'
import RegisterPage from  './components/RegisterPage/RegisterPage.vue'
import router from './router'
import HeaderPage from  './components/HeaderPage/HeaderPage.vue'

import Button from 'primevue/button';
import Card from 'primevue/card';
import InputText from 'primevue/inputtext';
import Password from 'primevue/password';
import CascadeSelect from 'primevue/cascadeselect';
import CarPopup from './components/CarPopup/CarPopup.vue'
import Dialog from 'primevue/dialog'
import Dropdown from 'primevue/dropdown';
import VueGoodTablePlugin from 'vue-good-table';
import 'vue-good-table/dist/vue-good-table.css'
import StewardPopup from './components/StewardPopup/StewardPopup.vue';
import DriverChange from './components/DriverChange/DriverChange.vue';

Vue.config.productionTip = false
Vue.use(VueGoodTablePlugin)
Vue.component("HeaderPage", HeaderPage);
Vue.component("WelcomePage", WelcomePage);
Vue.component("LoginPage", LoginPage); 
Vue.component("RegisterPage",RegisterPage);
Vue.component("PrimeButton", Button);
Vue.component("PrimeCard", Card);
Vue.component("InputText",InputText);
Vue.component("PrimePassword",Password);
Vue.component("CascadeSelect",CascadeSelect);
Vue.component("CarPopup", CarPopup);
Vue.component("PrimeDialog", Dialog);
Vue.component("PrimeDropdown", Dropdown);
Vue.component("StewardPopup", StewardPopup);
Vue.component("DriverChange",DriverChange);
new Vue({
  router,
  render: h => h(App),
}).$mount('#app')