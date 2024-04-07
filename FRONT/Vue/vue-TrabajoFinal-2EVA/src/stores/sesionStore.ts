import { reactive } from 'vue';

interface Session {
    id: number;
    name: string;
    date: string;
}

const sesionStore = reactive({
    sessions: [] as Session[],
    loading: false,
    error: null as string | null,
});

async function fetchSessions() {
    sesionStore.loading = true;
    sesionStore.error = null;

    try {
        const response = await fetch('http://localhost:8001/sessions');
        if (!response.ok) {
            throw new Error('Failed to fetch sessions');
        }

        sesionStore.sessions = await response.json();
    } catch (error) {
        sesionStore.error = error.message;
    } finally {
        sesionStore.loading = false;
    }
}

export default {
    sesionStore,
    fetchSessions,
};