﻿using Smod2.API;
using Smod2.Commands;

using System.Linq;

namespace Blackout
{
    public class CommandHandler : ICommandHandler
    {
        public string[] OnCall(ICommandSender sender, string[] args)
        {
            bool valid = sender is Server;

            Player player = sender as Player;
            if (!valid && player != null)
            {
                valid = Plugin.validRanks.Contains(player.GetRankName());
            }

			if (valid)
			{
				if (args.Length > 0)
				{
					switch (args[0].ToLower())
					{
						case "toggle":
							Plugin.toggled = !Plugin.toggled;
							Plugin.activeNextRound = Plugin.toggled;

							return new[]
							{
								$"Blackout has been toggled {(Plugin.toggled ? "on" : "off")}."
							};
					}
				}
				else
				{
				    if (!Plugin.toggled)
					{
						Plugin.activeNextRound = !Plugin.activeNextRound;
						return new[]
						{
							$"Blackout has been {(Plugin.activeNextRound ? "enabled" : "disabled")} for next round."
						};
					}

				    return new[]
				    {
				        "Blackout is already toggled on."
				    };
				}
			}

			return new[]
			{
				$"You (rank {player?.GetRankName() ?? "NULL"}) do not have permissions to that command."
			};
		}

        public string GetUsage()
        {
            return "blackout";
        }

        public string GetCommandDescription()
        {
            return "Causes all the lights to flicker.";
        }
    }
}
