using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _20161013.Models;

namespace _20161013.Service
{
    public class CurriculumVitaeService : IDisposable
    {
        private readonly ApplicationDbContext _dbContext;
        public CurriculumVitaeService()
        {
            _dbContext = new ApplicationDbContext();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public CurriculumVitae GetCurriculumVitae(Guid id)
        {
            return _dbContext.CurriculumVitaes.FirstOrDefault(n => n.Id == id);
        }

        public IQueryable<CurriculumVitae> GetCurriculumVitaes()
        {
            return _dbContext.CurriculumVitaes.Where(n => !n.IsDeleted);
        }
    }
}