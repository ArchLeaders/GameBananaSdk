using Refit;

namespace GameBananaSdk.Endpoints;

public interface IFileApi
{
    [Get("/../dl/{fileId}")]
    Task<Stream> Download(long fileId);
}