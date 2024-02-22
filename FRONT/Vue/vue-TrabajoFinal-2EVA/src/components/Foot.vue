<!-- Footer.vue -->
<template>
    <footer class="footer">
      <div class="footer-contacto">
        <div>
          <h1>CONTACTANOS:</h1>
          <br/>
          <p>Numero de Contacto: 655 456 773</p>
          <p>Mail: Teatrodosfacetas@gmail.com</p>
          <p>Fax: 976 554 332</p>
        </div>
      </div>
      
      <div class="footer-encuentranos">
        <h1>DONDE NOS ENCONTRAMOS: </h1>
        <br/>
        <p>C// Arboleda Nº 23</p>
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2978.1676266914787!2d-0.9992717876474786!3d41.7169015711399!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd596e61f961d625%3A0xb67eb195360c892f!2sC.%20Arboleda%2C%2023%2C%2050180%20Utebo%2C%20Zaragoza!5e0!3m2!1ses!2ses!4v1702398840220!5m2!1ses!2ses" width="300" height="150" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
      </div>
    </footer>
  </template>
    
  <style scoped>
  .footer {
    display: flex;
    flex-direction: row;
    width: 100%;
    background-color: #3E4E62;
    position: relative;
    bottom: 0;
    color: #F2FBFF;
    margin-top: 20px;
    padding: 20px;
  }
  
  .footer-contacto {
    margin-inline: 40px;
    margin-block: 20px;
  }
  
  .footer-encuentranos {
    margin-inline: 40px;
    margin-block: 20px;
  }
  
  .footer img {
    width: 300px;
    height: 100px;
  }
  </style>
  