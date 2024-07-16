namespace GenericRepostoryPatternCore.Contract
{
    public interface IGeneric<T> where T:class
    {
        List<T> GetAll();
        bool Add(T obj);
        T GetByID(int id);
        bool Update(T obj);
        T Delete(int id);
    }
}
