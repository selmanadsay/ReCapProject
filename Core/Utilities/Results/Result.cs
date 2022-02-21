using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) //burası çalıştığında alttaki successta çalışması için this(success)  bunu yazıyoruz yani resultun success parametreli konstaktırı çalışsın demek oluyor..(iki parametre gönderen biri için burası çalışcak)
        {
            Message = message;

        }
        public Result(bool success)
        {

            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
