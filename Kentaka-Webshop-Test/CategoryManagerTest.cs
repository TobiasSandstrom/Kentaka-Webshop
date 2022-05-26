using Kentaka_Webshop.Controllers;
using Kentaka_Webshop.Data;
using Kentaka_Webshop.Managers;
using Kentaka_Webshop.Models;
using Kentaka_Webshop.Models.CategoryModels;
using Kentaka_Webshop.Models.ContactMessageModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kentaka_Webshop_Test
{
    public class CategoryManagerTest
    {

        
        [Fact]
        public async Task Index_Should_Return_View_With_ContactDatamodel()
        {

            
            var iCategoryManager = new Mock<ICategoryManager>();

            iCategoryManager.Setup(c => c.GetAllAsync()).ReturnsAsync(await CategoryFixtures.GetCategoriesAsync());

            var contactController = new ContactController(iCategoryManager.Object);


            var result = await contactController.Index();
            
            
            var res = Assert.IsType<ViewResult>(result);
            var res2 = Assert.IsAssignableFrom<ContactDataModel>(res.ViewData.Model);
            var res3 = Assert.IsType<List<CategoryViewModel>>(res2.Categories);
            var res4 = Assert.IsType<ContactMessageForm>(res2.Form);
            var res5 = Assert.IsType<ContactMessageResult>(res2.Result);


        }

    }
}
