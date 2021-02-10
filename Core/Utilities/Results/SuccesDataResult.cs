using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccesDataResul<T>:DataResult<T>
    {
        public SuccesDataResul(T data ,string message):base(data,true,message)
        {

        }
        public SuccesDataResul(T data):base(data,true)
        {

        }
        public SuccesDataResul(string message):base(default,true,message)
        {

        }
        public SuccesDataResul():base(default,true)
        {

        }

    }
}
