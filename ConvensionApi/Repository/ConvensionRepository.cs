using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public class ConvensionRepository : IConvensionRepository
    {


        public Convension Get(int convensionId)
        {
            return new Convension
            {
                Id = 1,
                Name = "Test Convenstion",
                Venue = "Test Venue",
                Topic = "Test Topic"
            };

        }

        public IList<Convension> Get()
        {
            var convensions = new List<Convension>();

            convensions.Add(new Convension
            {
                Id = 1,
                Name = "Test Convenstion",
                Venue = "Test Venue",
                Topic = "Test Topic"
            });
            return convensions;
        }

        public Convension Save(Convension convension)
        {
            return convension;
        }
    }
}


