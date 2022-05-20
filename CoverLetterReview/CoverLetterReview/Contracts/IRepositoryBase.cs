using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoverLetterReview.Contracts
{
    interface IRepositoryBase <T> where T : class
    {
        ICollection<T> FindAll();    //this is basically SELECT * .  Remember, T is a class, which is analygous to a table in our project.  
                                     //so the T class that you pass in will basically create a query like "SELECT * FROM T"  

        T FindByID(int ID);
        bool isExists(int ID);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
