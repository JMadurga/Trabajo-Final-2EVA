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
      <v-card width="300px" v-for="card in cards" :key="card.id">
        <v-img :src="card.imgSrc" height="200px" cover></v-img>
        <v-card-title>{{ card.title }}</v-card-title>
        <v-card-subtitle>{{ card.subtitle }}</v-card-subtitle>
        <v-card-actions>
          <v-btn color="blue darken-4" variant="text" @click="selectPlay(play)">Comprar</v-btn>
        </v-card-actions>
        <v-card-actions>
          <v-expansion-panels>
            <v-expansion-panel elevation="0">
              <v-expansion-panel-title collapse-icon="mdi-minus" expand-icon="mdi-plus">
              Más información
              </v-expansion-panel-title>
              <v-expansion-panel-text> {{ card.content }} </v-expansion-panel-text>
            </v-expansion-panel>
          </v-expansion-panels>
        </v-card-actions>
      </v-card>
    </div>
  </template>  
  <script setup lang="ts">
  import { ref } from 'vue';
  import { usePlaysStore } from '@/stores/obraSeleccionada';

  const playsStore = usePlaysStore();

  const selectPlay = (play: object) => { // Asegúrate de reemplazar 'any' con el tipo específico de tus obras de teatro
    playsStore.selectPlay(play);
  };

const cards = ref([
  { id: 1, title: 'Romeo y Julieta', subtitle: '27 de Septiembre 2024', content: 'Descripción de Romeo y Julieta...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 2, title: 'Hamlet', subtitle: '1 de Octubre 2024', content: 'Descripción de Hamlet...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 3, title: 'Macbeth', subtitle: '15 de Octubre 2024', content: 'Descripción de Macbeth...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 4, title: 'Romeo y Julieta', subtitle: '27 de Septiembre 2024', content: 'Descripción de Romeo y Julieta...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 5, title: 'Hamlet', subtitle: '1 de Octubre 2024', content: 'Descripción de Hamlet...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 6, title: 'Macbeth', subtitle: '15 de Octubre 2024', content: 'Descripción de Macbeth...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 7, title: 'Hamlet', subtitle: '1 de Octubre 2024', content: 'Descripción de Hamlet...', imgSrc: 'ruta/a/la/imagen.jpg' },
  { id: 8, title: 'Macbeth', subtitle: '15 de Octubre 2024', content: 'Descripción de Macbeth...', imgSrc: 'ruta/a/la/imagen.jpg' }
]);

  </script>
  <style scoped>
  .v-carousel {
    margin-block: 100px;
    margin-inline: 5%;
    width: auto;
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
  
  </style>@/stores/obraSeleccionada../stores/obraSeleccionada.js