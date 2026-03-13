namespace Studentska.Servis.Servisi
{
    public abstract class BaseServis<T> : IDisposable where T : class 
    {
        protected StudentskaDbContext _dbContext = new StudentskaDbContext();
        public virtual List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }       
        public void Add(T obj)
        {
            _dbContext.Set<T>().Add(obj);
            _dbContext.SaveChanges();
        }
        public T? GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        //added
        public void Update(T obj)
        {
            _dbContext.Set<T>().Update(obj);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var obj = _dbContext.Set<T>().Find(id);

            if(obj != null)
            {
                _dbContext.Set<T>().Remove(obj);
                _dbContext.SaveChanges();
            }
        }
        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
