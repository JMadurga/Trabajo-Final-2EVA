import { reactive } from 'vue';
import { defineStore } from 'pinia';

 export interface Session {
    id?: number;
    obra: string;
    date: number;
    asientos?: number[];
}

const sesionStore = reactive({
    sessions: [] as Session[],
    loading: false,
    error: null as string | null,
});

export const SesionStore = defineStore('sesionStore', {
    state: () => ({
        sessions: [] as Session[],
    }),
    actions: {
        async  fetchSessions() {
            try {
                sesionStore.loading = true;
                const response = await fetch('http://localhost:8001/Sesion');
                const data = await response.json();
                sesionStore.sessions = data;
            } catch (error) {
                sesionStore.error = error as string;
            } finally {
                sesionStore.loading = false;
            }
        },

        async  addSession(session: Session) {
            try {
                const response = await fetch('http://localhost:8001/Sesion', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(session),
                });
                const data = await response.json();
                sesionStore.sessions.push(data);
            } catch (error) {
                console.error('Failed to add session:', error);
            }
        },
        async removeSesion(sesionId: number) {
            try {
                await fetch(`http://localhost:8001/Sesion/${sesionId}`, {
                    method: 'DELETE',
                });
                sesionStore.sessions = sesionStore.sessions.filter(session => session.id !== sesionId);

            } catch (error) {
                console.error('Failed to remove sesion:', error);
            }
        },
        async updateSesion(updatedSesion: Session) {  
            try {
                const response = await fetch(`http://localhost:8001/Sesion/${updatedSesion.id}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(updatedSesion),
                });
                const data = await response.json();
                const index = sesionStore.sessions.findIndex(session => session.id === updatedSesion.id);
                if (index !== -1) {
                    sesionStore.sessions[index] = data;
                }
            } catch (error) {
                console.error('Failed to update sesion:', error);
        }  

    }
}
});


export default {
    sesionStore};