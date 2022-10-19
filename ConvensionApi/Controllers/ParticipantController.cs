using ConvensionApi.Model;
using ConvensionApi.Repository;
using Microsoft.AspNetCore.Authentication;
using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ConvensionApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ParticipantController : ControllerBase
{


    private readonly ILogger<ParticipantController> _logger;

    private readonly IParticipantRepository _participantnRepository;


    public ParticipantController(ILogger<ParticipantController> logger, IParticipantRepository participantnRepository, IAuthorizationService authz)
    {
        _logger = logger;
        _participantnRepository = participantnRepository;
    }

    [HttpGet]
    [Authorize(Policy = "ReadAccess")]
    public IList<Participant> GetParticipants()
    {
        return _participantnRepository.Get();
    }


    [HttpGet("{id}")]
    [Authorize(Policy = "ReadAccess")]
    public Participant GetConvension(int id)
    {
        return _participantnRepository.Get(id);
    }

    [HttpPost]
    [Authorize(Policy = "WriteAccess")]
    public Participant SaveConvension(Participant convension)
    {
        return _participantnRepository.Save(convension);
    }

}

