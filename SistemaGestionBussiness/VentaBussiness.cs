﻿using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVentas();
        }
    }
}
