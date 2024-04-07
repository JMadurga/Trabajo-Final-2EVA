import { defineStore } from 'pinia';

interface Obra {
  id: number;
  NombreObra: string;
  calories: number;
}

export const useObrasStore = defineStore('obras', {
  state: () => ({
    Obras: [
      { id: 1, NombreObra: 'Frozen Yogurt', calories: 159 },
      { id: 2, NombreObra: 'Ice cream sandwich', calories: 237 },
    ],
    newObra: { id: 0, NombreObra: '', calories: 0 },
    editingObra: null as Obra | null,
  }),
  actions: {
    addObras() {
      const newId = this.Obras.length > 0 ? Math.max(...this.Obras.map(obra => obra.id)) + 1 : 1;
      this.Obras.push({ ...this.newObra, id: newId });
      this.newObra = { id: 0, NombreObra: '', calories: 0 };
    },
    deleteObras(id: number) {
      const index = this.Obras.findIndex(item => item.id === id);
      if (index !== -1) {
        this.Obras.splice(index, 1);
      }
    },
    editObra(obra: Obra) {
      this.editingObra = { ...obra };
    },
    updateObra() {
        if (this.editingObra) {
          const index = this.Obras.findIndex(item => item.id === this.editingObra!.id);
          if (index !== -1) {
            this.Obras[index] = { ...this.editingObra };
          }
          this.editingObra = null;
        }
    },      
  },
});

