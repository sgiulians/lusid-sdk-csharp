﻿using System;
using Lusid.Sdk.Client;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Class derived from the auto-generated Configuration which allows the access token to be pulled from an ITokenProvider
    /// </summary>
    public class TokenProviderConfiguration : Configuration
    {
        private readonly ITokenProvider _tokenProvider;

        public TokenProviderConfiguration(ITokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        public override string AccessToken
        {
            get => _tokenProvider.GetAuthenticationTokenAsync().Result;
            set => throw new InvalidOperationException("AccessToken is not assignable");
        }
    }
}
