namespace FileVault.WebApi.Tests.Controllers;
using FileVault.WebApi.Controllers;
using Xunit;

public class UsersControllerTests
{
    [Fact]
    public void ListReturnsEmptyList()
    {
        var controller = new UsersController();
        var users = controller.List().ToList();
        Assert.NotNull(users);
        Assert.Empty(users);
    }
}
