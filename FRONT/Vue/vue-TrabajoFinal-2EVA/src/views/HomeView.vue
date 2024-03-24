<script setup lang="ts">
import Cabecera from '../components/Head.vue'
import Foot from '../components/Foot.vue'
import Carrousel from '../components/Carrousel.vue'
import Cards from '../components/Cards-Obras.vue'
</script>

<template>
  <main>
    <video autoplay muted loop id="myVideo">
      <source src="../media/video.mp4" type="video/mp4">
      Your browser does not support HTML5 video.
    </video>
    <div class="grid-container">
      <div class="cabecera"><Cabecera/></div>
      <!--<div><Bodi/></div>-->
      <div><Carrousel/></div>
      <div><Cards/></div>
      <div><Foot/></div>
    </div>
  </main>
</template>

<style scoped>
.grid-container {
  display: grid;
  grid-template-rows: auto;
}

.cabecera {
  z-index: 1;
}

* {
  box-sizing: border-box;
}

#myVideo {
  position: fixed;
  bottom: 0;
  margin: 0 auto;
  min-width: 100%; 
  min-height: 100%;
}
</style>