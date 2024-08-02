using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;

namespace JadooProject.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Burası interfacelerin implemente edildiği yer  iniestamız 
        //implemente işlemi yapmak için constructor geçmeliyiz dbcontext(JadooContext) den constructor geçelim

        private readonly JadooContext _context;

        public Repository(JadooContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);  //Add metotu ile birlikte entity ekledik
            _context.SaveChanges(); //Değişiklikleri kaydettik
        }

        public void Delete(int id)
        {
            var value = GetByID(id); //id ye göre değer bulduk
            _context.Remove(value);   //id den gelen değeri sildik
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
