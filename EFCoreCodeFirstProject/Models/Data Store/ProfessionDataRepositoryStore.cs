using EFCoreCodeFirstProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstProject.Models.Data_Store
{
    public class ProfessionDataRepositoryStore : IProfessionDataRepository<Profession>
    {
        private EmployeeContext _context;

        public ProfessionDataRepositoryStore(EmployeeContext context)
        {
            _context = context;
        }

        public IEnumerable<Profession> GetAll()
        {
            return _context.Professions.ToList();
        }

        public IEnumerable<Profession> GetProfessions()
        {
            return _context.Professions.ToList();
        }

        public Profession GetById(long id)
        {
            return _context.Professions.FirstOrDefault(a => a.ProfessionId == id);
        }

        public void Update(Profession profession, Profession entity)
        {
            profession.Speciality = entity.Speciality;
            profession.Title = entity.Title;

            _context.SaveChanges();
        }

        public void Add(Profession entity)
        {
            _context.Professions.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Profession entity)
        {
            _context.Professions.Remove(entity);
            _context.SaveChanges();
        }
    }
}
