using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD Operasyonlarını bir metot olarak tanımlayacağız CRUD operasyonları Listeleme ekleme güncelleme silme işlemlere denir
        //Type Name(); .METHOT
        List<T> List();

        void Insert(T p);
        void Delete(T p);

        void Update(T p);

        // Bu methot sayesinde tablo içerisinde olan istediğimiz bilgiler bize getirecek mesela tablo içinde ali olanları bize getirecek.
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
