using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public class ParticipantRepository : IParticipantRepository
    {

        public Participant Get(int convensionId)
        {
            return new Participant
            {
                Id = 1,
                Name = "Anders And",
                Phone = "+45 12345678",
                Address = "Andevej 1, Andeby",
                Email = "anders@and.dk"
            };

        }



        public IList<Participant> Get()
        {
            var participants = new List<Participant>();

            participants.Add(new Participant
            {
                Id = 1,
                Name = "Anders And",
                Phone = "+45 12345678",
                Address = "Andevej 1, Andeby",
                Email = "anders@and.dk"
            });
            return participants;
        }

        public Participant Save(Participant participant)
        {
            return participant;
        }
    }
}


