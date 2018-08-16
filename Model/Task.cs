using System;

namespace mysql
{
    class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string IpPLC { get; set; }
        public string TagName { get; set; }
        public int Interv { get; set; }
    }

    public enum Type
    {
        Time,
        Interval,
    }
}
