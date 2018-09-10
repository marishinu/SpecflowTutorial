using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Json.NET;

namespace SpecflowTutorial.cs
{
    class CommonVariables
    {
        public static RestClient serverconnect;
        public static RestRequest apiUri;
        public static IRestResponse response;
    }
}
