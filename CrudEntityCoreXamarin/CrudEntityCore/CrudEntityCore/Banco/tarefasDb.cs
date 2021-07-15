using Microsoft.EntityFrameworkCore;
using SqliteApp.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Banco
{
    public class tarefasDb
    {
        private AppDataContext _banco { get; set; }

        public tarefasDb()
        {
            _banco = new AppDataContext();

        }


        public async void Add(Product p)
        {
            _banco.Products.AddAsync(p);

            await _banco.SaveChangesAsync();
        }

        public async void AddRange(List<Product> p)
        {
            _banco.Products.AddRange(p);

            await _banco.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return  await _banco.Products.ToListAsync();
        }

    }
}
