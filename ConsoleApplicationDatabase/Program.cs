using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj nazwe");
            //String categoryName = Console.ReadLine();

            //Category category = new Category { CategoryName = categoryName };
            ProdContext prodContext = new ProdContext();
            //prodContext.Categories.Add(category);
            //prodContext.SaveChanges();

            //var query = from c in prodContext.Categories
            //            orderby c.CategoryName descending
            //            select c.CategoryName;

            //getCategories(prodContext);
            //getCategoriesImmediately(prodContext);

            //getCategoriesAndProductsJoin(prodContext);
            //getCategoriesAndProductsJoinMethodSyntax(prodContext);
            //getProductsNavigationProperty(prodContext);
            //getProductsEagerLoading(prodContext);
            //getProductsNumberForCategory(prodContext);

            CategoryForm categoryForm = new CategoryForm();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            categoryForm.ShowDialog();

            Console.ReadLine();
        }

        private static void getCategories(ProdContext prodContext)
        {
            IQueryable<string> categories = prodContext.Categories
                .Select(c => c.CategoryName);

            foreach(var name in categories)
            {
                Console.WriteLine(name);
            }
        }

        private static void getCategoriesImmediately(ProdContext prodContext)
        {
            List<Category> categoryList = prodContext.Categories
                .ToList();

            foreach (var category in categoryList)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void getCategoriesAndProductsJoin(ProdContext prodContext)
        {
            var query =
                from c in prodContext.Categories
                join p in prodContext.Products
                on c.CategoryID equals p.CategoryID
                select new
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    ProductID = p.ProductID,
                    ProductName = p.Name
                };

            foreach (var product in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    product.CategoryID,
                    product.CategoryName,
                    product.ProductID,
                    product.ProductName);
            }
        }

        private static void getCategoriesAndProductsJoinMethodSyntax(ProdContext prodContext)
        {
            DbSet<Category> categories = prodContext.Categories;
            DbSet<Product> products = prodContext.Products;

            var query =
                categories.Join(
                    products,
                    product => product.CategoryID,
                    category => category.CategoryID,
                    (category, product) => new
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        ProductID = product.ProductID,
                        ProductName = product.Name
                    });

            foreach (var product in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    product.CategoryID,
                    product.CategoryName,
                    product.ProductID,
                    product.ProductName);
            }
        }

        private static void getProductsNavigationProperty(ProdContext prodContext)
        {
            var query =
                from c in prodContext.Categories
                select new
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Products = c.Products
                };

            foreach (var category in query)
            {
                Console.Write("{0}\t{1}\n",
                    category.CategoryID,
                    category.CategoryName);

                foreach (Product product in category.Products)
                {
                    Console.WriteLine("\t{0}\t{1}",
                        product.ProductID,
                        product.Name);
                }
            }
        }

        private static void getProductsEagerLoading(ProdContext prodConext)
        {
            var query =
                prodConext.Categories
                    .Include(c => c.Products)
                    .ToList();

            foreach (var category in query)
            {
                Console.Write("{0}\t{1}\n",
                    category.CategoryID,
                    category.CategoryName);

                foreach(var product in category.Products)
                {
                    Console.WriteLine("\t{0}\t{1}",
                        product.ProductID,
                        product.Name);
                }
            }
        }

        private static void getProductsNumberForCategory(ProdContext prodContext)
        {
            var query =
                from c in prodContext.Categories
                select new
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    ProductsNumber = c.Products.Count()
                };

            foreach (var category in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    category.CategoryID,
                    category.CategoryName,
                    category.ProductsNumber);
            }
        }

    }
}
