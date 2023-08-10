namespace SolutionPortalBeta.Server.Repository
{
    public interface IFaqRepository<T>
    {
        public Task<T> CreateAsync(T _object);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int Id);
        public Task DeleteAsync(int Id);
        public Task UpdateAsync(T _object);


    }
}
