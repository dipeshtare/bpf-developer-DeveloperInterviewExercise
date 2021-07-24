using NUnit.Framework;

namespace ThirdPartyTools.Test
{
    [TestFixture]
    class FileDetailsUT
    {
        private FileDetails fileDetails;

        [SetUp]
        public void SetUp()
        {
            fileDetails = new FileDetails();
        }

        [TestCase("C:/filePath")]
        public void Version_Success(string filePath)
        {
            //Arrange

            //Act
            var result = fileDetails.Version(filePath);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<string>(result);
        }

        [TestCase("C:/filePath")]
        public void Size_Success(string filePath)
        {
            //Arrange

            //Act
            var result = fileDetails.Size(filePath);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<string>(result);
        }
    }
}