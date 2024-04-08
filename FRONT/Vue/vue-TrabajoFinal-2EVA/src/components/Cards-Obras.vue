<template>
    <div class="cards-area">
      <v-card width="300px" v-for="card in cards" :key="card.id">
        
        <v-card-title>{{ card.obra }}</v-card-title>
        <v-card-subtitle>{{ card.date }}</v-card-subtitle>
        <v-card-actions>
          <RouterLink to="/compras"><v-btn color="blue darken-4" variant="text" @click="comprar(card)">Comprar</v-btn></RouterLink>
        </v-card-actions>
        <v-card-actions>
          <v-expansion-panels>
            <v-expansion-panel elevation="0">
              <v-expansion-panel-title collapse-icon="mdi-minus" expand-icon="mdi-plus">
              Más información
              </v-expansion-panel-title>
              <v-expansion-panel-text> {{  }} </v-expansion-panel-text>
            </v-expansion-panel>
          </v-expansion-panels>
        </v-card-actions>
      </v-card>
    </div>
</template>

<script setup lang="ts">
  import { ref } from 'vue';
  import sesionStore, { type Session } from '@/stores/sesionStore'; 
  import  {ObraStore}  from '@/stores/obraStore';
  import { SesionStore } from '@/stores/sesionStore';
// Importamos la store que hemos definido

const obraSeleccionadaStore = ObraStore();
const sesionSeleccionadaStore = SesionStore();

obraSeleccionadaStore.cargarObras();
sesionSeleccionadaStore.fetchSessions();
// Instanciamos la store

const obras = obraSeleccionadaStore.obras
const cards = ref<Session []>([]);

  function ponerInfo(){
  sesionSeleccionadaStore.sessions.forEach( async (sesion: any) => {
     const obra =  await obraSeleccionadaStore.obtenerObra(sesion.obra);
    cards.value.push({
      id: sesion.id,
      obra: obra.title,
      date: sesion.date,
      asientos: sesion.asientos
    });
  });
}

const comprar = (obra: any) => {
  obraSeleccionadaStore.obtenerObra(obra);
};
  </script>
  <style scoped>
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
  
  </style>@/stores/obraStore