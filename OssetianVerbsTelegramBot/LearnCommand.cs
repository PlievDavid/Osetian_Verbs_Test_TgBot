using OssetianVerbsTelegramBot;
using Telegram.Bot;
using Telegram.Bot.Types;

public static class LearnCommand
{
    public static async Task ExecuteAsync(ITelegramBotClient client, Update update)
    {
        VerbsRepository verbsRepository = new VerbsRepository("verbs.json");
        var verbs = verbsRepository.GetAll();
        await client.SendMessage(update.Message.Chat.Id, string.Join(" ", verbs.Select(verb => verb.Past)));
    }
}