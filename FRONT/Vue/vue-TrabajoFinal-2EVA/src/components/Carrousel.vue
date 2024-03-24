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
</template>
<script setup lang="ts">
</script>
<style scoped>
.v-carousel {
    margin-block: 100px;
    margin-inline: 5%;
    width: auto;
  }
</style>