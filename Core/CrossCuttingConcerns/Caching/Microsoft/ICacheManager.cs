﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public interface ICacheManager
    {
        T Get<T>(string key); //object Get(string key); gibi de yazılabilir fakat ()dönüşüm yapılması şart olur!
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);

    }
}
