namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using Models;
    using DtoModels.Accounts;
    using System.Linq;

    public interface IInvitationService : IService<Invitation>
    {
        IQueryable<Invitation> GetByEmail(string email);

        int Add(Invitation invitationData);

        int Remove(string email);

        string SendInvitation(AccountInvitationDataTransferModel invitationModel);
    }
}