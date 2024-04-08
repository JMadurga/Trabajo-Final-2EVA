<template>
  <div class="flex">
      <div class="left">
          <p>NOMBRE DE USUARIO</p>
          <v-btn size="x-large" block @click="ObrasVisible">OBRAS</v-btn>
          <v-btn size="x-large" block @click="SesionesVisible">SESIONES</v-btn>
          <v-btn size="x-large" block @click="UsuariosVisible">USUARIOS</v-btn>
      </div>
      <div class="right">
          <v-table>
              <thead>
              <tr v-show="ObrasisVisible">
                  <th class="text-left">Obra</th>
                  <th class="text-left">Descripcion</th>
                  <th class="text-left">Actions</th>
              </tr>
              <tr v-show="SesionesisVisible">
                  <th class="text-left">Sesion</th>
                  <th class="text-left">Descripcion</th>
                  <th class="text-left">Actions</th>
              </tr>
              <tr v-show="UsuariosisVisible">
                  <th class="text-left">Name</th>
                  <th class="text-left">Surname</th>
                  <th class="text-left">Actions</th>
              </tr>
              </thead>
              <tbody>
              <tr v-show="ObrasisVisible" v-for="item in obrasStore.Obras" :key="item.NombreObra">
                  <td>{{ item.NombreObra }}</td>
                  <td>{{ item.synopsis }}</td>
                  <td>
                    <v-btn @click="obrasStore.editObra(item)" style="margin-right: 10px;">edit</v-btn> <!-- Botón de edición -->
                    <v-btn @click="obrasStore.deleteObras(item.id)">delete</v-btn>
                  </td>
              </tr>
              <tr v-show="SesionesisVisible" v-for="item in sesionesStore.Sesiones" :key="item.name">
                  <td>{{ item.name }}</td>
                  <td>{{ item.calories }}</td>
                  <td>
                    <v-btn @click="sesionesStore.editSesion(item)" style="margin-right: 10px;">edit</v-btn> <!-- Botón de edición -->
                    <v-btn @click="sesionesStore.deleteSesiones(item.id)">delete</v-btn>
                  </td>
              </tr>
              <tr v-show="UsuariosisVisible" v-for="item in usuariosStore.Usuarios" :key="item.name">
                  <td>{{ item.name }}</td>
                  <td>{{ item.calories }}</td>
                  <td>
                    <v-btn @click="usuariosStore.editUsuario(item)" style="margin-right: 10px;">edit</v-btn> <!-- Botón de edición -->
                    <v-btn @click="usuariosStore.deleteUsuarios(item.id)">delete</v-btn>
                  </td>
              </tr>
              </tbody>
          </v-table>
          <div class="form-container" v-show="ObrasisVisible">
              <input type="text" v-model="obrasStore.newObra.NombreObra" placeholder="Name" />
              <input type="text" v-model="obrasStore.newObra.synopsis" placeholder="Synopsis" />
              <v-btn @click="obrasStore.addObras">Add</v-btn>
          </div>
          <div class="form-container" v-if="obrasStore.editingObra">
            <input type="text" v-model="obrasStore.editingObra.NombreObra" placeholder="Name" />
            <input type="text" v-model="obrasStore.editingObra.synopsis" placeholder="Synopsis" />
            <v-btn @click="obrasStore.updateObra">Update</v-btn>
          </div>
          <div class="form-container" v-show="SesionesisVisible">
              <input type="text" v-model="sesionesStore.newSesion.name" placeholder="Name" />
              <input type="number" v-model="sesionesStore.newSesion.calories" placeholder="Calories" />
              <v-btn @click="sesionesStore.addSesiones">Add</v-btn>
          </div>
          <div class="form-container" v-show="UsuariosisVisible">
              <input type="text" v-model="usuariosStore.newUsuario.name" placeholder="Name" />
              <input type="number" v-model="usuariosStore.newUsuario.calories" placeholder="Calories" />
              <v-btn @click="usuariosStore.addUsuarios">Add</v-btn>
          </div>
      </div>
  </div>
</template>

<script setup lang="ts">
import { reactive, ref } from 'vue';

import { useObrasStore } from '@/stores/ObrasStore';
import { useSesionesStore } from '@/stores/SesionesStore';
import { useUsuariosStore } from '@/stores/UsuariosStore';

const obrasStore = useObrasStore();
const sesionesStore = useSesionesStore();
const usuariosStore = useUsuariosStore();

//-------------------------------------------------------------------

const ObrasisVisible = ref(false);
const SesionesisVisible = ref(false);
const UsuariosisVisible = ref(false);

function ObrasVisible() {
  ObrasisVisible.value = !ObrasisVisible.value;
  SesionesisVisible.value = false;
  UsuariosisVisible.value = false;
}
function SesionesVisible() {
  SesionesisVisible.value = !SesionesisVisible.value;
  ObrasisVisible.value = false;
  UsuariosisVisible.value = false;
}
function UsuariosVisible() {
  UsuariosisVisible.value = !UsuariosisVisible.value;
  SesionesisVisible.value = false;
  ObrasisVisible.value = false;
}
</script>


<style scoped>

.text-left {
  font-size: 20px;
  color: #333;
}

.v-table {
  width: 100%;
  border-collapse: collapse;
  margin-top: 20px;
  color: black;
  background-color: white;
}

.v-table th, .v-table td {
  padding: 10px;
  border: 1px solid #ddd;
  text-align: left;
}

.v-table th {
  background-color: #f4f4f4;
}

.v-table tbody tr:nth-child(odd) {
  background-color: #f9f9f9;
}

.flex {
  display: flex;
  flex-direction: row;
}

.left {
  flex: 30%;
  padding-block: 20px;
  padding-inline: 50px;
  background-color: rgba(62,78,98,.8);
  height: 100vh;
  text-align: center;
  color: white;
}

.left .v-btn {
  margin-block: 20px;
  background-color: #4C6EF5;
  color: white;
  border: none;
  padding: 10px 20px;
  cursor: pointer;
}

.right {
  flex: 70%;
  padding: 35px;
  background-color: #e3e6f3;
}

.form-container {
  margin-top: 20px;
  background-color: #fff;
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 0 10px rgba(0,0,0,0.1);
}

.form-container input[type="text"],
.form-container input[type="number"] {
  padding: 10px;
  margin: 10px 10px;
  width: 200px;
  border-radius: 4px;
  border: 1px solid #ccc;
}

.form-container input[type="text"]:focus,
.form-container input[type="number"]:focus {
  outline: none;
  border-color: #4C6EF5;
}

.form-container v-btn {
  background-color: #4C6EF5;
  color: white;
  border: none;
  padding: 10px 20px;
  cursor: pointer;
  margin-left: 10px;
}

p {
  font-size: 20px;
  margin: 20px;
  color: white;
}

.v-icon {
  cursor: pointer;
  color: red;
}
</style>
