﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Contracts.Repositories;
using BusinessApp.Contracts.Services;
using BusinessApp.Models;
using SQLite;
using SQLite.Net;
using Xamarin.Forms;

namespace BusinessApp.Repositories
{
   public class BaseRepository<T> : IRepository<T> where T : Model
    {
        private readonly SQLiteConnection conn;

        public string StatusMessage { get; set; }
        
        public BaseRepository()
        {

          


             conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<T>();
            //  conn.CreateTableAsync<T>().Wait();
            // conn.
        }
        public T Get(long id)
        {
            return conn.Get<T>(Convert.ToInt64(id));
        }

        public IList<T> GetAllRecords(string query)
        {
            return conn.Query<T>(query).ToList();
        }
       

        public long Save(T entity)
        {
            return Convert.ToInt64(conn.Insert(entity));
        }

        public void SaveOrUpdate(T item)
        {
            conn.Update(item);
        }

        public void Delete(long id)
        {
            conn.Delete<T>(id);
        }
        //public void SaveOrUpdate(T item)
        //{
        //    Session.SaveOrUpdate(item);
        //}

        //public void Delete(T item)
        //{
        //    Session.Delete(item);
        //}





    }
}
