import Vue from 'vue'
import VueRouter from 'vue-router'

import WelcomePage from '../components/WelcomePage/WelcomePage.vue'
import LoginPage from '../components/LoginPage/LoginPage'

Vue.use(VueRouter)

  const routes = [
  {
    path: '/',
    name: 'WelcomePage',
    component: WelcomePage
  },
  {
    path: '/login',
    name: 'Login',
    component: LoginPage
  }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
  })
  
  export default router