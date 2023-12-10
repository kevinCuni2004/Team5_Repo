using Microsoft.VisualStudio.TestTools.UnitTesting;
using Citisoft;

[TestClass]
public class SignUpTests
{
    private SignUp signUp;

    [TestInitialize]
    public void Setup()
    {
        signUp = new SignUp();
    }

    [TestMethod]
    public void RegisterUser_ValidInput_Success()
    {
        // Arrange
        string email = "validemail@citisoft.co.uk";
        string password = "ValidPassword123!";

        // Act
        var result = signUp.RegisterUser(email, password);

        // Assert
        Assert.AreEqual("Success", result.message);
        Assert.IsNotNull(result.profile);
        Assert.AreEqual(email, result.profile.Email);
        // Add more assertions as needed
    }

    [TestMethod]
    public void RegisterUser_InvalidEmail_ThrowsArgumentException()
    {
        // Arrange
        string email = "invalidemail@example.com";
        string password = "ValidPassword123!";

        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => signUp.RegisterUser(email, password));
    }

    [TestMethod]
    public void RegisterUser_InvalidPassword_ThrowsArgumentException()
    {
        // Arrange
        string email = "validemail@citisoft.co.uk";
        string password = "weakpassword";

        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => signUp.RegisterUser(email, password));
    }

    [TestMethod]
    public void RegisterUser_DuplicateEmail_ThrowsArgumentException()
    {
        // Arrange
        string email = "existingemail@citisoft.co.uk";
        string password = "ValidPassword123!";

        // Ensure the email already exists in the database
        signUp.RegisterUser(email, password);

        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => signUp.RegisterUser(email, password));
    }
}
