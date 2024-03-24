import { defineStore } from 'pinia';


interface Obra {
  id: number;
  title: string;
  subtitle: string;
  content: string;
  imgSrc: string;
  price: number;
}

export const ObraStore = defineStore({
  id: 'obraSeleccionada',
  state: () => ({
    obras: [] as Obra[],
  }),
  actions: {
    async seleccionarObra(obraId: number) {
      try {
        const response = await fetch(`http://localhost:8001/obras/${obraId}`);
        const obra = await response.json();
        this.obras.push(obra);
      } catch (error) {
        console.error('Error selecting obra:', error);
      }
    },
  },
});