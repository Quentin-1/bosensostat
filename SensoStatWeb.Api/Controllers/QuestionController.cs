using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensoStatWeb.Models.Entities;
using SensoStatWeb.Repository.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensoStatWeb.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class QuestionController : Controller
{
    private readonly IQuestionRepository _questionRepository;
    public QuestionController(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Questions()
    {
        var result = _questionRepository.GetAllQuestions();

        if (result == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(result);
        }
    }

    [HttpPost]
    [Authorize]
    public IActionResult Question([FromBody]Question question)
    {
        var result = _questionRepository.CreateQuestion(question);

        if (result == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(question);
        }
    }

    [HttpDelete]
    [Authorize]
    public IActionResult Question([FromBody]int id)
    {
        var result = _questionRepository.DeleteQuestion(id);

        if (result == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(result.Result);
        }
    }
}

