using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static async Task Main(string[] args)
    {
        string token = "8202340976:AAF5bEoNcRkwyXu6xIPNu-TGWp6fm0ws1HY";
        var bot = new TelegramBotClient(token);

        Console.WriteLine("Бот запущен!");

        bot.StartReceiving(UpdateHandler, ErrorHandler);

        await Task.Delay(-1);
    }

    private static async Task ErrorHandler(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
    {
       
    }

    private static async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
    {
        var message = update.Message;
        await client.SendMessage(message.Chat.Id, message.Text);
        if (message.Text.StartsWith("/start"))
            await StartCommand.ExecuteAsync(client, message.Chat.Id);
    }
}