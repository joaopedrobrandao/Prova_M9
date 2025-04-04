using prova.Repositories;
using prova.Models;


namespace prova.Services
{
    public interface IUserService
    {
        Task<List<User>> CreateUsers(int count);
        Task<List<User>> GetAllUsers();
        Task<User?> GetUserById(int id);
    }
}