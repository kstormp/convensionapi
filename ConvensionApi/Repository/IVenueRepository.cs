using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;
using Model.ConvensionApi;

namespace ConvensionApi.Repository
{
    public interface IVenueRepository
    {
        Venue GetConvension(int venueId);

        IList<Venue> GetVenues();

        Venue SaveConvension(Venue venue);
    }
}


