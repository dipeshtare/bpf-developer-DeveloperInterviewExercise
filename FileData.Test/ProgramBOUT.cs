using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileData.Test
{
    [TestFixture]
    class ProgramBOUT
    {
        public ProgramBO _programBO;
        public Mock<IProgramBO> _iProgramBO;

        [SetUp]
        public void SetUp()
        {
            _iProgramBO = new Mock<IProgramBO>();
            _programBO = new ProgramBO();
        }

        [Test]
        public void CheckConsoleArguments_Success()
        {
            try
            {
                _programBO.CheckConsoleArguments(It.IsAny<string[]>());
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestCase("string_message")]
        [TestCase(10)]
        [TestCase(null)]
        public void DisplayMessage_Success<T>(T message)
        {
            try
            {
                _programBO.DisplayMessage(message);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}