using System;
using System.Collections.Generic;
using initialApp.Models;

namespace initialApp.Services
{
    public class MessageService
    {
        public MessageService()
        {
        }
        public List<Message> GetMessages() {
            List<Message> list = new List<Message>();
            for (int i = 0; i < 8; i++)
            {
                list.Add(new Message("title" + i, "content" + i));
            }
            return list;
        }
    }
}
