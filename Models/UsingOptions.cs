using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace UsingOptions.Models
{
    public class MyOptions
    {
        public MyOptions()
        {
            // Set default value.
            ApiKey = "apiavain";
        }
        public string ApiKey { get; set; }
    }
}