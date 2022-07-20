using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        //GetAll, GetById, Insert, Update, Delete.

        List<Color> GetAll();
        Color GetById(int colorId);

        void Insert(Color color);

        void Update(Color color);

        void Delete(Color color);
    }
}
