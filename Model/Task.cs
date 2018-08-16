using System;

namespace mysql
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string IpPLC { get; set; }
        public string TagName { get; set; }
        public int TaskInterval { get; set; }
    }

}
