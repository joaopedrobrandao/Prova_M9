namespace prova.Repositories
{
    using prova.Models;

    public interface IUserRepository
    {
        Task<List<User>> CreateUsers(int count);
        Task<List<User>> GetAllUsers();
        Task<User?> GetUserById(int id);

    }
}