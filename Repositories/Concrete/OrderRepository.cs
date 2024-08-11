using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
	public class OrderRepository : RepositoryBase<Order>, IOrderRepository
	{
		public OrderRepository(RepositoryContext context) : base(context)
		{

		}
		public IQueryable<Order> Orders => _context.Orders
			.Include(o => o.Lines)
			.ThenInclude(cl => cl.Product)
			.OrderBy(o => o.Shipped)
			.ThenByDescending(o => o.Id);

		public int NumberOfInProcess =>
			_context.Orders.Count(o => o.Shipped.Equals(false));

		public void Complete(int id)
		{
			Order order = FindByCondition(o => o.Id.Equals(id), true);
			if (order is not null)
			{
				order.Shipped = true;
			}
			else
				throw new Exception("Order could not found!");
		}

		public Order? GetOneOrder(int id)
		{
			return FindByCondition(o => o.Id.Equals(id), false);
		}

		public void SaveOrder(Order order)
		{
			_context.AttachRange(order.Lines.Select(l => l.Product));
			if (order.Id == 0)
			{
				_context.Orders.Add(order);
			}
			_context.SaveChanges();
		}
	}
}
