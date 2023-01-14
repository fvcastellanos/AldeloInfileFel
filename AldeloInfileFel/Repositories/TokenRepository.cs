using AldeloInfileFel.Domain;
using AldeloInfileFel.Services;
using System;
using Dapper;
using System.Data.SQLite;

namespace AldeloInfileFel.Repositories
{
    public class TokenRepository
    {
        private readonly string StoreToken = "insert into api_token (token, created, expires) values (@Token, @Created, @Expires)";

        private readonly string ReadLatestToken = "select * from api_token order by created desc";

        private readonly string DeleteToken = "delete from api_token";

        private readonly Configuration _configuration;

        public TokenRepository()
        {
            _configuration = ConfigurationService.LoadConfiguration();
        }

        public void WriteToken(IdQueryApiToken idQueryApiToken)
        {
            using (var db = new SQLiteConnection(_configuration.InternalDbConnectionString))
            {
                db.Execute(StoreToken, new { Token = idQueryApiToken.Token, Created = idQueryApiToken.Created, Expires = idQueryApiToken.Expires });
            }
        }

        public void RemoveToken()
        {
            using (var db = new SQLiteConnection(_configuration.InternalDbConnectionString))
            {
                db.Execute(DeleteToken);
            }
        }

        public IdQueryApiToken GetToken()
        {
            using (var db = new SQLiteConnection(_configuration.InternalDbConnectionString))
            {
                return db.QueryFirstOrDefault<IdQueryApiToken>(ReadLatestToken);
            }

        }

    }
}
