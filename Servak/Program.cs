using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Servak
{
    public class Program
    {

        public static MessageClass ms;
        public static SessionsClass Sessions;
        
        public static void Main(string[] args)
        {
//          Обработка сообщений
            ms = new MessageClass();  
//          Хранение данных сессии (логинов, паролей, токенов).
            Sessions = new SessionsClass();
            Sessions.LoadFromFile();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
