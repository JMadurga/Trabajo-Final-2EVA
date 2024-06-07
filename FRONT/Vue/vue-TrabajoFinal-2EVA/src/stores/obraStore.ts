import { defineStore } from 'pinia';

 export interface Obra {
  id?: number;
  name: string;
  categoria: string;
  synopsis: string;
  isEditing?:boolean;
}

export const ObraStore = defineStore({
  id: 'obraSeleccionada',
  state: () => ({
    obras: [] as Obra[],
  }),
  actions: {
    async cargarObras() {
      try {
        const response = await fetch('http://localhost:8001/Obra');
        const obras = await response.json();
        this.obras = obras;
      } catch (error) {
        console.error('Error cargando obras:', error);
      }
    },
    async obtenerObra(id: number) {
      try {
        const response = await fetch(`http://localhost:8001/Obra/${id}`);
        const obra = await response.json();
        return obra ;
      } catch (error) {
        console.error('Error obteniendo obra:', error);
        return null;
      }
    },
    async crearObra(obra: Obra) {
      try {
        const response = await fetch('http://localhost:8001/Obra', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(obra),
        });
        if (response.ok) {
          const nuevaObra = await response.json();
          this.obras.push(nuevaObra);
        } else {
          console.error('Error al crear obra:', response.statusText);
        }
      } catch (error) {
        console.error('Error al crear obra:', error);
      }
    },
    async actualizarObra(obra: Obra) {
      try {
        const response = await fetch(`http://localhost:8001/Obra/${obra.id}`, {
          method: 'PUT',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(obra),
        });
        if (response.ok) {
          const obraActualizada = await response.json();
          const index = this.obras.findIndex(o => o.id === obraActualizada.id);
          if (index !== -1) {
            this.obras[index] = obraActualizada;
          }
        } else {
          console.error('Error al actualizar obra:', response.statusText);
        }
      } catch (error) {
        console.error('Error al actualizar obra:', error);
      }
    },
    async eliminarObra(id: number) {
      try {
        const response = await fetch(`http://localhost:8001/Obra/${id}`, {
          method: 'DELETE',
        });
        if (response.ok) {
          this.obras = this.obras.filter(obra => obra.id !== id);
        } else {
          console.error('Error al eliminar obra:', response.statusText);
        }
      } catch (error) {
        console.error('Error al eliminar obra:', error);
      }
    },
  },
});
