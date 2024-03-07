<!-- Header.vue -->
<template>
  <v-card max-width="448" class="mx-auto">
    <v-layout row wrap align-center>
      
      <v-app-bar color="blue-grey-darken-4" flat class="herobgcolor">

        <v-col class="d-flex justify-start" cols="auto">
          <RouterLink to="/"><v-btn class="bg-image-button" rounded="xl" size="x-large" width="180px"></v-btn></RouterLink>
        </v-col>

        <v-col cols="auto" class="d-flex justify-center">
          <v-tabs fixed-tabs bg-color="transparent">
            <v-tab class="ds boton flex display-4 font-weight-black">Obras</v-tab>
            <v-tab class="ds boton flex display-4 font-weight-black">Promociones</v-tab>
          </v-tabs>
        </v-col>

        <v-spacer></v-spacer>

        <v-col cols="auto" class="ds d-flex justify-end">
          <v-btn icon class="ds glow-on-hover mr-5">
            <v-icon z-index="1"><img src="../media/ticket_icon.png" alt="tickets" height="30px" width="30px"></v-icon>
          </v-btn>
          <RouterLink to="/login">
            <v-btn icon class="ds glow-on-hover mr-2">
              <v-icon z-index="1"><img src="../media/login.png" alt="login" height="30px" width="30px"></v-icon>
            </v-btn>
          </RouterLink>
        </v-col>

        <v-col class="ham-icon d-flex justify-start" cols="auto">
          <v-menu>
            <template v-slot:activator="{ props }">
              <v-btn v-bind="props" icon class="ham-icon glow-on-hover mr-2">
                  <v-icon z-index="1"><img src="../media/ham-icon.png" alt="login" height="30px" width="30px"></v-icon>
              </v-btn>
            </template>

            <v-list>
              <v-list-item v-for="(item, i) in items" :key="i">
                <v-list-item-title>{{ item.title }}</v-list-item-title>
              </v-list-item>
            </v-list>
          </v-menu>
        </v-col>

      </v-app-bar>
    </v-layout>
  </v-card>
</template>
<script setup lang="ts">
const items = [
        { title: 'Obras' },
        { title: 'Promociones' },
        { title: 'Login' },
        { title: 'Carrito' }
      ]
</script>
  <style scoped>

  .herobgcolor {
    background-color: linear-gradient(to right, rgba(62,78,98,.8), rgba(34,46,67,.8));
    -webkit-animation: nebulahero 20s infinite linear;
  }

  @-webkit-keyframes nebulahero {
    0% {-webkit-filter: hue-rotate(0deg);}
    100% {-webkit-filter: hue-rotate(-360deg);}
  }

  @media only screen and (max-width: 650px) {
    
    .ham-icon {
      display: block;
    }

    .ds {
      display: none;
    }

  }

  @media only screen and (min-width: 650px) {
    
    .ham-icon {
      display: none;
    }

    .ds {
      display: block;
    }

  }
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
    