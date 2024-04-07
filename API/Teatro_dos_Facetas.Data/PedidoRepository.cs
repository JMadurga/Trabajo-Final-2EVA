using System.Collections.Generic;
using System.Linq;
using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;
using Teatro_dos_facetas.Data;

namespace Teatro_dos_Facetas.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly TeatroContext _context;

        public PedidoRepository(TeatroContext context)
        {
            _context = context;
        }

        
        public List<Pedidos> AllPedidos => _context.Pedidos.ToList();

        public void AddPedido(Pedidos pedido)
        {
            _context.Pedidos.Add(pedido);
            SaveChanges();
        }

        public void RemovePedido(int id)
        {
            var pedido = _context.Pedidos.FirstOrDefault(p => p.id == id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                SaveChanges();
            }
        }

        public Pedidos GetPedido(int id)
        {
            return _context.Pedidos.FirstOrDefault(p => p.id == id);
        }

        public void ChangePedido(Pedidos pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}