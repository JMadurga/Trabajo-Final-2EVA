<!-- Center.vue -->
<template>
    <div class="center">
      <div class="center-obras" id="center-obras">
        <h1>Obras</h1>
        <div id="cards-obras" class="cards-obras" >
          <!-- Contenido de las obras -->
        </div>
      </div>
    </div>
  </template>
  
  <style scoped>
  .center {
    display: flex;
    flex-direction: column;
    align-items: center;
  }
  
  .center-obras {
    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
    gap: 20px;
    padding: 20px;
  }
  
  .center-obras h1 {
    color: #F2FBFF;
    font-size: 40px;
    margin-block: 10px;
    text-align: center;
  }
  
  .cards-obras {
    display: flex;
    flex-wrap: wrap;
    gap: 20px;
    justify-content: center;
  }
  
  .cards-obras img {
    width: 100%;
    height: 200px;
    object-fit: cover;
  }
  
  .obra {
    display: flex;
    flex-direction: column;
    width: 270px;
    height: 450px;
    border: 1px solid black;
    background-color: #3E4E62;
    border-radius: 10px;
    align-items: center;
    padding: 20px;
    color: #F2FBFF;
    font-size: x-large;
  }
  
  .obra button {
    border: none;
    border-radius: 10px;
    padding: 5px;
    background-color: #C72271;
    color: #F2FBFF;
    font-size: 20px;
    margin-top: 20px;
    height: 40px;
    width: 220px;
  }
  
  .obra a {
    text-decoration: none;
    color: #F2FBFF;
  }
  </style>
  