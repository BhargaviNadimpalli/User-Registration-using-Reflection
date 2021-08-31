using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegestrationMsTest;
using UserRegistrationUsingReflection;

namespace UserRegestrationMsTest
{
    [TestClass]

    public class UnitTest1
    {
        public User user;

    [TestInitialize]
    public void SetUp()
    {
        user = new User();
    }
    /// <summary>
    /// Happy TestCases
    /// </summary>
    [TestMethod]
    public void FirstNameValidationShouldReturnTrue()
    {
        //Arrange
        string firstName = "Bhagi";
        //Act
        bool result = user.ValidateFirstName(firstName);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void LastNameValidationShouldReturnTrue()
    {
        //Arrange
        string lastName = "Nadimpalli";
        //Act
        bool result = user.ValidateLastName(lastName);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void EmailValidationShouldReturnTrue()
    {
        //Arrange
        string email = "Bhagi@gmail.com";
        //Act
        bool result = user.ValidateEmail(email);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void MobileNumberValidationShouldReturnTrue()
    {
        //Arrange
        string mobileNumber = "91 9999565995";
        //Act
        bool result = user.ValidateMobileNumber(mobileNumber);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void PasswordValidationShouldReturnTrue()
    {
        //Arrange
        string password = "Bhagi@123";
        //Act
        bool result = user.ValidatePassword(password);
        //Assert
        Assert.IsTrue(result);
    }
    /// <summary>
    /// Sad Test Cases
    /// </summary>
    [TestMethod]
    public void FirstNameValidationShouldReturnFalse()
    {
        //Arrange
        string firstName = "Bhargavi";
        //Act
        bool result = user.ValidateFirstName(firstName);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void LastNameValidationShouldReturnFalse()
    {
        //Arrange
        string lastName = "Nadimpali";
        //Act
        bool result = user.ValidateLastName(lastName);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void EmailValidationShouldReturnFalse()
    {
        //Arrange
        string email = "Bhargavi@com";
        //Act
        bool result = user.ValidateEmail(email);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void MobileNumberValidationShouldReturnFalse()
    {
        //Arrange
        string mobileNumber = "91 099599955";
        //Act
        bool result = user.ValidateMobileNumber(mobileNumber);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void PasswordValidationShouldReturnFalse()
    {
        //Arrange
        string password = "Bhagi123";
        //Act
        bool result = user.ValidatePassword(password);
        //Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    [DataRow("abc@yahoo.com")]
    [DataRow("abc-100@yahoo.com")]
    [DataRow("abc.100@yahoo.com")]
    [DataRow("abc111@abc.com")]
    [DataRow("abc-100@abc.net")]
    [DataRow("abc.100@abc.com.au")]
    [DataRow("abc@1.com")]
    [DataRow("abc@gmail.com.com")]
    [DataRow("abc+100@gmail.com")]
    public void ValidateSampleEmailsShouldReturnTrue(string email)
    {
        Assert.IsTrue(user.ValidateEmail(email));
    }
    [TestMethod]
    public void FirstNameValidationShouldReturnException()
    {
        try
        {
            //Arrange
            string firstName = "Bhagi";
            //Act
            bool result = user.ValidateFirstName(firstName);
        }
        catch (CustomException ex)
        {
            //Assert
            Assert.AreEqual("It is Invalid", ex.Message);
        }
    }
    [TestMethod]
    public void LastNameValidationShouldReturnException()
    {
        try
        {
            //Arrange
            string lastName = "Nadimpalli";
            //Act
            bool result = user.ValidateLastName(lastName);
        }
        catch (CustomException ex)
        {
            //Assert
            Assert.AreEqual("It is Invalid", ex.Message);
        }
    }
    [TestMethod]
    public void EmailValidationShouldReturnException()
    {
        try
        {
            //Arrange
            string email = "bhagi@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
        }
        catch (CustomException ex)
        {
            //Assert
            Assert.AreEqual("It is Invalid", ex.Message);
        }
    }
    [TestMethod]
    public void MobileNumberValidationShouldReturnException()
    {
        try
        {
            string mobileNumber = "91 9993259955";
            bool result = user.ValidateMobileNumber(mobileNumber);
        }
        catch (CustomException ex)
        {
            Assert.AreEqual("It is Invalid", ex.Message);
        }
    }
    [TestMethod]
    public void PasswordValidationShouldReturnException()
    {
        try
        {
            //Arrange
            string password = "Bhagi@123";
            //Act
            bool result = user.ValidatePassword(password);
        }
        catch (CustomException ex)
        {
            Assert.AreEqual("It is Invalid", ex.Message);
        }
    }
}
    }
 

