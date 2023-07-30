using DapperSample.Windows.UI.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample.Windows.UI.Repositories.Base
{
    //public interface IBaseRepository<T> where T : IEntity
    //{
    //    int InsertData(T item);
    //    int UpdateData(T item);
    //    int DeleteData(T item);
    //    List<T> GetAllData(T item);
    //    T GetDataById(int itemId);
    //}

    public interface ICreateRepository<T> where T : IEntity
    {
        int Create(T entity);
    }

    public interface IReadRepositoryForOne<T> where T : IEntity
    {
        T GetById(int id);
    }

    public interface IReadRepositoryForAll<T> where T : IEntity
    {
        List<T> GetAll();
    }

    public interface IUpdateRepository<T> where T : IEntity
    {
        void Update(T entity);
    }

    public interface IDeleteRepository<T> where T : IEntity
    {
        void Delete(int id);
    }
}
