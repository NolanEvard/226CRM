using NUnit.Framework;

namespace CRM
{
    public class Tests
    {
        #region private attributes
        private Contact _contact = null;
        private string _name;
        private string _firstname;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _name = "Ricard";
            _firstname = "Mathieu";
            _contact = new Contact(_name, _firstname);
        }

        [Test]
        public void Name_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualName = "";
            string expectedName = "Ricard";

            //when
            actualName = _contact.Name;

            //then
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Firstname_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualFirstname = "";
            string expectedFirstname = "Mathieu";

            //when
            actualFirstname = _contact.Firstname;

            //then
            Assert.AreEqual(expectedFirstname, actualFirstname);
        }
    }
}