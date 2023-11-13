using System;
using System.Collections.Generic;

<<<<<<< HEAD
namespace OnlineStudentEnrollmentSystem.Entities;
=======
namespace WebApplication1.Entities;
>>>>>>> 888fb61ad308486e5a4b7694bdf6bb986f215ab4

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string Password { get; set; } = null!;
}
