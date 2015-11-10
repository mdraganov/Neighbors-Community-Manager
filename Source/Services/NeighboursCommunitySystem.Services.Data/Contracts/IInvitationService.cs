namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using Models;
    using RestSharp;
    using System.Linq;
    using System.Net;

    public interface IInvitationService : IService
    {
        IQueryable<Invitation> All();

        IQueryable<Invitation> GetByEmail(string email);

        int Add(Invitation invitationData);

        int Remove(string email);

        string SendInvitation(string email);
    }
}