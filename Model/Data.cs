using System;
using System.Collections.Generic;

namespace mysql
{
    class Data
    {
        public Data()
        {
            Task = new Task();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
        public Task Task { get; set; }
    }
}