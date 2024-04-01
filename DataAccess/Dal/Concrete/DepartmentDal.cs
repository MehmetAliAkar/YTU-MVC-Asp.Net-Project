using DataAccess.Dal.Abstract;
using DataAccess.EfDbContext.Obs;
using Entities.ObsEntities;

namespace DataAccess.Dal.Concrete
{
    public class DepartmentDal : IDepartmentDal
    {
        public Department Get(int id)
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                return context.Departments.FirstOrDefault(p => p.Id == id);
            }
        }

        public Department Add(Department entity)
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                context.Departments.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public bool Remove(Department entity)
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                context.Departments.Remove(entity);
                context.SaveChanges();
                return true;
            }
        }

        public List<Department> GetList()
        {
            using (YtuSchoolDbContext context = new YtuSchoolDbContext())
            {
                return context.Departments.ToList();
            }
        }
    }
}