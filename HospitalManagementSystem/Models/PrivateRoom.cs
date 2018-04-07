﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    class PrivateRoom : Room
    {
        const int privateCapacity = 1;
        const double privatePrice = 100;
        public PrivateRoom() : base(privateCapacity, privatePrice)
        {
        }
    }

}
