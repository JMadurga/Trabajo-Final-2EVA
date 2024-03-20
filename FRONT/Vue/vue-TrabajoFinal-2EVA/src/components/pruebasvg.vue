<template>
    <div>
      <svg viewBox="0 0 100 100" xmlns="http://www.w3.org/2000/svg">
        <!-- Asegúrate de que tu path tenga un ID para poder seleccionarlo fácilmente -->
        <path id="mypath" d="M10 10 h 80 v 80 h -80 Z"/>
      </svg>
      <button @click="aplicarColor">Aplicar Color</button>
    </div>
  </template>
  
  <script setup lang="ts">
  import { ref, onMounted } from 'vue';
  
  // Definir un nuevo tipo que contenga solo las claves válidas de colors
  type ColorKey = 'color1' | 'color2';
  
  // Objeto que mantiene los colores actuales del SVG.
  const colors = ref<{
      color1: string;
      color2: string;
  }>({
      color1: '#FF0000', // Rojo
      color2: '#00FF00', // Verde
  });
  
  // Ref para controlar el color actual con un tipo específico
  const currentColor = ref<ColorKey>('color1');
  
  // Esta función cambia el color actual y actualiza el path con el nuevo color
  const aplicarColor = () => {
      // Cambia el color actual de manera segura
      currentColor.value = currentColor.value === 'color1' ? 'color2' : 'color1';
  
      // Actualiza el color del path, asegurándose de que la clave exista en colors
      const key = currentColor.value; // Este es un ColorKey, por lo que es seguro
      const colorValue = colors.value[key]; // TypeScript sabe que esto es seguro
  
      // Obtén el elemento path por su ID y actualízalo con el nuevo color
      const path = document.getElementById('mypath');
      if (path) {
          path.setAttribute('fill', colorValue);
      }
  };
  
  // Asegúrate de que el SVG se actualice con el color inicial correcto al montar el componente
  onMounted(() => {
      aplicarColor();
  });
  </script>
  