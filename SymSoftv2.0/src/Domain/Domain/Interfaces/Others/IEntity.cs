﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Others
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
