using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using SQLite.Net;
using Xamarin.Forms;

namespace BusinessApp.Repositories
{
   public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly SQLiteConnection conn;
        public UserRepository() : base()
       {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<User>();
        }

       public User GetUserByEmail(string email)
       {
           throw new NotImplementedException();
       }

       public User GetUserByPhoneNumber(long phoneNumber)
       {
           throw new NotImplementedException();
       }
    }
}
