import { defineStore } from 'pinia';

interface Usuario {
  id: number;
  name: string;
  calories: number;
}

export const useUsuariosStore = defineStore('usuarios', {
  state: () => ({
    Usuarios: [
      { id: 1, name: 'Frozen Yogurt', calories: 159 },
      { id: 2, name: 'Ice cream sandwich', calories: 237 },
    ],
    newUsuario: { id: 0, name: '', calories: 0 },
    editingUsuario: null as Usuario | null,
  }),
  actions: {
    addUsuarios() {
      const newId = this.Usuarios.length > 0 ? Math.max(...this.Usuarios.map(usuario => usuario.id)) + 1 : 1;
      this.Usuarios.push({ ...this.newUsuario, id: newId });
      this.newUsuario = { id: 0, name: '', calories: 0 };
    },
    deleteUsuarios(id: number) {
      const index = this.Usuarios.findIndex(item => item.id === id);
      if (index !== -1) {
        this.Usuarios.splice(index, 1);
      }
    },
    editUsuario(usuario: Usuario) {
      this.editingUsuario = { ...usuario };
    },
    updateUsuario() {
        if (this.editingUsuario) {
          const index = this.Usuarios.findIndex(item => item.id === this.editingUsuario!.id);
          if (index !== -1) {
            this.Usuarios[index] = { ...this.editingUsuario };
          }
          this.editingUsuario = null;
        }
    },      
  },
});

