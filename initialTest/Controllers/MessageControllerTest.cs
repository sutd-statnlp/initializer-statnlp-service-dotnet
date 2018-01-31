using System;
using System.Collections.Generic;
using initialApp.Controllers;
using initialApp.Models;
using initialApp.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;
namespace initialTest.Controllers
{
    public class MessageControllerTest
    {
        private MessagesController controller;
        public MessageControllerTest()
        {
            controller = new MessagesController(new MessageService());
        }

        [Fact]
        public void TestGetMessages() {
            IActionResult actionResult = controller.GetMessages();
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;
            Assert.NotNull(result);

            List<Message> messages = result.Value as List<Message>;
            Assert.True(messages.Count > 0);
        }
    }
}
