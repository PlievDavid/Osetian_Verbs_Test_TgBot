using Telegram.Bot;
using Telegram.Bot.Types;

static class StartCommand
{
    internal static async Task ExecuteAsync(ITelegramBotClient client, Update update)
    {
        if (update != null)
        {
            await client.SendMessage(update.Message.Chat.Id, "ммм", replyMarkup: new string[][]
            {
                    new string[]{"привет", "gdf"},
                    new string[]{"ммм" } 
            });
        }
    }
}