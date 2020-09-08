﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstruct_2.Models
{
     class Device
    {
        public virtual string CreateFromConnectionString(string connectionstring) 
        {
            return $"Initializong connection with \"{connectionstring}\"";
        
        }

        public abstract string RecevingMesage();
        public abstract void SendMessage(string payload);

    }
}
