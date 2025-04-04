using prova.Models;
using prova.Repositories;
using System.Collections.Generic;

namespace prova.Repositories{


    public class UserRepository : IUserRepository {
        private List<User> _users = new List<User>();
        private int _nextId = 1;
        public async Task<List<User>> GetAllUsers() {
            return await Task.FromResult(_users);
        }

        public async Task<List<User>> CreateUsers(int count) {
            var random = new Random();
            var names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
            var colors = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };
            for (int i = 0; i < count; i++) {
                var user = new User {
                    Id = _nextId++,
                    Name = names[random.Next(names.Count)],
                    Age = random.Next(18, 100),
                    CorFavorita = colors[random.Next(colors.Count)],
                    CPF = $"{random.Next(100000000, 999999999)}-{random.Next(0, 10)}"
                };
                _users.Add(user);
            }
            await Task.CompletedTask;
            return _users;
        }

        public async Task<User?> GetUserById(int id) {
            var user = _users.FirstOrDefault(u => u.Id == id);
            return await Task.FromResult(user);
        }

    }
}