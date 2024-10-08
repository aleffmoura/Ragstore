﻿namespace Totten.Solution.Ragstore.ApplicationService.ViewModels.Stores;

using Totten.Solution.Ragstore.Domain.Features.Accounts;

using Totten.Solution.Ragstore.Domain.Features.Characters;

/// <summary>
/// 
/// </summary>
public record StoreResumeViewModel
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int CharacterId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CharacterName { get; set; } = string.Empty;
    public string Map { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime? ExpireDate { get; set; }
}
