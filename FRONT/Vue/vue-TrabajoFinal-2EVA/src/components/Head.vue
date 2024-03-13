<template>
  <v-card max-width="448" class="mx-auto">
    <v-layout row wrap align-center>
      
      <v-app-bar color="blue-grey-darken-4" flat>

        <v-col class="d-flex justify-start" cols="auto">
          <RouterLink to="/">
            <v-btn @mouseover="onMouseEnter" @mouseleave="onMouseLeave" id="canvasFull" ref="canvasFull" rounded="xl" size="x-large" width="250px" class="ma-2" style="background-color: white;">
              <div id="canvasFull">
                <canvas ref="canvasLine1" width="250" height="40"></canvas>
                <canvas id="canvasText" ref="canvasText" width="250" height="15"></canvas>
                <canvas ref="canvasLine2" width="250" height="40"></canvas>
              </div>
            </v-btn>
          </RouterLink>
        </v-col>

        <v-col cols="auto" class="d-flex justify-center">
          <v-tabs fixed-tabs bg-color="transparent">
            <RouterLink to="/" style="text-decoration: none;"><v-tab class="ds boton flex display-4 font-weight-black">Obras</v-tab></RouterLink>
            <RouterLink to="/promociones" style="text-decoration: none;"><v-tab class="ds boton flex display-4 font-weight-black">Promociones</v-tab></RouterLink>
          </v-tabs>
        </v-col>

        <v-spacer></v-spacer>

        <v-col cols="auto" class="ds d-flex justify-end">
          <RouterLink to="/login">
            <v-btn icon class="ds glow-on-hover mr-5">
              <v-icon z-index="1"><img src="../media/login.png" alt="login" height="30px" width="30px"></v-icon>
            </v-btn>
          </RouterLink>
          <div class="d-flex justify-space-around">
            <v-menu transition="slide-x-reverse-transition">
              <template v-slot:activator="{ props }">
                <v-btn icon class="ds glow-on-hover mr-2" v-bind="props" @click.stop="drawer = !drawer">
                  <v-icon z-index="1"><img src="../media/ticket_icon.png" alt="tickets" height="30px" width="30px"></v-icon>
                </v-btn>
              </template>
            </v-menu>
          </div>
        </v-col>

        <v-col class="ham-icon d-flex justify-start" cols="auto">
          <v-menu>
            <template v-slot:activator="{ props }">
              <v-btn v-bind="props" icon class="ham-icon glow-on-hover mr-2">
                  <v-icon z-index="1"><img src="../media/ham-icon.png" alt="login" height="30px" width="30px"></v-icon>
              </v-btn>
            </template>

            <v-list>
              <v-list-item v-for="(item, i) in hamitem" :key="i">
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
import { ref, onMounted } from 'vue';
import type { Ref } from 'vue';

const canvasFull: Ref<HTMLCanvasElement | null> = ref(null);
const canvasLine1: Ref<HTMLCanvasElement | null> = ref(null);
const canvasText: Ref<HTMLCanvasElement | null> = ref(null);
const canvasLine2: Ref<HTMLCanvasElement | null> = ref(null);

onMounted(() => {
  if (canvasLine1.value && canvasText.value && canvasLine2.value) {
    const ctxLine1 = canvasLine1.value.getContext('2d');
    const ctxText = canvasText.value.getContext('2d');
    const ctxLine2 = canvasLine2.value.getContext('2d');

    if (ctxLine1 && ctxText && ctxLine2) {
      const loadFont = new FontFace('Lato', 'url(https://fonts.gstatic.com/s/lato/v20/S6u9w4BMUTPHh50XSwiPGQ.woff2)', {
        weight: '900'
      });

      loadFont.load().then(function(loadedFont) {
        document.fonts.add(loadedFont);
        redrawText();
      });

      function redrawText() {
        if (ctxText && canvasText.value) {
        // Aquí no necesitas comprobaciones adicionales porque estás dentro de un contexto donde canvasText y ctxText ya están asegurados como no nulos.
        ctxText.clearRect(0, 0, canvasText.value.width, canvasText.value.height);
        ctxText.fillStyle = '#414768';
        ctxText.font = '12.5px Lato Black, Lato, sans-serif';

        const text = 'TEATRO DOS FACETAS';
        const textMetrics = ctxText.measureText(text);
        const x = (canvasText.value.width - textMetrics.width) / 2;
        const y = (canvasText.value.height / 2) + (textMetrics.actualBoundingBoxAscent / 2);

        ctxText.fillText(text, x, y);
        }
      }
      ctxLine1.strokeStyle = '#ff00cc';
      ctxLine1.lineWidth = 4; 

      ctxLine2.strokeStyle = '#ff00cc';
      ctxLine2.lineWidth = 4; 

      ctxLine1.beginPath();
      ctxLine1.moveTo(70, 28);
      ctxLine1.lineTo(70, 40);
      ctxLine1.stroke();

      ctxLine1.beginPath();
      ctxLine1.moveTo(68, 28);
      ctxLine1.lineTo(180, 28);
      ctxLine1.stroke();

      ctxLine1.beginPath();
      ctxLine1.moveTo(178, 28);
      ctxLine1.lineTo(178, 40);
      ctxLine1.stroke();
      
        /////////////////////////////
        
      ctxLine2.beginPath();
      ctxLine2.moveTo(70, 0);
      ctxLine2.lineTo(70, 12);
      ctxLine2.stroke();

      ctxLine2.beginPath();
      ctxLine2.moveTo(68, 12);
      ctxLine2.lineTo(180, 12);
      ctxLine2.stroke();

      ctxLine2.beginPath();
      ctxLine2.moveTo(178, 0);
      ctxLine2.lineTo(178, 12);
      ctxLine2.stroke();
    }
  }
});

function onMouseEnter() {
  if (canvasText.value && canvasLine1.value && canvasLine2.value) {
    canvasText.value.style.transform = 'scale(0.6)';
    canvasLine1.value.style.transition = 'transform 3.2s ease';
    canvasLine1.value.style.transform = 'translateY(6px)';
    canvasLine2.value.style.transition = 'transform 3.2s ease';
    canvasLine2.value.style.transform = 'translateY(-6px)';
  }
}

function onMouseLeave() {
  if (canvasText.value && canvasLine1.value && canvasLine2.value) {
    canvasText.value.style.transform = 'scale(1)';
    canvasLine1.value.style.transition = 'transform 0.8s ease';
    canvasLine1.value.style.transform = 'translateY(0px)';
    canvasLine2.value.style.transition = 'transform 0.8s ease';
    canvasLine2.value.style.transform = 'translateY(0px)';
  }
}

const drawer = ref(false);
const ticketitem = ref([
  { title: 'Ticket 1' },
  { title: 'Ticket 2' },
  { title: 'Ticket 3' },
  { title: 'Ticket 4' },
]);
const hamitem = ref([
  { title: 'Obras' },
  { title: 'Promociones' },
  { title: 'Login' },
  { title: 'Carrito' }
]);

</script>
  <style scoped>

  #canvasFull {
    display: flex;
    flex-direction: column;
  }

  #canvasText {
    transition: all 2s ease;
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
      color: white;
    }

  }
  .v-app-bar {
    height: 64px;
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
    