<template>
    <div>
      <!--<v-carousel cycle height="400" hide-delimiter-background show-arrows="hover">
        <v-carousel-item v-for="(slide, i) in slides" :key="i">
          <v-sheet :color="colors[i]" height="100%">
            <div class="d-flex fill-height justify-center align-center">
              <div class="text-h2">{{ slide }} Slide</div>
            </div>
          </v-sheet>
        </v-carousel-item>
      </v-carousel>-->
      <v-carousel show-arrows="hover">
        <v-carousel-item
            src="https://cdn.vuetifyjs.com/images/cards/docks.jpg"
            cover
        ></v-carousel-item>

        <v-carousel-item
            src="https://cdn.vuetifyjs.com/images/cards/hotel.jpg"
            cover
        ></v-carousel-item>

        <v-carousel-item
            src="https://cdn.vuetifyjs.com/images/cards/sunshine.jpg"
            cover
        ></v-carousel-item>
      </v-carousel>
    </div>
    <div class="cards-area">
      <v-card class="mx-auto" max-width="344">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Info +</v-btn>
          <v-spacer></v-spacer>
          <v-btn :icon="show ? 'mdi-chevron-up' : 'mdi-chevron-down'" @click="show = !show">↓</v-btn>
        </v-card-actions>
  
        <v-expand-transition>
          <div v-show="show">
            <v-divider></v-divider>
            <v-card-text>
                Una apasionante tragedia que sigue el romance prohibido entre Romeo y Julieta, dos jóvenes de familias rivales en Verona. Amor, odio, traición y destino se entrelazan en esta emblemática historia de Shakespeare, llevando a los amantes a un final desgarrador que conmueve al público.
            </v-card-text>
          </div>
        </v-expand-transition>
      </v-card>
      <v-card class="mx-auto" max-width="344">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Info +</v-btn>
          <v-spacer></v-spacer>
          <v-btn :icon="show ? 'mdi-chevron-up' : 'mdi-chevron-down'" @click="show = !show">↓</v-btn>
        </v-card-actions>
  
        <v-expand-transition>
          <div v-show="show">
            <v-divider></v-divider>
            <v-card-text>
                Una apasionante tragedia que sigue el romance prohibido entre Romeo y Julieta, dos jóvenes de familias rivales en Verona. Amor, odio, traición y destino se entrelazan en esta emblemática historia de Shakespeare, llevando a los amantes a un final desgarrador que conmueve al público.
            </v-card-text>
          </div>
        </v-expand-transition>
      </v-card>
      <v-card class="mx-auto" max-width="344">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Info +</v-btn>
          <v-spacer></v-spacer>
          <v-btn :icon="show ? 'mdi-chevron-up' : 'mdi-chevron-down'" @click="show = !show">↓</v-btn>
        </v-card-actions>
  
        <v-expand-transition>
          <div v-show="show">
            <v-divider></v-divider>
            <v-card-text>
                Una apasionante tragedia que sigue el romance prohibido entre Romeo y Julieta, dos jóvenes de familias rivales en Verona. Amor, odio, traición y destino se entrelazan en esta emblemática historia de Shakespeare, llevando a los amantes a un final desgarrador que conmueve al público.
            </v-card-text>
          </div>
        </v-expand-transition>
      </v-card>
    </div>
  </template>
  
  <style scoped>
  .v-carousel {
    margin-block: 100px;
  }

  .cards-area {
    margin-block: 100px;
  }

  .v-card {
    margin: 40px;
  }
  </style>
  
  <script setup lang="ts">
  import { ref } from 'vue';
  
  const show = ref(false);  
  const slides = ['First', 'Second', 'Third', 'Fourth', 'Fifth'];
  </script>
  