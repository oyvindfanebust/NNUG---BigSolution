namespace ThatLegacyOrm
{
    public class Repository
    {
        public T Get<T>(int id) where T : new()
        {
            return new T();
        }
    }
}
