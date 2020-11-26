﻿using Microsoft.AspNetCore.Http;

namespace DrinkStores.Infrastructure
{
    public static class UrlExtension
    {
        public static string PathAndQuery(this HttpRequest request)
            => request.QueryString.HasValue
            ? $"{request.Path}{request.QueryString}"
            : request.Path.ToString();
    }
}
