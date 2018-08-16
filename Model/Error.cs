using System;

namespace mysql
{
    public class Error
    {
        public Error()
        {
            Task = new Task();
        }
        public int ErrorID { get; set; }
        public Task Task { get; set; }
        public string Descryption { get; set; } 
    }
}
