using OBilet.Case.Study.Business.Abstractions;
using StackExchange.Redis;

namespace OBilet.Case.Study.Business.Services
{
    public class RedisService : IRedisService
    {
        #region FieldsAndProps
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _database;
        #endregion

        #region Ctors
        public RedisService(string connectionString)
        {
            _redis = ConnectionMultiplexer.Connect(connectionString);
            _database = _redis.GetDatabase();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Redis'e ekleme işlemi gerçekleştirir.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        public async Task SetValueAsync(string key, string value, TimeSpan expire)
        {
            await _database.StringSetAsync(key, value, expiry: expire);
        }

        /// <summary>
        /// Redisten veri çekme işlemi yapar.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<string> GetValueAsync(string key)
        {
            return await _database.StringGetAsync(key);
        }

        /// <summary>
        /// Redisteki veriyi verilen parametreye göre siler.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task DeleteKeyAsync(string key)
        {
            await _database.KeyDeleteAsync(key);
        }

        #endregion
    }
}
