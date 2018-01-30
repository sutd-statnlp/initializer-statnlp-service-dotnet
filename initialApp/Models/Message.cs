using System;
namespace initialApp.Models
{
    public class Message
    {
        public Message(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public string Title { get; set; }
        public String Content { get; set; }
    }
}
