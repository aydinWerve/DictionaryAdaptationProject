using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        Repository<Category> repository = new Repository<Category>();

        public List<Category> GetAll()
        {
            return repository.GetAll();
        }

        public void Add(Category category)
        {
            //if(category.CategoryName == "" || category.CategoryName.Length<=3)
            //{
            //    Console.WriteLine("Eklenemez");
            //}

            repository.Add(category);
        }

        public void Delete(Category category)
        {
            repository.Delete(category);
        }

        public void Update(Category category)
        {
            repository.Update(category);
        }
    }
}
