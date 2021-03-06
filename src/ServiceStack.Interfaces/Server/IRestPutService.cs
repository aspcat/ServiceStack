using System;

namespace ServiceStack.Server
{
	/// <summary>
	/// If the Service also implements this interface,
	/// IRestPutService.Put() will be used instead of IService.Execute() for 
	/// EndpointAttributes.HttpPut requests
	/// </summary>
	/// <typeparam name="T"></typeparam>
    [Obsolete("Use IService - ServiceStack's New API for future services")]
    public interface IRestPutService<T>
	{
		object Put(T request);
	}
}