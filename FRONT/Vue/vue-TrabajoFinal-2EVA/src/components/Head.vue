<!-- Header.vue -->
<template>
    <header class="header">
      <div class="header-leftside">
        <div class="header-leftside-logo"><router-link to="/"><img src="../media/logo-BC.png" alt=""></router-link></div>
        <div class="header-leftside-nav">
          <router-link to="/obras" class="nav-text">Obras</router-link>
          <router-link to="/promotion" class="nav-text">Promociones</router-link>
        </div>
      </div>
      <div class="header-rigthside">
        <div class="header-rigthside-buttons">
          <router-link to="/cart"><img src="../media/Carrito.png" alt=""></router-link>
        </div>
      </div>
      <div class="dropdown">
        <img src="../media/lista.png" alt="">
        <div class="dropdown-content">
          <router-link to="/cart">Carrito</router-link>
          <router-link to="/obras">Obras</router-link>
          <router-link to="/promotion">Promociones</router-link>
        </div>
      </div>
    </header>
  </template>
  
  <style scoped>
  .header {
    width: 100%;
    height: 100px;
    background-color: #3E4E62;
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin: 0px;
  }
  
  .header-leftside {
    display: flex;
    margin-left: 10px;
    align-items: center;
    justify-content: center;
  }
  
  .header-leftside-logo img {
    width: 200px;
    height: 75px;
    border-radius: 20px;
  }
  
  .header-leftside-nav {
    margin-left: 50px;
  }
  
  .nav-text {
    text-decoration: none;
    font-size: x-large;
    font-weight: 400;
    padding-left: 10px;
    color: #F2FBFF;
  }
  
  .header-rigthside {
    display: flex;
    padding-right: 20px;
  }
  
  .header-rigthside-buttons {
    margin-left: 15px;
    background-color: #C72271;
    height: 50px;
    width: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 50%;
  }
  
  .header-rigthside-buttons img {
    width: 30px;
    height: 30px;
    filter: invert(83%) sepia(35%) saturate(120%) hue-rotate(188deg) brightness(109%) contrast(102%);
  }
  
  .dropdown {
    position: relative;
    display: inline-block;
    display: block;
    margin-right: 10px;
    align-items: center;
    display: none;
  }
  
  .dropdown img {
    width: 35px;
    height: 35px;
  }
  
  .dropdown-content {
    display: none;
    position: absolute;
    right: 10px;
    background-color: #f9f9f9;
    min-width: 160px;
    box-shadow: 0 8px 16px rgba(0, 0, 0, 0.2);
    z-index: 1;
  }
  
  .dropdown-content a {
    color: black;
    padding: 12px 16px;
    text-decoration: none;
    display: block;
  }
  
  .dropdown-content a:hover {
    background-color: #f1f1f1;
  }
  
  .dropdown:hover .dropdown-content {
    display: block;
  }
  
  @media only screen and (max-width: 767px) {
    .header-rigthside {
      display: none;
    }
    .header-leftside-nav {
      display: none;
    }
    .header-leftside-logo img {
      width: 100px;
      height: 35px;
      border-radius: 20px;
    }
    .dropdown {
      display: block;
    }
  }
  </style>
  