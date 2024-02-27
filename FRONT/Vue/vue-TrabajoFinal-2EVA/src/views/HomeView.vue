<script setup lang="ts">
import Cabecera from '../components/Head.vue'
import Bodi from '../components/Bodi.vue'
import Foot from '../components/Foot.vue'
</script>

<template>
  <main>
    <div class="grid-container">
      <div class="cabecera"><Cabecera/></div>
      <div><Bodi/></div>
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
</style>