<template>
  <div class="flex">
      <div class="left">
          <p>NOMBRE DE USUARIO</p>
          <v-btn size="x-large" block>OBRAS</v-btn>
          <v-btn size="x-large" block>SESIONES</v-btn>
          <v-btn size="x-large" block>USUARIOS</v-btn>
      </div>
      <div class="right">
          <v-table>
              <thead>
              <tr>
                  <th class="text-left">Name</th>
                  <th class="text-left">Calories</th>
                  <th class="text-left">Actions</th>
              </tr>
              </thead>
              <tbody>
              <tr v-for="item in desserts" :key="item.name">
                  <td>{{ item.name }}</td>
                  <td>{{ item.calories }}</td>
                  <td><v-btn @click="deleteDessert(item.name)">delete</v-btn></td>
              </tr>
              </tbody>
          </v-table>
          <div class="form-container">
              <input type="text" v-model="newItem.name" placeholder="Name" />
              <input type="number" v-model="newItem.calories" placeholder="Calories" />
              <v-btn @click="addDessert">Add</v-btn>
          </div>
      </div>
  </div>
</template>

<script setup lang="ts">
import { reactive, ref } from 'vue'

let desserts = reactive([
    { name: 'Frozen Yogurt', calories: 159 },
    { name: 'Ice cream sandwich', calories: 237 },
])

let newItem = ref({ name: '', calories: 0 })

const addDessert = () => {
    desserts.push({ ...newItem.value })
    newItem.value = { name: '', calories: 0 }
}

const deleteDessert = (name: string) => {
    const index = desserts.findIndex(item => item.name === name)
    if (index !== -1) {
        desserts.splice(index, 1)
    }
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
