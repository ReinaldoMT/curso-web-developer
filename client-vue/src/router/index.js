import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Customer from '@/components/Customer'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/customers',
      name: 'Customer',
      component: Customer
    }
  ]
})
