namespace SolutionPortalBeta.Server.Repository
{
	public interface IRepository<T>
	{
		public Task<T> CreateAsync(T _object);
		public Task<List<T>> GetAllAsync();
		public Task<T> GetByIdAsync(int Id);
        public Task<List<T>> GetByDateAsync(DateTime date);

    }
}
