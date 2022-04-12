// Simple utility to get oAuth token to interact with Azure APIs
using Azure.Core;
using Azure.Identity;

Console.WriteLine("Welcome to AzToken Generator!");

var credentials = new DefaultAzureCredential();
var token = await credentials.GetTokenAsync(new TokenRequestContext(new string[] { $"https://management.azure.com" }));
Console.WriteLine($"The Token is '{token.Token}'");