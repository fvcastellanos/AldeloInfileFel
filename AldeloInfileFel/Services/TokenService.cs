
using AldeloInfileFel.Client;
using AldeloInfileFel.Domain;
using AldeloInfileFel.Repositories;
using System;

namespace AldeloInfileFel.Services
{
    public class TokenService
    {
        private readonly TokenRepository tokenRepository;

        public TokenService(TokenRepository tokenRepository)
        {
            this.tokenRepository = tokenRepository;
        }

        public string GetToken()
        {
            try
            {
                IdQueryApiToken storedToken = tokenRepository.GetToken();

                if ((storedToken == null) || (DateTime.Now > storedToken.Expires))
                {
                    var loginResponse = IdQueryLogin();

                    storedToken = new IdQueryApiToken
                    {
                        Created = loginResponse.Date,
                        Token = loginResponse.Token,
                        Expires = loginResponse.ExpiresOn
                    };

                    tokenRepository.RemoveToken();
                    tokenRepository.WriteToken(storedToken);
                }

                return storedToken.Token;
            }
             catch (Exception exception)
            {
                throw exception;
            }
        }

        // ------------------------------------------------------------------------------------

        private QueryIdLoginResponse IdQueryLogin()
        {
            var response = InfileClient.QueryIdLogin();

            if (response == null)
            {
                throw new Exception("No es posible consultar CUI");
            }

            return response;
        }
    }
}
