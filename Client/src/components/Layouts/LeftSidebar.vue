<template>
<!-- v-if="isAuthenticated" -->
  <v-navigation-drawer persistent
                       v-model="drawer"
                       enable-resize-watcher
                       fixed
                       width="250"
                       app>
    <v-toolbar flat color="primary" dark>
      <v-list>
        <v-list-tile style="title text-xs-center">
           <v-avatar size="42px">
              <img src="" :alt="''" />
            </v-avatar>
        </v-list-tile>
      </v-list>
    </v-toolbar>
    <v-divider></v-divider>
    <v-list>
      <div v-for="(menu, i) in menus" :key="i">
        <v-list-group
          v-if="menu.show"
          :prepend-icon="menu.icon"
        >
          <v-list-tile slot="activator">
            <v-list-tile-title>{{menu.text}}</v-list-tile-title>
          </v-list-tile>
          <div v-for="(item, j) in menu.children" :key="j">
            <v-list-tile
              v-if="item.show"
                :to="item.link"
            >
              <v-list-tile-action>
                <v-icon v-text="item.icon"></v-icon>
              </v-list-tile-action>
              <v-list-tile-title v-text="item.text"></v-list-tile-title>
            </v-list-tile>
          </div>
        </v-list-group>
      </div>
    </v-list>
  </v-navigation-drawer>
</template>

<style>
   .icon-sidebar{
     min-width: 40px !important;
   }
   .icon-sidebar .icon{
     font-size: 20px;
   }
</style>

<script lang="ts">
import Vue from 'vue'
import * as MUTATION_TYPES from '../../store/mutations'
import store from '../../store/store'
export default Vue.extend({
  name: 'LeftSidebar',
  data () {
    return {
      drawer: this.$store.state.app.drawer,
      user: this.$store.state.user.Profile
    }
  },
  watch: {
    '$store.state.app.drawer': function () {
      this.drawer = this.$store.state.app.drawer
    },
    '$store.state.user.Profile': function () {
      this.user = this.$store.state.user.Profile
    }
  },
  computed: {
    isAuthenticated () {
      // return store.state.user.AccessToken.IsAuthenticated
      return true
    },
    menus (): any {
      return [
        {
          icon: 'account_circle',
          text: 'Giới thiệu',
          link: '/gioi-thieu',
          model: true,
          show: true,
          children: [
            {
              icon: 'list',
              show: true,
              text: 'Giới thiệu',
              link: '/gioi-thieu'
            }
          ]
        },
        {
          icon: 'account_circle',
          text: 'Tổng hợp',
          model: true,
          show: true
        },
        {
          icon: 'account_circle',
          text: 'Danh mục',
          model: true,
          show: true,
          children: [
            {
              icon: 'list',
              show: true,
              text: 'Danh mục',
              link: '/danh-muc'
            }
          ]
        },
        {
          icon: 'settings',
          text: 'Hệ thống',
          model: true,
          show: true,
          children: [
            {
              icon: 'list',
              show: true,
              text: 'Quản lý nhóm người dùng',
              link: '/danh-sach-danh-muc'
            },
            {
              icon: 'list',
              show: true,
              text: 'Quản lý người dùng',
              link: '/danh-sach-danh-muc'
            }
          ]
        }
      ]
    }
  },
  methods: {
    goTo (link: any) {
      if (link !== undefined && link !== '') {
        this.$router.push(link)
      }
    },
    updateTitle (val: any) {
      store.commit('updateTitle', val)
    }
  }
})
</script>
