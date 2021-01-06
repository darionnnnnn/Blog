using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSubstituteWithExpression
{
    public class GetDataService
    {
        private IRepository<User> _UserRepo { get; }

        public GetDataService(IRepository<User> userRepo)
        {
            _UserRepo = userRepo;
        }

        /// <summary>
        /// 取得全部 User
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUsers()
        {
            var data = _UserRepo.Query();

            return data.AsEnumerable();
        }

        /// <summary>
        /// 依據 UserId 取得 User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUsersById(int id)
        {
            var data = _UserRepo.Query(x => x.Id == id);

            return data.FirstOrDefault();
        }
    }
}
