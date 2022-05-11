import Vue from 'vue'
import VueRouter from 'vue-router'

import WelcomePage from   '../components/WelcomePage/WelcomePage.vue'
import LoginPage from     '../components/LoginPage/LoginPage.vue'
import RegisterPage from  '../components/RegisterPage/RegisterPage.vue'
import HeaderPage from  '../components/HeaderPage/HeaderPage.vue'
import LandingPageDriver from  '../components/LandingPageDriver/LandingPageDriver.vue'
import LandingPageConstructor from  '../components/LandingPageConstructor/LandingPageConstructor.vue'


Vue.use(VueRouter)

  const routes = [
  {
    path: '/',
    name: 'WelcomePage',
    component: WelcomePage
  },
  {
    path: '/Login',
    name: 'Login',
    component: LoginPage
  },
  {
    path: '/Register',
    name: 'Register',
    component: RegisterPage
  },
  {
    path: '/Header',
    name: 'Header',
    component: HeaderPage
  },
  {
    path: '/LandingPageDriver',
    name: 'LandingPageDriver',
    component: LandingPageDriver
  },
  {
    path: '/LandingPageConstructor',
    name: 'LandingPageConstructor',
    component: LandingPageConstructor
  }
 
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
  })
  
  export default router