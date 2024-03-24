import { reactive } from 'vue';

interface Asiento {
    id: number;
    ocupado: boolean;
}

const asientoStore = reactive({
    asientos: [] as Asiento[],
    fetchAsientos: async () => {
        try {
            const response = await fetch('http://localhost:8001/asientos');
            const data = await response.json();
            asientoStore.asientos = data;
        } catch (error) {
            console.error('Error al obtener los asientos:', error);
        }
    },
    reservarAsiento: async (id: number, ocupado: boolean) => {
        try {
            const response = await fetch(`http://localhost:8001/asientos/${id}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ ocupado }),
            });
            if (response.ok) {
                // Actualizar el estado del asiento reservado
                const index = asientoStore.asientos.findIndex((asiento) => asiento.id === id);
                if (index !== -1) {
                    asientoStore.asientos[index].ocupado = ocupado;
                }
            } else {
                console.error('Error al reservar el asiento:', response.status);
            }
        } catch (error) {
            console.error('Error al reservar el asiento:', error);
        }
    },
});

export default asientoStore;