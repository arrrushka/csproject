using System;

namespace DeansOffice.Domain.Models
{
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public class User
    {
        public long Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }

        public DateTime RegisteredDate { get; set; }
    }
}
