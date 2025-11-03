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
    public interface IUnitOfWork: IDisposable
    {
        IProductRepositries Products { get; }
        //ICategoryRepositries Categories { get; }
        IGenericRepo<Category> Categories { get; }
        IGenericRepo<Cart> Carts { get; }
        IGenericRepo<CartItems> CartItems { get; }
        IGenericRepo<Order> Orders { get; }
        IGenericRepo<OrderItems> OrderItems { get; }

        IGenericRepo<Payment> Payment { get; }

        //IGenericRepo<T> Repository<T>() where T : class;

        Task<int> CompleteAsync();
        
    }
}
