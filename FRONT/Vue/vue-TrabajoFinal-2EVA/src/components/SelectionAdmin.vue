<template>
  <div class="flex">
      <div>
        <img src="../media/logoadmin.png" alt="">
        <div class="left">
          <p>{{usuariosStore.user?.name}}</p>
          <v-btn size="x-large" block @click="ObrasVisible">OBRAS</v-btn>
          <v-btn size="x-large" block @click="SesionesVisible">SESIONES</v-btn>
          <v-btn size="x-large" block @click="UsuariosVisible">USUARIOS</v-btn>
        </div>
      </div>
      <div class="right">
          <v-table>
              <thead>
              <tr v-show="ObrasisVisible" v>
                  <th class="text-left">Obra</th>
                  <th class="text-left">Descripcion</th>
                  <th class="text-left">Categoría</th>
                  <th style="width: 80px">
                    <v-btn icon @click="toggle">
                      <v-icon>{{ icon }}</v-icon>
                    </v-btn>
                  </th>
              </tr>
              <tr v-show="SesionesisVisible">
                  <th class="text-left">Sesion</th>
                  <th class="text-left">Descripcion</th>
                  <th style="width: 80px">
                    <v-btn icon @click="toggle">
                      <v-icon>{{ icon }}</v-icon>
                    </v-btn>
                  </th>
              </tr>
              <tr v-show="UsuariosisVisible">
                  <th class="text-left">Nombre</th>
                  <th class="text-left">Apellidos</th>
                  <th class="text-left">Mail</th>
                  <th class="text-left">Telefono</th>
                  <th class="text-left">Contraseña</th>
                  <th style="width: 80px">
                    <v-btn icon @click="toggle">
                      <v-icon>{{ icon }}</v-icon>
                    </v-btn>
                  </th>
              </tr>
              </thead>
              <tbody>
              <tr v-show="ObrasisVisible" v-for="item in obrasStore.obras" :key="item.id">
                  <td>{{ item.id }}</td>
                  <td>{{ item.title }}</td>
                  <td>
                    <v-btn @click="obrasStore.actualizarObra(item)" style="margin-right: 10px;">edit</v-btn> <!-- Botón de edición -->
                    <v-btn @click="removeObra(item.id!)">delete</v-btn>
                  </td>
              </tr>
              <tr v-show="SesionesisVisible" v-for="item in sesionesStore.sessions" :key="item.id">
                  <td>{{ item.id }}</td>
                  <td>{{ item.obra }}</td>
                  <td>{{ item.date }}</td>
                  <td>
                    <v-btn @click="sesionesStore.updateSesion(item)" style="margin-right: 10px;">edit</v-btn> <!-- Botón de edición -->
                    <v-btn @click="sesionesStore.removeSesion(item.id!)">delete</v-btn>
                  </td>
              </tr>
              <tr v-show="UsuariosisVisible" v-for="item in usuariosStore.users" :key="item.name">
                  <td>{{ item.name }}</td>
                  <td>{{ item.email }}</td>
                  <td>
                    <v-btn @click="usuariosStore.updateUser(item)" style="margin-right: 10px;">edit</v-btn> <!-- Botón de edición -->
                    <v-btn @click="usuariosStore.removeUser(item.id!)">delete</v-btn>
                  </td>
              </tr>
              </tbody>
          </v-table>
          <div class="form-container" v-show="ObrasisVisible" v-if="visible">
            <v-fade-transition>
              <div>
                <v-form ref="form">
                  <v-text-field label="Obra" v-model="inputObra"></v-text-field>
                  <v-text-field label="Descripción" v-model="inputDescObra"></v-text-field>
                  <v-text-field label="Categoría" v-model="inputCateg"></v-text-field>
                  <v-btn color="primary" @click="addObrap">Añadir</v-btn>
                </v-form>
              </div>
            </v-fade-transition>
          </div>
          <div class="form-container" v-show="SesionesisVisible" v-if="visible">
            <v-fade-transition>
              <div>
                <v-form ref="form">
                  <v-text-field label="Sesion" v-model="inputObra"></v-text-field>
                  <v-text-field label="Descripción" v-model="inputDescObra"></v-text-field>
                  <v-btn color="primary" @click="addSesp">Añadir</v-btn>
                </v-form>
              </div>
            </v-fade-transition>
          </div>
          <div class="form-container" v-show="UsuariosisVisible" v-if="visible">
            <v-fade-transition>
              <div>
                <v-form ref="form">
                  <v-text-field label="Nombre" v-model="inputNmUsu"></v-text-field>
                  <v-text-field label="Apellidos" v-model="inputSrUsu"></v-text-field>
                  <v-text-field label="Mail" v-model="inputMlUsu"></v-text-field>
                  <v-text-field label="Telefono" v-model="inputTlUsu"></v-text-field>
                  <v-text-field label="Constraseña" v-model="inputPsUsu"></v-text-field>
                  <v-btn color="primary" @click="addUsup">Añadir</v-btn>
                </v-form>
              </div>
            </v-fade-transition>
          </div>
          <!--<div class="form-container" v-show="ObrasisVisible">
              <input type="text" v-model="newObra.title" placeholder="Titulo" />
              <input type="text" v-model="newObra.categoria" placeholder="categoria" />
              <input type="text" v-model="newObra.synopsis" placeholder="synopsis">
              <v-btn @click="addObra()">Add</v-btn> 
          </div>
          <div class="form-container" v-if="ObrasisVisible">
            <input type="text" v-model="newObra.title" placeholder="Titulo" />
            <input type="text" v-model="newObra.categoria" placeholder="Categoria" />
            <input type="text" v-model="newObra.synopsis" placeholder="synopsis" />
            <v-btn @click="updateObra()">Update</v-btn>
          </div>-->
          <!--<div class="form-container" v-show="SesionesisVisible">
              <input type="text" v-model="newSesion.obra" placeholder="obra" />            
              <v-btn @click="addSesiones">Add</v-btn>
          </div>
          <div class="form-container" v-show="UsuariosisVisible">
              <input type="text" v-model="newUsuario.name" placeholder="Name" />
              <input type="text" v-model="newUsuario.email" placeholder="Email" />
              <input type="text" v-model="newUsuario.password" placeholder="Password" />
              <input type="number" v-model="newUsuario.phone" placeholder="Phone" />
              <v-btn @click="addUser">Update</v-btn>
          </div>-->
          <!--<div class="form-container" v-show="UsuariosisVisible">
              <input type="text" v-model="newUsuario.name" placeholder="Name" />
              <input type="text" v-model="newUsuario.email" placeholder="Email" />
              <input type="text" v-model="newUsuario.password" placeholder="Password" />
              <input type="number" v-model="newUsuario.phone" placeholder=" Phone">
              <v-btn @click="addUser()">Add</v-btn>
          </div>-->
      </div>
  </div>
