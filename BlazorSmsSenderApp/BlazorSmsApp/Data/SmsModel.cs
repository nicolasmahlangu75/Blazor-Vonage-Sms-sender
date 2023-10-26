using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorSmsApp.Data
{
    public class SmsModel
    {
        public string RecipientNumber { get; set; }
        public string TextMessage { get; set; }
    }
}
