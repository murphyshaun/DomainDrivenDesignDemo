﻿using Domain.User;

namespace Application.Services.Authentication.Common
{
    public record AuthenticationResult(
        User user,
        string token);
}