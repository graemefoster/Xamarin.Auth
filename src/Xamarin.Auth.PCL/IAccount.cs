using System.Collections.Generic;
using System.Net;

namespace Xamarin.Auth.PCL
{
    public interface IAccount
    {
        string Username { get; }
        Dictionary<string, string> Properties { get; }
        CookieContainer Cookies { get; }
    }
}