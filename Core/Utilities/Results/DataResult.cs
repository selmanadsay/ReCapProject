using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> //sen bir resultsun aynı zamanda sen bir Idataresult imp.
    {
        public DataResult(T data,bool success,string message): base(success,message) ////​ base(x,y) komutu baba classtaki ctor u (x,y) olan methodu çalıstırır. Kod hammalıgından kurtulurz
        {
            Data =   data;
        }

        public DataResult(T data, bool success): base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
