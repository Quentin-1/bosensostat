using System;
namespace SensoStatWeb.Business.Interfaces
{
    public interface IHttpService
    {
        /// <summary>
        /// Send a Http request
        /// </summary>
        /// <typeparam name="T">The class to deserialize the result</typeparam>
        /// <param name="url">Url to send the http request</param>
        /// <param name="httpMethod">The Http verb (HttpMethod.Get or HttpMethod.Post)</param>
        /// <param name="bearer">The bearer token for OAuth2.0</param>
        /// <returns>The deserialized result</returns>
        Task<T> SendHttpRequest<T>(string url, HttpMethod httpMethod, object? body = null, string? bearer = null);
    }
}

