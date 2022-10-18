using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public interface IParticipantRepository
    {
        Participant GetParticipant(int participantId);

        IList<Participant> GetParticipants();

        Participant SaveParticipant(Participant participant);
    }
}


