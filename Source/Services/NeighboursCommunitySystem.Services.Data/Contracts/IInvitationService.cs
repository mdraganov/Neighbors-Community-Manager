namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using Models;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IInvitationService : IService
    {
        IQueryable<Invitation> All();

        IQueryable<Invitation> GetByEmail(string email);

        int Add(string email, string verificationToken);

        int Remove(string email);

        RestResponse SendInvitation(string email);
    }
}