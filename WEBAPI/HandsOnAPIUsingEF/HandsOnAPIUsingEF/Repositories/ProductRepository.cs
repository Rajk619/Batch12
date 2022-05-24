using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Models;
namespace HandsOnAPIUsingEF.Repositories
{
    public class ProductRepository
    {
        private readonly Batch7DBContext context;
        public ProductRepository()
        {
            context = new Batch7DBContext();
        }
        public void AddProduct(Product product) //Add new row details to product table
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public List<Product> GetProducts()
        {
            return context.Products.ToList(); //return list of proudcts
        }
        public Product GetProduct(int id) //Get product details using productid
        {
            Product product = context.Products.Find(id);
            return product;
        }
        public void EditProduct(Product product) //Edit row 
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void DeleteProduct(int id) //Delete product row
        {
            Product product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

    }
}
