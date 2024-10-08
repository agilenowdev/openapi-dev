﻿using Agile.Now.AccessHub.Client;

namespace Agile.Now.AccessHub.Test.Common {
    public static class Settings
    {
        public static readonly Configuration[] Connections = new[] {
            new Configuration {
                BasePath = "https://dev.esystems.fi",
                OAuthTokenUrl = "https://dev.esystems.fi/oAuth/rest/v2/Token",
                OAuthFlow = Client.Auth.OAuthFlow.APPLICATION,
                OAuthClientId = "c8907421-0886-4fb0-b859-d29966762e16",
                OAuthClientSecret = "1da54fa9-ae11-4db3-9740-1bb47b85cd8e"
            }
        };
    }
}
