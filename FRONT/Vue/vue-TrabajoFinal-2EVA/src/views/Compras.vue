<script setup lang="ts">
import Cabecera from '../components/Head.vue'
import ComprasBodi from '../components/Compras-Bodi.vue'
import Foot from '../components/Foot.vue'
</script>
<template>
  <main>
    <!--<video autoplay muted loop id="myVideo">
        <source src="../media/video.mp4" type="video/mp4">
        Your browser does not support HTML5 video.
    </video>-->
    <img src="../media/fondo.jpg" alt="imagen" id="myVideo">
    <div class="grid-container">
        <div class="cabecera"><Cabecera/></div>
        <div><ComprasBodi/></div>
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
  z-index: -1;
}
</style>