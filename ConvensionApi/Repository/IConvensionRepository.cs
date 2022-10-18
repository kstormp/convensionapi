using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public interface IConvensionRepository
    {
        Convension GetConvension(int convensionId);

        IList<Convension> GetConvensions();

        Convension SaveConvension(Convension convension);
    }
}


