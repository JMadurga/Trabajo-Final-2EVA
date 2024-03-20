import { defineStore } from 'pinia';

interface Obra {
  id: number;
  title: string;
  subtitle: string;
  content: string;
  imgSrc: string;
  price: number;
}

export const useObraSeleccionadaStore = defineStore({
  id: 'obraSeleccionada',
  state: () => ({
    obraSeleccionada: null as Obra | null, // Aquí estamos indicando que la obra seleccionada puede ser un objeto de tipo Obra o nulo
  }),
  actions: {
    seleccionarObra(obra: Obra) {
      this.obraSeleccionada = obra;
    },
  },
});
