﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merovingie.Models
{

    public class MMessageModel
    {
        public string Message { get; set; }
        public string Type { get; set; }

        public MMessageModel(string type, string message)
        {
            Type = type;
            Message = message;
        }

        public string toString()
        {
            return Message;
        }
    }
}