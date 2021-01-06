using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NSubstitute;
using NSubstituteWithExpression;
using Xunit;

namespace NSubstituteWithExpressionTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetUsers_���o�ⵧUserData_�^�ǨⵧUserData()
        {
            try
            {
                //Arrange
                var userRepo = Substitute.For<IRepository<User>>();
                var userData = new List<User>
                               {
                                   new User { Id = 1, Name = "User01" },
                                   new User { Id = 2, Name = "User02" }
                               };
                userRepo.Query(Arg.Any<Expression<Func<User, bool>>>())
                        .Returns(userData.AsQueryable());
                var getData = new GetDataService(userRepo);

                //act
                var result = getData.GetUsers();

                //assert
                Assert.Equal(result.Any(x => x.Id == 1 && x.Name == "User01"), true);
                Assert.Equal(result.Any(x => x.Id == 2 && x.Name == "User02"), true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Fact]
        public void GetUsers_��JId_�^��UserData()
        {
            //Arrange
            var userRepo = Substitute.For<IRepository<User>>();
            var userData = new List<User>
                           {
                               new User { Id = 1, Name = "User01" },
                               new User { Id = 2, Name = "User02" }
                           };
            userRepo.Query(Arg.Any<Expression<Func<User, bool>>>())
                    .Returns(arg => userData.Where(arg.ArgAt<Expression<Func<User, bool>>>(0).Compile()).AsQueryable());
            var getData = new GetDataService(userRepo);

            //act
            var result = getData.GetUsersById(1);

            //assert
            Assert.Equal(result.Id == 1 && result.Name == "User01", true);
        }

    }
}
