<!-- Footer.vue -->
<template>
  <v-app>
    <v-footer dark padless>
      <v-card flat tile width="100%" class="primary white--text text-center">
        <v-card-text>
          <h1 class="pb-2 white--text" style="margin-block: 20px;"> You can find us at</h1>
          <a target="_blank" v-bind:href="social.url" v-for="social in socials" :key="social.name">
            <v-btn class="mx-4 white--text" icon style="margin-bottom: 20px;">
              <v-icon size="24px">{{ social.icon }}</v-icon>
            </v-btn>
          </a>
        </v-card-text>

        <v-expansion-panels>
          <v-expansion-panel
            v-for="i in items"
          >
            <v-expansion-panel-title expand-icon="mdi-menu-down">
              {{ i.name }}
            </v-expansion-panel-title>
            <v-expansion-panel-text>
              {{ i.tags }}
            </v-expansion-panel-text>
          </v-expansion-panel>
        </v-expansion-panels>

        <v-divider></v-divider>

        <v-card-text class="white--text">
          Copyright 1993 - {{ new Date().getFullYear() }} |
          <a class="white--text" href="https://codepen.io/jettaz" style="color: white;">Teatro Dos Facetas</a>
        </v-card-text>
      </v-card>
    </v-footer>
  </v-app>
</template>

<script setup lang="ts">
import { ref } from 'vue';

const panel = ref<number[]>([]);
const socials = [
  { name: "facebook", icon: "mdi-facebook", url: "https://codepen.io/jettaz" },
  { name: "twitter", icon: "mdi-twitter", url: "https://codepen.io/jettaz" },
  { name: "google", icon: "mdi-google", url: "https://codepen.io/jettaz" },
  { name: "linkedin", icon: "mdi-linkedin", url: "https://codepen.io/jettaz" },
  { name: "instagram", icon: "mdi-instagram", url: "https://codepen.io/jettaz" }
];
const items = [
  {
    name: "Obras",
    tags: [
      { urlname: "Mas vistos", url: "https://codepen.io/jettaz" },
      { urlname: "Estrenos", url: "https://codepen.io/jettaz" },
      { urlname: "Proximamente", url: "https://codepen.io/jettaz" }
    ]
  },
  {
    name: "Empresa",
    tags: [
      { urlname: "Sobre nosotros", url: "https://codepen.io/jettaz" },
      { urlname: "Soporte", url: "https://codepen.io/jettaz" },
      { urlname: "FAQ", url: "https://codepen.io/jettaz" }
    ]
  },
  {
    name: "Recursos",
    tags: [
      { urlname: "Blog", url: "https://codepen.io/jettaz" },
      { urlname: "Trabaja con nosotros", url: "https://codepen.io/jettaz" }
    ]
  },
  {
    name: "Ayuda",
    tags: [
      { urlname: "Atención al cliente", url: "https://codepen.io/jettaz" },
      { urlname: "Contacto", url: "https://codepen.io/jettaz" },
      { urlname: "Políticas de privacidad", url: "https://codepen.io/jettaz" },
      { urlname: "Términos y condiciones", url: "https://codepen.io/jettaz" },
      { urlname: "Inicio", url: "https://codepen.io/jettaz" }
    ]
  }
];
</script>

<style scoped>

.v-footer {
  background: rgba(62,78,98,1);
  flex: 1 1 auto;
}

.v-card-text {
  background: rgba(34,46,67,1);
  color: white;
}

.v-expansion-panels {
  padding-inline: 200px;
  background: rgba(34,46,67,1);
  padding-bottom: 20px;
}

</style>


   <!--
    const panel = [{}]
const socials = [
        { name: "facebook", icon: "mdi-facebook-box", url: "https://codepen.io/jettaz" },
        { name: "twitter", icon: "mdi-twitter-box", url: "https://codepen.io/jettaz" },
        { name: "google", icon: "mdi-google", url: "https://codepen.io/jettaz" },
        { name: "linkedin", icon: "mdi-linkedin-box", url: "https://codepen.io/jettaz" },
        { name: "instagram", icon: "mdi-instagram", url: "https://codepen.io/jettaz" }
      ]

const items = [
        {
          name: "Product",
          tags: [
            { urlname: "Create Websites", url: "https://codepen.io/jettaz" },
            { urlname: "Secure Cloud Hosting", url: "https://codepen.io/jettaz" },
            { urlname: "Engage Your Audience", url: "https://codepen.io/jettaz" },
            { urlname: "Website Support", url: "https://codepen.io/jettaz" }
          ]
        },
        {
          name: "Company",
          tags: [
            { urlname: "About", url: "https://codepen.io/jettaz" },
            { urlname: "Careers", url: "https://codepen.io/jettaz" },
            { urlname: "Support", url: "https://codepen.io/jettaz" },
            { urlname: "Pricing", url: "https://codepen.io/jettaz" },
            { urlname: "FAQ", url: "https://codepen.io/jettaz" }
          ]
        },
        {
          name: "Resources",
          tags: [
            { urlname: "Blog", url: "https://codepen.io/jettaz" },
            { urlname: "eBooks", url: "https://codepen.io/jettaz" },
            { urlname: "Whitepapers", url: "https://codepen.io/jettaz" },
            { urlname: "Comparison Guide", url: "https://codepen.io/jettaz" },
            { urlname: "Website Grader", url: "https://codepen.io/jettaz" }
          ]
        },
        {
          name: "Get Help",
          tags: [
            { urlname: "Help Center", url: "https://codepen.io/jettaz" },
            { urlname: "Contact Us", url: "https://codepen.io/jettaz" },
            { urlname: "Privacy Policy", url: "https://codepen.io/jettaz" },
            { urlname: "Terms", url: "https://codepen.io/jettaz" },
            { urlname: "Login", url: "https://codepen.io/jettaz" }
          ]
        }
      ]
   -->