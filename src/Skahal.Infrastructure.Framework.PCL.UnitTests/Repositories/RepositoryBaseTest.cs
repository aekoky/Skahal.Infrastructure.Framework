using System;
using NUnit.Framework;
using Rhino.Mocks;
using Skahal.Infrastructure.Framework.PCL.People;
using Skahal.Infrastructure.Framework.PCL.Repositories;
using TestSharp;

namespace Skahal.Infrastructure.Framework.PCL.UnitTests.Repositories
{
    [TestFixture]
    public class RepositoryBaseTest
    {
        [Test]
        public void PersistDeletedItem_Null_Exception()
        {            
            var target = MockRepository.GeneratePartialMock <RepositoryBase<User>>();

            ExceptionAssert.IsThrowing(new ArgumentNullException("item"), () =>
            {
                target.PersistDeletedItem(null);
            });
        }

        [Test]
        public void PersistNewItem_Null_Exception()
        {
            var target = MockRepository.GeneratePartialMock<RepositoryBase<User>>();

            ExceptionAssert.IsThrowing(new ArgumentNullException("item"), () =>
            {
                target.PersistNewItem(null);
            });
        }

        [Test]
        public void PersistUpdatedItem_Null_Exception()
        {
            var target = MockRepository.GeneratePartialMock<RepositoryBase<User>>();

            ExceptionAssert.IsThrowing(new ArgumentNullException("item"), () =>
            {
                target.PersistUpdatedItem(null);
            });
        }
    }
}