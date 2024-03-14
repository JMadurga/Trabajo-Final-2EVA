<template>
    <div class="contenedor">
      <v-card class="mx-auto rounded-shaped" max-width="1000" height="auto">
        <div class="promo-np"></div>
        <v-card-text>
          <p class="text-h4 text--primary title-lato">Noche de Parejas</p>
          <div class="text--primary description-lato" style="margin-top: 10px;">
            Disfruta de una velada romántica con un 20% de descuento al comprar dos entradas. Válido solo los viernes por la noche.
          </div>
        </v-card-text>
        <v-card-actions>
            <RouterLink to="/"><v-btn color="pink-darken-1" variant="text"> COMPRAR ENTRADAS </v-btn></RouterLink>
        </v-card-actions>
      </v-card>
      <v-card class="mx-auto rounded-shaped" max-width="1000" height="auto">
        <div class="promo-pf"></div>
        <v-card-text>
          <p class="text-h4 text--primary title-lato">Paquete Familiar</p>
          <div class="text--primary description-lato" style="margin-top: 10px;">
            Compra cuatro entradas y obtén un descuento del 25% en el total de la compra. Además, incluye un vale de descuento para el servicio de confitería del teatro. Esta promoción puede ser ideal para funciones matinales o espectáculos aptos para todas las edades.
          </div>
        </v-card-text>
        <v-card-actions>
            <RouterLink to="/"><v-btn color="pink-darken-1" variant="text"> COMPRAR ENTRADAS </v-btn></RouterLink>
        </v-card-actions>
      </v-card>
      <v-card class="mx-auto rounded-shaped" max-width="1000" height="auto">
        <div class="promo-sa"></div>
        <v-card-text>
          <p class="text-h4 text--primary title-lato">Suscripción Anual con Beneficios Exclusivos</p>
          <div class="text--primary description-lato" style="margin-top: 10px;">
            Ofrece una membresía que incluye entradas a todas las funciones, acceso prioritario a los asientos, descuentos en la confitería, invitaciones a eventos exclusivos y meet-and-greets con el elenco. Esta oferta es perfecta para los aficionados al teatro más leales.
          </div>
        </v-card-text>
        <v-card-actions>
            <RouterLink to="/"><v-btn color="pink-darken-1" variant="text"> COMPRAR ENTRADAS </v-btn></RouterLink>
        </v-card-actions>
      </v-card>
      <v-card class="mx-auto rounded-shaped" max-width="1000" height="auto">
        <div class="promo-pu"></div>
        <v-card-text>
          <p class="text-h4 text--primary title-lato">Promoción de Última Hora</p>
          <div class="text--primary description-lato" style="margin-top: 10px;">
            Entradas a mitad de precio para la compra en línea dos horas antes del inicio de la función. Esta oferta puede ayudar a llenar asientos vacíos y atraer a aquellos que toman decisiones de último minuto.
          </div>
        </v-card-text>
        <v-card-actions>
            <RouterLink to="/"><v-btn color="pink-darken-1" variant="text"> COMPRAR ENTRADAS </v-btn></RouterLink>
        </v-card-actions>
      </v-card>
      <v-card class="mx-auto rounded-shaped" max-width="1000" height="auto">
        <div class="promo-nt"></div>
        <v-card-text>
          <p class="text-h4 text--primary title-lato">Noches Temáticas con Descuento</p>
          <div class="text--primary description-lato" style="margin-top: 10px;">
            Ofertas especiales para noches temáticas, como "Noche de los 80", donde los asistentes disfrazados según la temática obtienen un 15% de descuento en sus entradas. Esta promoción puede generar entusiasmo y aumentar la asistencia en noches específicas.
          </div>
        </v-card-text>
        <v-card-actions>
            <RouterLink to="/"><v-btn color="pink-darken-1" variant="text"> COMPRAR ENTRADAS </v-btn></RouterLink>
        </v-card-actions>
      </v-card> 
    </div>
  </template>
  
  <style scoped>

  .contenedor{
    margin-block: 8%;
  }
  .v-card {
    margin-block: 5%;
    font-family: 'Lato', sans-serif;
    height: 200px;
  }
  
  .promo-np {
    height: 200px;
    width: auto;
    margin: 0px;
    background: url('../media/couple-7025924_1920.jpg');
    background-position: center;
    background-size: cover;
  }

  .promo-pf {
    height: 200px;
    width: auto;
    margin: 0px;
    background: url('../media/family-dall.webp');
    background-position: center;
    background-size: cover;
  }

  .promo-sa {
    height: 200px;
    width: auto;
    margin: 0px;
    background: url('../media/subs.jpg');
    background-position: center;
    background-size: cover;
  }

  .promo-pu {
    height: 200px;
    width: auto;
    margin: 0px;
    background: url('../media/last.jpeg');
    background-position: center;
    background-size: cover;
  }

  .promo-nt {
    height: 200px;
    width: auto;
    margin: 0px;
    background: url('../media/tema.jpg');
    background-position: center;
    background-size: cover;
  }
  
  /* Estilos personalizados para Lato 900 y Lato 600 */
  .title-lato {
    font-weight: 900; /* Lato 900 para el título */
  }
  
  .description-lato {
    font-weight: 600; /* Lato 600 para la descripción */
  }
  </style>
  
  <script setup lang="ts">
  </script>
  