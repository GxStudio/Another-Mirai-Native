﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Mirai_Native.Adapter.MiraiEventArgs
{
    public class BotJoinGroupEvent
    {
        public string type { get; set; }
        public Group group { get; set; }
        public object invitor { get; set; }
        public class Group
        {
            public int id { get; set; }
            public string name { get; set; }
            public string permission { get; set; }
        }
    }
}