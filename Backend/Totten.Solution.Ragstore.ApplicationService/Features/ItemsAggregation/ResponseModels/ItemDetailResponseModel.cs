﻿namespace Totten.Solution.Ragstore.ApplicationService.Features.ItemsAggregation.ResponseModels;
public class ItemDetailResponseModel
{
    public int ItemId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
