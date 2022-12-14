using System;
using System.Collections.Generic;
using System.Linq;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.ReplyMarkups;
using System.Data.SQLite;





namespace TgBot
{
    
     class Program
    {

        private static string token { get; set; } = "5804037466:AAGBqPABPHMYtGv_p4p6M40sEGHhKS703d4";
        private static TelegramBotClient client;
        public static SQLiteConnection DB;
        static void Main(string[] args)
        {
           client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHendler;
            Console.ReadLine(); 
            client.StopReceiving();
            

        }
        
        private static async void OnMessageHendler(object sender, MessageEventArgs e)
        {
          
            
         var msg = e.Message;

           
            if (msg.Text != null) {


                if (msg.Text.ToLower() == "/start")
                {
                    Registration(msg.Chat.Id.ToString(), msg.Chat.Username.ToString(), msg.Chat.FirstName.ToString());
                    await client.SendTextMessageAsync(msg.Chat.Id,$"Добрий день {msg.Chat.FirstName} оберіть свою спеціальність:"  ,   replyMarkup: GetButtons()) ;

                }
               
                switch (msg.Text) {

                    case "Назад":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть свою спеціальність", replyMarkup: GetButtons());
                        break;

                    case "071 Облік і оподаткування":
                        ReplyKeyboardMarkup keyboard = new(new[] {

                new KeyboardButton[]{"Б-11"},
                new KeyboardButton[]{"Б-21"},
                new KeyboardButton[]{"Б-31"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard);
                        break;
                    case "072 Фінанси, банківська справа та страхування":
                        ReplyKeyboardMarkup keyboard1 = new(new[] {

                new KeyboardButton[]{"Ф-11"},
                new KeyboardButton[]{"Ф-21"},
                new KeyboardButton[]{"Ф-31"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard1);
                        break;
                    case "073 Менеджмент":
                        ReplyKeyboardMarkup keyboard2 = new(new[] {

                new KeyboardButton[]{"Е-11"},
                new KeyboardButton[]{"Е-21"},
                new KeyboardButton[]{"Е-31"},
                new KeyboardButton[]{"Е-41"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard2);
                        break;
                    case "075 Маркетинг":
                        ReplyKeyboardMarkup keyboard3 = new(new[] {

                new KeyboardButton[]{"МК-11"},
                new KeyboardButton[]{"МК-21"},
                new KeyboardButton[]{"МК-31"},
                new KeyboardButton[]{"МК-41"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard3);
                        break;
                    case "121 Інженерія програмного забезпечення":
                        ReplyKeyboardMarkup keyboard4 = new(new[] {

                new KeyboardButton[]{"П-11","П-12","П-13"},
                new KeyboardButton[]{"П-21","П-22","П-23"},
                new KeyboardButton[]{"П-31","П-32"},
                new KeyboardButton[]{"П-41","П-42"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard4);
                        break;
                    case "133 Галузеве машинобудування":
                        ReplyKeyboardMarkup keyboard5 = new(new[] {

                new KeyboardButton[]{"М-11"},
                new KeyboardButton[]{"М-21"},
                new KeyboardButton[]{"М-31"},
                new KeyboardButton[]{"М-41"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard5);
                        break;
                    case "151 Автоматизація та комп'ютерно - інтегровані технології":
                        ReplyKeyboardMarkup keyboard6 = new(new[] {

                new KeyboardButton[]{"A11","A12"},
                new KeyboardButton[]{"A-21","A-22"},
                new KeyboardButton[]{"A-31","A-32"},
                new KeyboardButton[]{"A-41"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard6);
                        break;
                    case "182 Технології легкої промисловості":
                        ReplyKeyboardMarkup keyboard7 = new(new[] {

                new KeyboardButton[]{"МД-11"},
                new KeyboardButton[]{"МД-21"},
                new KeyboardButton[]{"МД-31"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard7);
                        break;
                    case "205 Лісове господарство":
                        ReplyKeyboardMarkup keyboard8 = new(new[] {

                new KeyboardButton[]{"Т-21"},
                new KeyboardButton[]{"Т-31"},
                new KeyboardButton[]{"Т-41"},
                new KeyboardButton[]{"Назад"}
                })
                        { ResizeKeyboard = true };

                        await client.SendTextMessageAsync(msg.Chat.Id, "Оберіть групу:", replyMarkup: keyboard8);
                        break;

                }
               
            }
        }

        private static IReplyMarkup GetButtons()
        {
            return new ReplyKeyboardMarkup
            {

                Keyboard = new List<List<KeyboardButton>> {

               new List<KeyboardButton>{ new KeyboardButton {Text = "071 Облік і оподаткування" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "072 Фінанси, банківська справа та страхування" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "073 Менеджмент" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "075 Маркетинг" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "121 Інженерія програмного забезпечення" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "133 Галузеве машинобудування" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "151 Автоматизація та комп'ютерно - інтегровані технології" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "182 Технології легкої промисловості" } },
               new List<KeyboardButton>{ new KeyboardButton {Text = "205 Лісове господарство" } },

           }
            };
        }
        public static void Registration(string id, string username, string firstname) 
        {
            try
            {
                DB = new SQLiteConnection("Data Source = Data.Base.db");
                DB.Open();
                SQLiteCommand regcmd = DB.CreateCommand();
                regcmd.CommandText = "INSERT INTO TgUsers VALUES(@id,@username,@firstname)";
                regcmd.Parameters.AddWithValue("@id",id);
                regcmd.Parameters.AddWithValue("@username", username);
                regcmd.Parameters.AddWithValue("@firstname",firstname);
                regcmd.ExecuteNonQuery();
                DB.Close();
            }
            catch(Exception ex) 
            { 
            Console.WriteLine("Error" + ex);
            }
        }
    }

      
    
}
