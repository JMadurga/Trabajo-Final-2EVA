import { defineStore } from 'pinia';

interface Sesion {
  id: number;
  name: string;
  calories: number;
}

export const useSesionesStore = defineStore('sesions', {
  state: () => ({
    Sesiones: [
      { id: 1, name: 'Frozen Yogurt', calories: 159 },
      { id: 2, name: 'Ice cream sandwich', calories: 237 },
    ],
    newSesion: { id: 0, name: '', calories: 0 },
    editingSesion: null as Sesion | null,
  }),
  actions: {
    addSesiones() {
      const newId = this.Sesiones.length > 0 ? Math.max(...this.Sesiones.map(sesion => sesion.id)) + 1 : 1;
      this.Sesiones.push({ ...this.newSesion, id: newId });
      this.newSesion = { id: 0, name: '', calories: 0 };
    },
    deleteSesiones(id: number) {
      const index = this.Sesiones.findIndex(item => item.id === id);
      if (index !== -1) {
        this.Sesiones.splice(index, 1);
      }
    },
    editSesion(sesion: Sesion) {
      this.editingSesion = { ...sesion };
    },
    updateSesion() {
        if (this.editingSesion) {
          const index = this.Sesiones.findIndex(item => item.id === this.editingSesion!.id);
          if (index !== -1) {
            this.Sesiones[index] = { ...this.editingSesion };
          }
          this.editingSesion = null;
        }
    },      
  },
});

