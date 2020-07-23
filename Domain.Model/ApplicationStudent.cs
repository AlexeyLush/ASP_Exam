using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class ApplicationStudent
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public int Score { get; set; }
        public Profile ProfileFirst { get; set; }
        public Profile ProfileSecond { get; set; }
        public College College { get; set; }
    }
}
