<template>
    <div>
      <v-carousel hide-delimiters show-arrows="false" cycle interval="3000">
        <RouterLink to="/promociones">
          <v-carousel-item
            src="https://mylifeiguess.com/wp-content/uploads/2023/09/couple-at-movie-theatre.jpg.webp"
            cover>
          </v-carousel-item>
        </RouterLink>
        <RouterLink to="/promociones">
          <v-carousel-item
            src="https://cdn.pixabay.com/photo/2017/01/18/17/52/calendar-1990453_1280.jpg"
            cover
          ></v-carousel-item>
        </RouterLink>
        <RouterLink to="/promociones">
          <v-carousel-item
            src="https://cdn.pixabay.com/photo/2016/03/27/17/14/venetian-mask-1283163_1280.jpg"
            cover
          ></v-carousel-item>
        </RouterLink>
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