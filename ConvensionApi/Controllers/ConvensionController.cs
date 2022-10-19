using ConvensionApi.Model;
using ConvensionApi.Repository;
using Microsoft.AspNetCore.Authentication;
using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ConvensionApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ConvensionController : ControllerBase
{


    private readonly ILogger<ConvensionController> _logger;

    private readonly IConvensionRepository _convensionRepository;


    public ConvensionController(ILogger<ConvensionController> logger, IConvensionRepository convensionRepository, IAuthorizationService authz)
    {
        _logger = logger;
        _convensionRepository = convensionRepository;
    }

    [HttpGet]
    [Authorize(Policy = "ReadAccess")]
    public IList<Convension> GetConvensions()
    {
        return  _convensionRepository.Get();
    }


    [HttpGet("{id}")]
    [Authorize(Policy = "ReadAccess")]
    public Convension GetConvension(int id)
    {
        return _convensionRepository.Get(id);
    }

    [HttpPost]
    [Authorize(Policy = "WriteAccess")]
    public Convension SaveConvension(Convension convension)
    {
        return _convensionRepository.Save(convension);
    }

}

