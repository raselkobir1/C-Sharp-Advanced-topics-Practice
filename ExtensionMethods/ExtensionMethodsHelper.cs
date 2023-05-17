using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.ExtensionMethods
{
    public static class ExtensionMethodsHelper
    {
        public static string GetPersonsInfo(this Person person)
        {
            return "Id : " + person.Id + " Name : " + person.Name + " Details : " + person.Details;
        }
    }
}
