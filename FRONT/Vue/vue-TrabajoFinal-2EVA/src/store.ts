// src/store.ts
import { reactive } from 'vue';

// Define la estructura de tu estado global
interface AppState {
  tab: number | null;
}

// Crea una instancia reactiva de tu estado
export const appState = reactive<AppState>({
  tab: null,
});

// Exporta cualquier otra cosa que necesites (acciones, mutaciones, etc.)
