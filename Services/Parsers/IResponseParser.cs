﻿
using DSharpPlus;
using LLM.GitHelper.Data.Discord;
using LLM.GitHelper.Services.Discord;

namespace LLM.GitHelper.Services.Parsers
{
    public interface IResponseParser<TResponse>
    {
        /// <summary>
        /// Parses prefixes contained in response and returns contained prefixes
        /// </summary>
        /// <param name="response">Response to parse</param>
        /// <param name="prefixes">All prefixes to parse</param>
        /// <returns>Prefixes found in this response</returns>
        public string[] ParsePrefixes(TResponse response, string[] prefixes);

        public Task<string> ParseLinks(DiscordClient client, string description, UserLinkEstablisherService establisher);

        public List<GitToDiscordLinkData> GetParsedLinks(DiscordClient client, string[] textToSeekUser, UserLinkEstablisherService establisher);
    }
}
