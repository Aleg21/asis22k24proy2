﻿using Capa_Modelo_CompraVenta;

namespace Capa_Controlador_CompraVenta
{
    public class Logica
    {
        Sentencia sn;

        public Logica(string idUsuario)
        {
            sn = new Sentencia(idUsuario);
        }

        public Logica() { }
    }
}
