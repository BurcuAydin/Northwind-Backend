using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        //detayına gitmek için
        IDataResult<Category> GetById(int categoryId);

    }
}
