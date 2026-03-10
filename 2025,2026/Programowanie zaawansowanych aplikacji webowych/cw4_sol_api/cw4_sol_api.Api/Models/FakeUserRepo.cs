using System;

namespace cw4_sol_api.Api.Models;

public class FakeUserRepo : IUserRepo
{
    public void AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User? GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
