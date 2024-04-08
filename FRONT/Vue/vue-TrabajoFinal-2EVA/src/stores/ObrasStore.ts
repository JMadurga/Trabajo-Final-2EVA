import { defineStore } from 'pinia';

interface Obra {
  id: number;
  NombreObra: string;
  synopsis: string; // Changed from calories to synopsis and type number to string
}

export const useObrasStore = defineStore('obras', {
  state: () => ({
    Obras: [
      { id: 1, NombreObra: 'El fantasma de la ópera', synopsis: 'La historia de un misterioso genio musical desfigurado y su obsesión por una hermosa joven soprano.' },
      { id: 2, NombreObra: 'Hamlet', synopsis: 'La tragedia de Shakespeare sobre el Príncipe de Dinamarca que busca venganza contra su tío, quien ha asesinado a su padre, tomado el trono y casado con su madre.' },
      { id: 3, NombreObra: 'Los miserables', synopsis: 'Una historia dramática de redención y revolución ambientada en la Francia del siglo XIX, siguiendo las vidas e interacciones de varios personajes.' },
      { id: 4, NombreObra: 'El rey león', synopsis: 'Un musical basado en la película animada de Disney, que cuenta la historia de Simba, un joven príncipe león en su camino para entender su responsabilidad como rey.' },
      { id: 5, NombreObra: 'La casa de Bernarda Alba', synopsis: 'Una obra de Federico García Lorca que retrata la vida de las mujeres en los pueblos españoles, dominadas por la rigidez y las normas de la sociedad.' }
    ],
    newObra: { id: 0, NombreObra: '', synopsis: '' }, // Changed calories to synopsis and default value to empty string
    editingObra: null as Obra | null,
  }),
  actions: {
    addObras() {
      const newId = this.Obras.length > 0 ? Math.max(...this.Obras.map(obra => obra.id)) + 1 : 1;
      this.Obras.push({ ...this.newObra, id: newId });
      this.newObra = { id: 0, NombreObra: '', synopsis: '' }; // Changed calories to synopsis and set default value to empty string
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
