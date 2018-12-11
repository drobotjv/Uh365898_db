using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uh365898_db.Domain.Entities;
using uh365898_db.Domain.Abstract;

namespace uh365898_db.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product product);// метод для сохранения результатов редактирования в админке
        Product DeleteProduct(int productID); // метод для удаления продуктов в админке
        void UpdateProduct(Product product);

        IQueryable<Offer> Offers { get; } // метод для получения результатов
        void SaveOffer(Offer offer);// сохранение результатов
        Offer DeleteOffer(int offerID); // метод для удаления c формы обратная связь

        IQueryable<Guestbook> Guestbooks { get; }
        void SaveGuestbook(Guestbook guestbook);
        Guestbook DeleteGuestbook(int guestbookID);

        IQueryable<Shipping> Shippings { get; }
        void SaveShipping(Shipping shipping);
        Shipping FindShipping(int shipID);

        IQueryable<Order> Orders { get; }
        void SaveOrder(Cart cart, Shipping shipping, Order order);
                
        IQueryable<Categone> Categones { get; }
        void SaveCategone(Categone categone);
        Categone DeleteCategone(int categoneID);

        IQueryable<Producer> Producers { get; }
        void SaveProducer(Producer producer);
        Producer DeleteProducer(int producerID);

        IQueryable<Packing> Packings { get; }
       // void SavePacking(Packing packing);
      //  Producer DeletePacking(int packingID);

        IQueryable<Categzer> Categzers { get; }

        IQueryable<Categtw> Categtws { get; }
       // void SaveCategtwo(Categtwo categtwo);
        //Producer DeleteCategtwo(int categtwoID);

        IQueryable<Proper> Propers { get; }
        // void SaveCategtwo(Categtwo categtwo);
        //Producer DeleteCategtwo(int categtwoID);
        //

        IQueryable<Applying> Applyings { get; }
        IQueryable<Techcharacter> Techcharacters { get; }
    
    }
}