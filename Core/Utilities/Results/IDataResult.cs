using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //<T> Generics
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
