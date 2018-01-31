using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using initialApp.Models;
using initialApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace initialApp.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        private readonly MessageService _messageService;

        public MessagesController(MessageService messageService){
            _messageService = messageService;
        }
        // GET: api/messages
        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok(_messageService.GetMessages());
        }

    }
}
