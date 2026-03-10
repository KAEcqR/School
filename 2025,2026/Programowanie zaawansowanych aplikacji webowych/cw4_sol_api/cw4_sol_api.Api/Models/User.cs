using System;

namespace cw4_sol_api.Api.Models;

public class User
{
    public int Id {get; set;}
    public required string Firstname {get;set;}
    public required string Lastname {get;set;}
    public int age {get;set;}
}
