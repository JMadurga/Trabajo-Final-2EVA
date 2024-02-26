<!-- Header.vue -->
<template>
  <v-card max-width="448" class="mx-auto" color="grey-lighten-3">
    <v-layout>
      <v-app-bar
        color="teal-darken-4"
      >
        <template v-slot:image>
          <v-img
            gradient="to top right, rgba(62,78,98,.8), rgba(34,46,67,.8)"
          ></v-img>
        </template>
        
        <v-img src="../media/logo-BC.png">
          <template #sources>
            <source srcset="../media/logo-BC.png">
          </template>
        </v-img>

        <v-spacer></v-spacer>

        <v-btn icon style="margin-right: 40px;">
          <v-icon><img src="../media/Carrito.png" alt="carrito" height="30px" width="30px"></v-icon>
        </v-btn>
      </v-app-bar>
    </v-layout>
  </v-card>
</template>
<style scoped>

</style>
  