<template>
    <v-card class="mx-auto" max-width="344" title="REGISTRO DE USUARIO">
      <v-container>
        <v-text-field v-model="first" color="pink-lighten-2" label="Nombre" variant="underlined"></v-text-field>
  
        <v-text-field v-model="email" color="pink-lighten-2" label="Email" variant="underlined"></v-text-field>
  
        <v-text-field v-model="password" color="pink-lighten-2" label="Constraseña" placeholder="Introduce tu contraseña" variant="underlined" type="password"></v-text-field>
  
        <v-checkbox v-model="terms" color="pink-darken-1" label=" Acepto los términos y condiciones"></v-checkbox>
      </v-container>
  
      <v-divider></v-divider>
  
      <v-card-actions>
        <v-spacer></v-spacer>
  
        <v-btn color="pink-lighten-2" @click="addUser">
          REGISTRATE
          <v-icon icon="mdi-chevron-right" end></v-icon>
        </v-btn>
        <v-btn color="pink-lighten-2" >
          <RouterLink to="/Login">
              Logeate 
          </RouterLink>
        </v-btn>
      </v-card-actions>
    </v-card>
  </template>
  
  <style scoped>
    @font-face {
      font-family: 'Lato';
      font-style: normal;
      font-weight: 900;
      src: url('https://fonts.gstatic.com/s/lato/v22/S6u9w4BMUTPHh6UVSwiPGQ3q5d0N7w.woff2') format('woff2');
    }
    .v-card {
      margin-block: 14%;
      font-family: 'Lato', sans-serif;
      text-decoration: none;
    }
  </style>
  <script setup lang="ts">
  import { ref } from 'vue';
  import {UserStore } from '../stores/userStore';
  
  const store = UserStore();
  


  const first = ref("");
  const email = ref("");
  const password = ref("");
  const terms = ref(false);  

  function addUser() {
    const user = {
      name: first.value,
      mail: email.value,
      password: password.value,
 
    };
    store.addUser(user);
  }
  </script>
  
  