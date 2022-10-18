using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public interface ITalkerRepository
    {
        Talker GetTalker(int talkerId);

        IList<Talker> GetTalker();

        Talker SaveConvension(Talker talker);
    }
}


