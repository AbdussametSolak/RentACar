using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
            //data and message
        }
        public SuccessDataResult(T data):base(data,true)
        {
            //only data
        }
        public SuccessDataResult(string message):base(default,true,message)
        {
            //only message
        }
        public SuccessDataResult():base(default,true)
        {
            //null
        }
    }
}
