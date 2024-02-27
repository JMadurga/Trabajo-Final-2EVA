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
        
        <v-col cols="12" sm="6" md="2">
          <v-btn class="bg-image-button" rounded="xl" size="x-large" width="180px"></v-btn>
        </v-col>

        <v-tabs fixed-tabs bg-color="transparent">
          <v-tab class="boton flex display-4 font-weight-black">Obras</v-tab>
          <v-tab class="boton flex display-4 font-weight-black">Promociones</v-tab>
        </v-tabs>

        <v-spacer></v-spacer>

        <v-btn icon style="margin-right: 40px;" class="glow-on-hover">
          <v-icon z-index="1"><img src="../media/ticket_icon.png" alt="carrito" height="30px" width="30px"></v-icon>
        </v-btn>

        
      </v-app-bar>
    </v-layout>
  </v-card>
</template>
<style scoped>
.v-app-bar {
  height: 64px;
}
.bg-image-button { 
  /* Other button styles */ 
  background-image: url('../media/logo-BC.png'); 
  background-size: cover; 
  background-position: center; 
} 
.boton::before {
  content: "";
  position: absolute;
  bottom: 0;
  left: 0;
  width: 0;
  height: 2px;
  background-color: #fff;
  transition: width 0.3s ease;
}
      
.boton:hover::before {
  width: 100%;
}

.glow-on-hover {
        width: 50px;
        height: 50px;
        border: none;
        outline: none;
        color: #fff;
        background: #000;
        cursor: pointer;
        position: relative;
        z-index: 0;
        border-radius: 50px;
    }
    
    .glow-on-hover:before {
        content: '';
        background: linear-gradient(45deg, #818181, rgba(62,78,98,.8), #000, #818181, rgba(62,78,98,.8), #000, #818181, rgba(62,78,98,.8), #000);
        position: absolute;
        top: -2px;
        left:-2px;
        background-size: 400%;
        z-index: -1;
        filter: blur(5px);
        width: calc(100% + 4px);
        height: calc(100% + 4px);
        animation: glowing 20s linear infinite;
        opacity: 0;
        transition: opacity .3s ease-in-out;
        border-radius: 50px;
    }
    
    .glow-on-hover:active {
        color: #000
    }
    
    .glow-on-hover:active:after {
        background: transparent;
    }
    
    .glow-on-hover:hover:before {
        opacity: 1;
    }
    
    .glow-on-hover:after {
        z-index: -1;
        content: '';
        position: absolute;
        width: 100%;
        height: 100%;
        background: #000;
        left: 0;
        top: 0;
        border-radius: 50px;
    }
    
    @keyframes glowing {
        0% { background-position: 0 0; }
        50% { background-position: 400% 0; }
        100% { background-position: 0 0; }
    }
</style>
  