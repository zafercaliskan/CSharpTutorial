using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //Bu blok içerisinde context'i kullanır daha sonrasında bellekten atar. (Dispose eder.)
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //Burası veri tabanına Where ile sorgu atar. Sql de küçük büyük harf duyarlılığı yoktur.
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
                //Data bulursa kendisini bulamazsa null getirir.

                //SingleOrDefault ise biraz daha agresifdir. Birden fazla kayıt bulursa hata verir.
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();

                //yada aşağıdaki gibide yazabiliriz.

                //var entity = context.Entry(product);
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //primary key id üzerinden eşitler.
                var entity = context.Entry(product); //context'e abone ol. Kim için? -> parametre gelen product için
                entity.State = EntityState.Modified; //güncellendi işaretliyoruz.
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //primary key id üzerinden eşitler.
                var entity = context.Entry(product); //context'e abone ol. Kim için? -> parametre gelen product için
                entity.State = EntityState.Deleted; //güncellendi işaretliyoruz.
                context.SaveChanges();
            }
        }
    }
}
