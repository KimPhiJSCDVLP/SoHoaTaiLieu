import Vue from 'vue'
import Router, { Route } from 'vue-router'
import store from './store/store'
import { HTTP } from '@/HTTPServices'
import Home from './components/Home.vue'
import NotFoundComponent from './components/NotFound.vue'
import Login from './components/Login/Login.vue'
import DanhSachDanhMuc from './components/DanhMuc/DanhSachDanhMuc.vue'
import DanhSachGioiThieu from './components/GioiThieu/DanhSachGioiThieu.vue'
Vue.use(Router)
export default new Router({
  routes: [
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
      path: '/',
      name: 'Home',
      component: Home
      // beforeEnter: guardRoute
    },
    {
      path: '/gioi-thieu',
      name: 'DanhSachGioiThieu',
      component: DanhSachGioiThieu
      // beforeEnter: guardRoute
    },
    {
      path: '/danh-muc',
      name: 'DanhSachDanhMuc',
      component: DanhSachDanhMuc
      // beforeEnter: guardRoute
    },
    { path: '*', component: NotFoundComponent }
  ]
})
function guardRoute (to: Route, from: Route, next: any): void {
  const isAuthenticated = store.state.user && store.state.user.AccessToken ? store.state.user.AccessToken.IsAuthenticated : false
  if (!isAuthenticated) {
    next({
      path: '/login',
      query: {
        redirect: to.fullPath
      }
    })
  } else {
    HTTP.get('/auth/validate-token/')
      .then(response => {
        next()
      })
      .catch(e => {
        store.commit('CLEAR_ALL_DATA')
        next({
          path: '/login',
          query: {
            redirect: to.fullPath
          }
        })
      })
  }
}
