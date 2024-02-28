<template>
    <div>
      <v-carousel hide-delimiters show-arrows="false" cycle interval="3000">
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
      <v-card class="mx-auto" width="300px">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Comprar</v-btn>
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
      <v-card class="mx-auto" width="300px">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Comprar</v-btn>
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
      <v-card class="mx-auto" width="300px">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Comprar</v-btn>
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
      <v-card class="mx-auto" width="300px">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Comprar</v-btn>
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
      <v-card class="mx-auto" width="300px">
        <v-img src="https://www.clasicodesevilla.com/images/media/Romeo-Y-Julieta-12.jpg" height="200px" cover></v-img>
  
        <v-card-title>Romeo y Julieta</v-card-title>
        <v-card-subtitle>27 de Septiembre 2024</v-card-subtitle>
  
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text">Comprar</v-btn>
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
    display: grid;
    grid-template-columns: auto auto auto auto;
    gap: 20px;
    margin-block: 100px;
    margin-inline: 200px;
  }

  .v-card {
    margin: 40px;
  }

  @media (max-width: 1664px) {
    .cards-area {
      grid-template-columns: auto auto auto;
    }
  }
  @media (max-width: 1342px) {
    .cards-area {
      grid-template-columns: auto auto;
    }
  }
  @media (max-width: 1024px) {
    .cards-area {
      grid-template-columns: auto;
      margin-inline: auto;
    }
  }
  
  </style>
  
  <script setup lang="ts">
  import { ref } from 'vue';
  
  const show = ref(false);  
  const slides = ['First', 'Second', 'Third', 'Fourth', 'Fifth'];
  </script>
  