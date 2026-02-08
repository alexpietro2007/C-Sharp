using Discord;
using Discord.Commands;

namespace MeuBot.Modules
{
    public class Comandos : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task ComandosAsync()
        {
            await ReplyAsync("Pong!");
        }
    }
}