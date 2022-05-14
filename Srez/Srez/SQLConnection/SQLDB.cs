using SQLite;
using Srez.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Srez.SQLConnection
{
    public class SQLDB
    {
        public readonly SQLiteConnection db;
        
        public SQLDB(string path)
        {
            db = new SQLiteConnection(path);
            db.CreateTable<Role>();
            db.CreateTable<User>();
            db.CreateTable<Woman>();
        }

        public IEnumerable<Role> GetRoles()
        {
            return db.Table<Role>().ToList();
        }

        public Role GetRole(int id)
        {
            return db.Get<Role>(id);
        }

        public int DeleteRole(int id)
        {
            return db.Delete<Role>(id);
        }

        public int SaveRole(Role role)
        {
            if (role.Id != 0)
            {
                db.Update(role);
                return role.Id;
            }
            else
            {
                return db.Insert(role);
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return db.Table<User>().ToList();
        }

        public User GetUser(int id)
        {
            return db.Get<User>(id);
        }

        public int DeleteUser(int id)
        {
            return db.Delete<User>(id);
        }

        public int SaveUser(User user)
        {
            if (user.Id != 0)
            {
                db.Update(user);
                return user.Id;
            }
            else
            {
                return db.Insert(user);
            }
        }

        public IEnumerable<Woman> GetWomen()
        {
            return db.Table<Woman>().ToList();
        }

        public Woman GetWoman(int id)
        {
            return db.Get<Woman>(id);
        }

        public int DeleteWoman(int id)
        {
            return db.Delete<Woman>(id);
        }

        public int SaveWoman(Woman woman)
        {
            if (woman.Id != 0)
            {
                db.Update(woman);
                return woman.Id;
            }
            else
            {
                return db.Insert(woman);
            }
        }
    }
}
