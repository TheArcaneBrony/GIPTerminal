using DSharpPlus;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalApp
{
    class DiscordBot
    {
        public static DiscordGuild guild;
        public static DiscordChannel channel;
        public static async void Init()
        {
            DiscordConfiguration cfg = new DiscordConfiguration
            {
                Token = "Njc2Nzg5MjEyOTA0Njg1NjQx.XkKzcA.CEndi4eY5mu_Hk8xon91QnNMB2w",
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                LogLevel = LogLevel.Debug,
                UseInternalLogHandler = false
            };
            DiscordClient client = new DiscordClient(cfg);
            await client.ConnectAsync();
            guild = await client.GetGuildAsync(676788625358454806);
            channel = guild.GetChannel(676789861348540427);
            channel.SendMessageAsync("Terminal gestart!");
        }
        public static async void SendMessage(string Text)
        {
            channel.SendMessageAsync(Text);
        }
    }
}
