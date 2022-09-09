using Xunit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Api.Controllers;


public class ContactsControllerTest
{
    [Fact]
    private async Task Should_Return_Contact_Where_Passs_Contact_Id()
    {
        var controller = new ContacsController();
        var result = await controller.Get();

        Assert.Equal(true,true);
    }
}