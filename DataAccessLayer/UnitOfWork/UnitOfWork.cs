using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositries.Category;
using DataAccessLayer.Repositries.Generic;
using DataAccessLayer.Repositries.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly Dictionary<Type, object> _repos = new();


        public IProductRepositries Products { get; private set; }

        public IGenericRepo<Category> Categories { get; private set; }

        public IGenericRepo<Cart> Carts { get; private set; }

        public IGenericRepo<CartItems> CartItems { get; private set; }

        public IGenericRepo<Order> Orders { get; private set; }
        public IGenericRepo<OrderItems> OrderItems { get; private set; }

        public IGenericRepo<Payment> Payment { get; private set; }

        //public ICategoryRepositries Categories {  get; private set; }

        public UnitOfWork (ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepositries(_context);
            //Categories = new CategoryRepositries(_context);
            Categories = new GenericRepo<Category>(_context);
            Orders = new GenericRepo<Order>(_context);
            Carts = new GenericRepo<Cart>(_context);
            CartItems = new GenericRepo<CartItems>(_context);
            OrderItems = new GenericRepo<OrderItems>(_context);
            Payment = new GenericRepo<Payment>(_context);

        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepo<T> Repository<T>() where T : class
        {
            if (!_repos.ContainsKey(typeof(T)))
            {
                var repo = new GenericRepo<T>(_context);
                _repos.Add(typeof(T), repo);
            }
            return (IGenericRepo<T>) _repos[typeof(T)];
        }
    }
}
