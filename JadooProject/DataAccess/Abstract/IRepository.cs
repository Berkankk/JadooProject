namespace JadooProject.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        //interface mutlaka implemente edilmeli xavi iniesta gibi
        //Crud işlemlerini geçtik burada
        List<T> GetList();  //liste türünde veri döndüreceksin
        T GetByID(int id); //id ye göre veri getireceksin
        void Delete(int id);//id ye göre silme işlemini yapacaksın
        void Update(T entity); //entityden gelen veri ile güncelleme yapacaksın 
        void Create(T entity); //entityden gelen veri ile oluşturma işlemi yapacaksın
    }
}
