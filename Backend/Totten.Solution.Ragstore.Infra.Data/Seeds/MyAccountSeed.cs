﻿namespace Totten.Solution.Ragstore.Infra.Data.Seeds;

using Totten.Solution.Ragstore.Domain.Features.Accounts;

public class MyAccountSeed
{
    public static List<Account> Seed()
        => new()
        {
            new ()
            {
                Id = 1,
                Name = "account",
                IsReported = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        };
}
