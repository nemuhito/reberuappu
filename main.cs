import {
  createBot,
  startBot,
  Intents,
  GatewayIntents,
  eventHandlers,
} from "https://deno.land/x/discordeno@18.0.1/mod.ts";

const bot = createBot({
  token: Deno.env.get("DISCORD_BOT_TOKEN")!,
  botId: BigInt(Deno.env.get("DISCORD_BOT_ID")!),
  intents: GatewayIntents.Guilds | GatewayIntents.GuildMessages | GatewayIntents.MessageContent,
  events: {},
});

await startBot(bot);
