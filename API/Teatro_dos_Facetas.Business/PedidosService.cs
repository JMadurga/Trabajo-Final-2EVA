using System;
using System.Collections.Generic;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;

namespace Teatro_dos_Facetas.Business
{
    public class PedidosService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidosService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public List<Pedidos> GetAll() => _pedidoRepository.AllPedidos;

        public Pedidos GetPedidoById(int id)
        {
            return _pedidoRepository.GetPedido(id);
        }

        public void CreatePedido(Pedidos pedido)
        {
            _pedidoRepository.AddPedido(pedido);
        }

        public void UpdatePedido(Pedidos pedido)
        {
            _pedidoRepository.ChangePedido(pedido);
        }

        public void DeletePedido(int id)
        {
            _pedidoRepository.RemovePedido(id);
        }
    }
}