﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ChatTailorAI.Shared.Dto;
using ChatTailorAI.Shared.Models.Assistants.OpenAI;

namespace ChatTailorAI.Shared.Services.Assistants.OpenAI
{
    public interface IOpenAIAssistantManagerService
    {
        Task<string> CreateAssistant(AssistantDto assistant);
        Task DeleteAssistant(string id);
        Task<AssistantDto> GetAssistant(string id);
        Task<List<AssistantDto>> GetAssistants();
        Task UpdateAssistant(AssistantDto assistant);
        Task<List<OpenAIThreadMessage>> SendMessage(string assistantId, string threadId, string message);
        Task<OpenAIThread> CreateThreadAsync();
    }
}