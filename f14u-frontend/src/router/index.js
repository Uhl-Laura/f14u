import Vue from 'vue'
import VueRouter from 'vue-router'

import WelcomePage from   '../components/WelcomePage/WelcomePage.vue'
import LoginPage from     '../components/LoginPage/LoginPage.vue'
import RegisterPage from  '../components/RegisterPage/RegisterPage.vue'
import StewardLandingPage from '../components/StewardLandingPage/StewardLandingPage.vue'
import HeaderPage from '../components/HeaderPage/HeaderPage.vue'


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
    path: '/StewardLandingPage',
    name: 'StewardLandingPage',
    component: StewardLandingPage
  },
  {
    path: '/HeaderPage',
    name: 'HeaderPage',
    component: HeaderPage
  }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
  })
  
  export default router