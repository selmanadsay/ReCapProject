// See https://aka.ms/new-console-template for more information







using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

//foreach (var item in carManager.GetCarDetails())
//{
//    Console.WriteLine(item.CarName+" "+item.ColorName+" "+item.BrandName+" "+item.DailyPrice);
//}
