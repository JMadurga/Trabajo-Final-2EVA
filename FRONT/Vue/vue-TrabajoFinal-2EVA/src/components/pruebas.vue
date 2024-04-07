<!-- Header.vue 
<template>
  <v-btn @mouseover="onMouseEnter" @mouseleave="onMouseLeave" id="canvasFull" ref="canvasFull" rounded="xl" size="x-large" width="180px" class="ma-2" color="white">
    <div id="canvasFull" style="align-items: center;">
      <canvas ref="canvasLine1" width="180" height="30"></canvas>
      <canvas id="canvasText" ref="canvasText" width="180" height="15"></canvas>
      <canvas ref="canvasLine2" width="180" height="30"></canvas>
    </div>
  </v-btn>
</template>
<style scoped> 

#canvasFull {
  display: flex;
  flex-direction: column;
}

#canvasText {
  transition: all 2s ease;
}

</style>
<script setup lang="ts">

import { ref, onMounted } from 'vue';
import type { Ref } from 'vue';

// Inicializa tus referencias de canvas como Ref<HTMLCanvasElement | null>
const canvasFull: Ref<HTMLCanvasElement | null> = ref(null);
const canvasLine1: Ref<HTMLCanvasElement | null> = ref(null);
const canvasText: Ref<HTMLCanvasElement | null> = ref(null);
const canvasLine2: Ref<HTMLCanvasElement | null> = ref(null);

// Esta función se llamará una vez que los componentes estén montados
onMounted(() => {
  // Asegúrate de que todos los elementos del canvas no son nulos antes de continuar.
  if (canvasLine1.value && canvasText.value && canvasLine2.value) {
    const ctxLine1 = canvasLine1.value.getContext('2d');
    const ctxText = canvasText.value.getContext('2d');
    const ctxLine2 = canvasLine2.value.getContext('2d');

    // Asegúrate de que los contextos también se han obtenido correctamente.
    if (ctxLine1 && ctxText && ctxLine2) {
      const loadFont = new FontFace('Lato', 'url(https://fonts.gstatic.com/s/lato/v20/S6u9w4BMUTPHh50XSwiPGQ.woff2)', {
        weight: '900'
      });

      loadFont.load().then(function(loadedFont) {
        document.fonts.add(loadedFont);
        redrawText(); // Asegúrate de que esta función se llama dentro de un contexto seguro.
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
        ctxLine1.lineWidth = 5; 

        ctxLine2.strokeStyle = '#ff00cc';
        ctxLine2.lineWidth = 5; 

        ctxLine1.beginPath();
        ctxLine1.moveTo(0, 0);
        ctxLine1.lineTo(0, 100);
        ctxLine1.stroke();

        ctxLine1.beginPath();
        ctxLine1.moveTo(360, 65);
        ctxLine1.lineTo(655, 65);
        ctxLine1.stroke();

        ctxLine1.beginPath();
        ctxLine1.moveTo(655, 60);
        ctxLine1.lineTo(655, 100);
        ctxLine1.stroke();
        
        /////////////////////////////
        
        ctxLine2.beginPath();
        ctxLine2.moveTo(360, 0);
        ctxLine2.lineTo(360, 40);
        ctxLine2.stroke();

        ctxLine2.beginPath();
        ctxLine2.moveTo(360, 35);
        ctxLine2.lineTo(655, 35);
        ctxLine2.stroke();

        ctxLine2.beginPath();
        ctxLine2.moveTo(655, 0);
        ctxLine2.lineTo(655, 40);
        ctxLine2.stroke();
    }    
  }  
});

function onMouseEnter() {
  if (canvasText.value && canvasLine1.value && canvasLine2.value) {
    // Solo modifica las propiedades si los elementos no son nulos.
    canvasText.value.style.transform = 'scale(0.3)';
    canvasLine1.value.style.transition = 'transform 3.2s ease';
    canvasLine1.value.style.transform = 'translateY(81px)';
    canvasLine2.value.style.transition = 'transform 3.2s ease';
    canvasLine2.value.style.transform = 'translateY(-81px)';
  }
}

function onMouseLeave() {
  if (canvasText.value && canvasLine1.value && canvasLine2.value) {
    // Solo modifica las propiedades si los elementos no son nulos.
    canvasText.value.style.transform = 'scale(1)';
    canvasLine1.value.style.transition = 'transform 0.8s ease';
    canvasLine1.value.style.transform = 'translateY(0px)';
    canvasLine2.value.style.transition = 'transform 0.8s ease';
    canvasLine2.value.style.transform = 'translateY(0px)';
  }
}
</script>
-->

<template>
  <v-btn @mouseover="onMouseEnter" @mouseleave="onMouseLeave" id="canvasFull" ref="canvasFull" rounded="xl" size="x-large" width="250px" class="ma-2" color="white">
    <div id="canvasFull">
      <canvas ref="canvasLine1" width="250" height="40"></canvas>
      <canvas id="canvasText" ref="canvasText" width="250" height="15"></canvas>
      <canvas ref="canvasLine2" width="250" height="40"></canvas>
    </div>
  </v-btn>
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
      ctxLine1.moveTo(55, 28);
      ctxLine1.lineTo(55, 40);
      ctxLine1.stroke();

      ctxLine1.beginPath();
      ctxLine1.moveTo(53, 28);
      ctxLine1.lineTo(195, 28);
      ctxLine1.stroke();

      ctxLine1.beginPath();
      ctxLine1.moveTo(193, 28);
      ctxLine1.lineTo(193, 40);
      ctxLine1.stroke();
      
        /////////////////////////////
        
      ctxLine2.beginPath();
      ctxLine2.moveTo(55, 0);
      ctxLine2.lineTo(55, 12);
      ctxLine2.stroke();

      ctxLine2.beginPath();
      ctxLine2.moveTo(53, 12);
      ctxLine2.lineTo(195, 12);
      ctxLine2.stroke();

      ctxLine2.beginPath();
      ctxLine2.moveTo(193, 0);
      ctxLine2.lineTo(193, 12);
      ctxLine2.stroke();
    }
  }
});

function onMouseEnter() {
  if (canvasText.value && canvasLine1.value && canvasLine2.value) {
    canvasText.value.style.transform = 'scale(0.6)';
    canvasLine1.value.style.transition = 'transform 3.2s ease';
    canvasLine1.value.style.transform = 'translateY(7px)';
    canvasLine2.value.style.transition = 'transform 3.2s ease';
    canvasLine2.value.style.transform = 'translateY(-7px)';
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
</script>

<style scoped>
#canvasFull {
  display: flex;
  flex-direction: column;
}

#canvasText {
  transition: all 2s ease;
}
</style>

