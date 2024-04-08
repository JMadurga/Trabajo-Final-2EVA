
import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Login from '../views/Login.vue'
import pruebas from '../views/pruebasresp.vue'
import promo from '../views/Promociones.vue'
import compras from '../views/Compras.vue'
import admin from '../views/Admin.vue'
import Register from '../views/Register.vue'
import SelectionAdmin from '@/components/SelectionAdmin.vue'

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
    },
    {
      path: '/promociones',
      name: 'promociones',
      component: promo
    },
    {
      path: '/compras',
      name: 'compras',
      component: compras
    },
    {
      path: '/admin',
      name: 'admin',
      component: admin
    },
    {
      path: '/register',
      name: 'register',
      component: Register
    },
    {
      path: '/admin',
      name: 'admin',
      component: SelectionAdmin
    }


  ]
})

export default router
