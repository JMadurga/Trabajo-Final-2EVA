
import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Login from '../views/Login.vue'
import pruebas from '../views/pruebasresp.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'Principal',
      component: HomeView
    },
    {
      path: '/Login',
      name: 'Login',
      component: Login
    },
    {
      path: '/pruebas',
      name: 'prueba',
      component: pruebas
    }
  ]
})

export default router
