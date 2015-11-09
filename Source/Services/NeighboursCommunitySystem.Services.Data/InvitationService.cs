namespace NeighboursCommunitySystem.Services.Data
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;
    using NeighboursCommunitySystem.Data.Repositories;
    using RestSharp;
    using RestSharp.Authenticators;
    using Server.Common.Generators;
    using Server.Common.Constants;

    public class InvitationService : IInvitationService
    {
        private readonly IRepository<Invitation> invitations;

        public InvitationService(IRepository<Invitation> invitations)
        {
            this.invitations = invitations;
        }

        public IQueryable<Invitation> All()
        {
            return this.invitations.All().AsQueryable();
        }

        public IQueryable<Invitation> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public int Add(string email, string verificationToken)
        {
            var invitation = new Invitation()
            {
                Email = email,
                VerificationToken = verificationToken
            };

            this.invitations.Add(invitation);
            this.invitations.SaveChanges();

            return invitation.ID;
        }

        public int Remove(string email)
        {
            throw new NotImplementedException();
        }

        public RestResponse SendInvitation(string email)
        {
            var verificationToken = this.GenerateVerificationToken();
            var registrationURI = "https://facebook.com/";
            var message = String.Format(
                "You can register for the Neighbours Community Management System on the following link --> {1} {0}Use this verification token in order to authorize your credentials --> {2}", 
                Environment.NewLine, 
                registrationURI, 
                verificationToken);

            RestClient client = new RestClient();
            client.BaseUrl = new System.Uri("https://api.mailgun.net/v3");
            client.Authenticator = new HttpBasicAuthenticator("api", "key-1c6386f513a843fd177faf43651e104d");

            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandboxaa5c7c0d21a84aa1b0b2dd81fa9b283c.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Neighbours Community Management System <postmaster@sandboxaa5c7c0d21a84aa1b0b2dd81fa9b283c.mailgun.org>");
            request.AddParameter("to", String.Format("<{0}>", email));
            request.AddParameter("subject", "Hello, Neighbour!");
            request.AddParameter("text", message);
            request.Method = Method.POST;

            return (RestResponse)client.Execute(request);
        }

        private string GenerateVerificationToken()
        {
            var generator = new RandomStringGenerator();

            var result = generator.GetString(
                Constants.VerificationTokenMinLength,
                Constants.VerificationTokenMaxLength);

            return result;
        }
    }
}
