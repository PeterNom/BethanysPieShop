﻿
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbcontext;

        public PieRepository(BethanysPieShopDbContext bethanysPieShopDbcontext)
        {
            _bethanysPieShopDbcontext = bethanysPieShopDbcontext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bethanysPieShopDbcontext.Pies.Include(c=>c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bethanysPieShopDbcontext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
