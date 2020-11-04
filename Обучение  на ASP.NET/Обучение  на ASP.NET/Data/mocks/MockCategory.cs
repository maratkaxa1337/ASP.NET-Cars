using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Обучение__на_ASP.NET.Data.interfaces;
using Обучение__на_ASP.NET.Data.Models;

namespace Обучение__на_ASP.NET.Data.mocks
{
    public class MockCategory : ICarsCategorys
    {
        public IEnumerable<Category> Allcategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания"},

                };
            }


        }

    }
}
