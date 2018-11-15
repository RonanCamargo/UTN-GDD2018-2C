﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.DatabaseConnection;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Repository
{
    class TipoDeUbicacionRepository
    {
        public IList<TipoDeUbicacion> TodosLosTiposDeUbicacion()
        {
            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteMappedStoredProcedure(SpNames.TodosLosTiposDeUbicacion, null, new Mapper.AutoMapper<TipoDeUbicacion>());
        }
    }
}
