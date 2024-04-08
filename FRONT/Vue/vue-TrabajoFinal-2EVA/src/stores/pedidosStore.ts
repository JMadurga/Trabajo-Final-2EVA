import { defineStore } from 'pinia';

interface Pedido {
  id?: number;
  User: number;
  Sesion: Number;
  asientos: number[];
}

export const PedidoStore = defineStore({
  id: 'pedidoSeleccionado',
  state: () => ({
    pedidos: [] as Pedido[],
  }),
  actions: {
        async cargarPedidos() {
            try {
                const response = await fetch('http://localhost:8001/Pedido');
                const data = await response.json();
                this.pedidos = data;
            } catch (error) {
                console.error('Failed to fetch pedidos:', error);
            }
        },
        async addPedido(pedido: Pedido) {
            try {
                const response = await fetch('http://localhost:8001/Pedido', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(pedido),
                });
                const data = await response.json();
                this.pedidos.push(data);
            } catch (error) {
                console.error('Failed to add pedido:', error);
            }
        },
        async removePedido(pedidoId: number) {
            try {
                await fetch(`http://localhost:8001/Pedido/${pedidoId}`, {
                    method: 'DELETE',
                });
                this.pedidos = this.pedidos.filter(pedido => pedido.id !== pedidoId);

            } catch (error) {
                console.error('Failed to remove pedido:', error);
            }
        },

  },
});
