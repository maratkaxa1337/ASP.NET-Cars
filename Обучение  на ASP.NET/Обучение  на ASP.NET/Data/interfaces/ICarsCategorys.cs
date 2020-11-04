using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Обучение__на_ASP.NET.Data.Models;

namespace Обучение__на_ASP.NET.Data.interfaces
{
    interface ICarsCategorys
    {
        IEnumerable<Category> Allcategories { get; }
    }
}
