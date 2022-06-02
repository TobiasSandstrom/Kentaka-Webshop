using Castle.Core.Logging;
using Kentaka_Webshop.Areas.Identity.Pages.Account;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kentaka_Webshop.Areas.Identity.Pages.Account.LoginModel;

namespace Kentaka_Webshop_Test
{
    [TestFixture]
   public class Auth_Identity_test
    { 
        [Test]
        public async void Login_WithEmailandPassword()
        {
            //Arrange
            string email = "test@test.com";
            string password = "P@ssw0rd!";
            InputModel inputModel = new InputModel();
            inputModel.Email = email;
            inputModel.Password = password;


            //Act

            var result = (inputModel.Email, inputModel.Password);
            //Assert

            Assert.IsNotNull(result);

        }
    }
}
