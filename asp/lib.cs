using System;
using System.Collections.Generic;

namespace MessageLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ваш код инициализации приложения
        }
    }
    public class MessageData
    {
        public string Sender { get; set; }
        public string Message { get; set; }
    }

    public static class MessageService
    {
        public static void SendMessage(MessageData message)
        {
            // Реализация отправки сообщения через WebAPI
        }

        public static List<MessageData> GetMessagesForUser(string userName)
        {
            // Реализация получения сообщений по имени пользователя через WebAPI
            return new List<MessageData>();
        }
    }
}
