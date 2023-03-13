
namespace Beamable.Api.Autogenerated.Realms
{
	using Beamable.Api.Autogenerated.Models;
	using Beamable.Common;
	using Beamable.Common.Content;
	using IBeamableRequester = Beamable.Common.Api.IBeamableRequester;
	using Method = Beamable.Common.Api.Method;

	public partial interface IRealmsApi
	{
	}
	public partial class RealmsApi : IRealmsApi
	{
		private IBeamableRequester _requester;
		public RealmsApi(IBeamableRequester requester)
		{
			this._requester = requester;
		}
	}
}