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
        public void GetUsers_取得兩筆UserData_回傳兩筆UserData()
        {
            // Arrange
            var userRepo = Substitute.For<IRepository<User>>();
            var userData = new List<User>
                            {
                                new User { Id = 1, Name = "User01" },
                                new User { Id = 2, Name = "User02" }
                            };
            // 不包含搜尋條件，filter = null，直接將 userData 轉 IQueryable 回傳
            userRepo.Query(Arg.Any<Expression<Func<User, bool>>>())
                    .Returns(userData.AsQueryable());
            var getData = new GetDataService(userRepo);

            // Act
            var result = getData.GetUsers();

            // Assert
            Assert.Equal(result.Any(x => x.Id == 1 && x.Name == "User01"), true);
            Assert.Equal(result.Any(x => x.Id == 2 && x.Name == "User02"), true);
        }

        [Fact]
        public void GetUser_輸入Id_回傳UserData()
        {
            // Arrange
            var userRepo = Substitute.For<IRepository<User>>();
            var userData = new List<User>
                           {
                               new User { Id = 1, Name = "User01" },
                               new User { Id = 2, Name = "User02" }
                           };
            // 包含搜尋條件，將 userData.Where 使用 filter 條件搜尋後回傳
            userRepo.Query(Arg.Any<Expression<Func<User, bool>>>())
                    .Returns(arg => userData.Where(arg.ArgAt<Expression<Func<User, bool>>>(0).Compile()).AsQueryable());
            var getData = new GetDataService(userRepo);

            // Act
            var result = getData.GetUsersById(1);

            // Assert
            Assert.Equal(result.Id == 1 && result.Name == "User01", true);
        }
    }
}
