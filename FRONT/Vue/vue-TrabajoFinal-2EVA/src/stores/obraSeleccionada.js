// stores/playsStore.js
import { defineStore } from 'pinia'

export const usePlaysStore = defineStore('obraSeleccionada', {
  state: () => ({
    selectedPlay: null,
  }),
  actions: {
    selectPlay(play) {
      this.selectedPlay = play;
    }
  }
})
