import { defineStore } from 'pinia';

export interface Pedido {
  pedidoId?: number;
  userId: number;
  sesionId: Number;
  asientosId: number[];
  isEditing?:boolean;
}

export const PedidoStore = defineStore({
  id: 'pedidoSeleccionado',
  state: () => ({
    pedidos: [] as Pedido[],
  }),
  actions: {
        async cargarPedidos() {
            try {
                const response = await fetch('http://localhost:8001/Pedidos');
                const data = await response.json();
                this.pedidos = data;
            } catch (error) {
                console.error('Failed to fetch pedidos:', error);
            }
        },
        async addPedido(pedido: Pedido) {
            try {
                const response = await fetch('http://localhost:8001/Pedidos', {
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
                await fetch(`http://localhost:8001/Pedidos/${pedidoId}`, {
                    method: 'DELETE',
                });
                this.pedidos = this.pedidos.filter(pedido => pedido.pedidoId !== pedidoId);

            } catch (error) {
                console.error('Failed to remove pedido:', error);
            }
        },

  },
});
