using DataAccess.Dal.Abstract;
using DataAccess.EfDbContext.Obs;
using Entities.ObsEntities;

namespace DataAccess.Dal.Concrete
{
    public class FacultyDal:IFacultyDal
    {
        public Faculty Get(int id)
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                return context.Faculties.FirstOrDefault(p => p.Id == id);
            }
        }

        public Faculty Add(Faculty entity)
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                context.Faculties.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public bool Remove(Faculty entity)
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                context.Faculties.Remove(entity);
                context.SaveChanges();
                return true;
            }
        }

        public List<Faculty> GetList()
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                return context.Faculties.ToList();
            }
        }
    }
}
