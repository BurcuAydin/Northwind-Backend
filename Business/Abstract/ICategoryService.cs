using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        //detayına gitmek için
        Category GetById(int categoryId);

    }
}
