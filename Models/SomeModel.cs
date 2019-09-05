using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autofacInjection.Models
{
    public interface ISomeModel
    {
        string GetSomeString();
    }
    public class SomeModel:ISomeModel
    {
        public string GetSomeString()
        {
            return "This is Some String ";
        }
    }
}
