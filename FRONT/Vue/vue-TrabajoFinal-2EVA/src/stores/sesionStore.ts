import { reactive } from 'vue';
import { defineStore } from 'pinia';
import {ObraStore  } from "@/stores/obraStore";

 export interface Session {
    sesionId?: number;
    obraId?: number;
    obra: string;
    date: number;
    asientos?: number[];
    price? :number;
    isEditing?:boolean;
}


export const SesionStore = defineStore('sesionStore', {
    state: () => ({
        sessions: [] as Session[],
        loading: false,
        error: null as string | null,
    }),
    actions: {
        async  fetchSessions() {
            try {
                this.loading = true;
                const response = await fetch('http://localhost:8001/Sesion');
                const data = await response.json();
                this.sessions = data;
            } catch (error) {
                this.error = error as string;
            } finally {
                this.loading = false;
            }
        },

        async  fetchSessionsObra() {
            try {
                
                await this.fetchSessions();

                this.sessions.forEach(  (sesion: any, i) => {  
                    fetch(`http://localhost:8001/Obra/${sesion.obraId}`).then(value => value.json()).then((obra) => {
                        this.sessions[i] = {
                            
                            ...this.sessions[i],
                            obra : obra.name,
                        };
                        console.log(this.sessions)
                     });
                
                  });
                  
            } catch (error) {
                this.error = error as string;
            } finally {
                this.loading = false;
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
                this.sessions.push(data);
            } catch (error) {
                console.error('Failed to add session:', error);
            }
        },
        async removeSesion(sesionId: number) {
            try {
                await fetch(`http://localhost:8001/Sesion/${sesionId}`, {
                    method: 'DELETE',
                });
                this.sessions = this.sessions.filter(session => session.sesionId !== sesionId);

            } catch (error) {
                console.error('Failed to remove sesion:', error);
            }
        },
        async updateSesion(updatedSesion: Session) {  
            try {
                const response = await fetch(`http://localhost:8001/Sesion/${updatedSesion.sesionId}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(updatedSesion),
                });
                const data = await response.json();
                const index = this.sessions.findIndex(session => session.sesionId === updatedSesion.sesionId);
                if (index !== -1) {
                    this.sessions[index] = data;
                }
            } catch (error) {
                console.error('Failed to update sesion:', error);
        }  

    }
}
});


export default {
    SesionStore};