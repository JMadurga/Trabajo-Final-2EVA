<script setup lang="ts">
import Cabecera from '../components/Head.vue'
import Login from '../components/Login-Component.vue'
import Foot from '../components/Foot.vue'
</script>
<template>
<main>
    <div class="grid-container">
      <div class="cabecera"><Cabecera/></div>
      <div><Login/></div>
      <div><Foot/></div>
    </div>
  </main>
</template>
<style scoped>
.grid-container {
  display: grid;
  grid-template-rows: auto;
  background-image: url('../media/movie-theater-4213751_1920.jpg');
  background-repeat: no-repeat;
  background-attachment: fixed;
}

.cabecera {
  z-index: 1;
}
</style>


<!--<script setup lang="ts">
const props = defineProps({
  first: String,
  email: String,
  password: String,
  terms: Boolean
});
</script>-->