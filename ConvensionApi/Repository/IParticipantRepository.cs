using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public interface IParticipantRepository
    {
        Participant Get(int participantId);

        IList<Participant> Get();

        Participant Save(Participant participant);
    }
}


