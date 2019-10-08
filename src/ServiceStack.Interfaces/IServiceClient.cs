using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceStack
{
    public interface IServiceClient : IServiceClientAsync/*, IHttpRestClientAsync*/, IReplyClient, IOneWayClient, IRestClient, IHasSessionId, IHasBearerToken, IHasVersion
    {
        Task<TResponse> GetAsync<TResponse>(string relativeOrAbsoluteUrl);
        Task<TResponse> DeleteAsync<TResponse>(string relativeOrAbsoluteUrl);
        Task<TResponse> PostAsync<TResponse>(string relativeOrAbsoluteUrl, object request);
        Task<TResponse> PutAsync<TResponse>(string relativeOrAbsoluteUrl, object request);
        Task<TResponse> CustomMethodAsync<TResponse>(string httpVerb, string relativeOrAbsoluteUrl, object request);
        Task<TResponse> SendAsync<TResponse>(string httpMethod, string absoluteUrl, object request, CancellationToken token = default);
    }

    public interface IJsonServiceClient : IServiceClient {}

    public interface IReplyClient : IServiceGateway { }

    public interface IServiceClientAsync : IServiceGatewayAsync, IRestClientAsync {}
}