using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public interface IConvensionRepository
    {
        Convension Get(int convensionId);

        IList<Convension> Get();

        Convension Save(Convension convension);
    }
}


