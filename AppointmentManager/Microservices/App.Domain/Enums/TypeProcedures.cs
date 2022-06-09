﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Enums
{
    public enum TypeProcedures
    {
        BAÑO_MEDICADO = 1,
        BAÑO_Y_CORTE = 2, 
        CORTE_DE_UÑAS = 3
    }

    public enum AppoinmentStatus
    {
        PENDING = 1,
        RUNNING = 2,
        DONE = 3
    }
}
