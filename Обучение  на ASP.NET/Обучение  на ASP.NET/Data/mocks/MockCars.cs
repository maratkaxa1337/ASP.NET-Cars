using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Обучение__на_ASP.NET.Data.interfaces;
using Обучение__на_ASP.NET.Data.Models;

namespace Обучение__на_ASP.NET.Data.mocks
{
    public class MockCars : IAllCars
    {
        public IEnumerable<Car> Cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getobjectcar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
