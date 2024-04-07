using System.Collections.Generic;
using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Data
{
    public interface IPedidoRepository
    {
        List<Pedidos> AllPedidos { get; }
        void AddPedido(Pedidos pedido);
        Pedidos GetPedido(int id);
        void ChangePedido(Pedidos pedido);
        void RemovePedido(int id);
        void SaveChanges();
    }
}