</template>

<script setup lang="ts">
import { ref, computed } from 'vue';
import { VBtn, VIcon, VTextField, VForm, VFadeTransition } from 'vuetify/components';

const visible = ref(false);
const inputObra = ref('');
const inputDescObra = ref('');
const inputCateg = ref('');

const inputSes = ref('');
const inputDescSes = ref('');

const inputNmUsu = ref('');
const inputSrUsu = ref('');
const inputMlUsu = ref('');
const inputTlUsu = ref('');
const inputPsUsu = ref('');

const toggle = () => {
  visible.value = !visible.value;
};

const addObrap = () => {
  console.log(inputObra.value, inputDescObra.value, inputCateg.value);
  toggle();
};

const addSesp = () => {
  console.log(inputSes.value, inputDescSes.value);
  toggle();
};

const addUsup = () => {
  console.log(inputNmUsu.value, inputSrUsu.value, inputMlUsu.value, inputTlUsu.value, inputPsUsu.value);
  toggle();
};

const icon = computed(() => visible.value ? 'mdi-minus' : 'mdi-plus');

import  {ObraStore}  from '@/stores/obraStore';
import  {SesionStore} from '@/stores/sesionStore'; // cammbiar store 
import { UserStore } from '@/stores/userStore';


const obrasStore = ObraStore();
const sesionesStore = SesionStore();
const usuariosStore = UserStore();
const newObra = ref({ title: "", categoria: "", synopsis: "" });
const newUsuario = ref({ name: "", email: "", password: "", phone:0 });
const newSesion = ref({ obra: "", date: Date.now() });


function addObra() {
  obrasStore.crearObra(newObra.value);
}
 function addSesiones() {
  sesionesStore.addSession(newSesion.value);
 }
function updateObra() {

  obrasStore.actualizarObra(newObra.value);
}

function removeObra(id: number) {
  obrasStore.eliminarObra(id);
}

function addUser() {
  usuariosStore.addUser(newUsuario.value);
} 


obrasStore.cargarObras();
sesionesStore.fetchSessions();  
usuariosStore.fetchUsers();  
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
