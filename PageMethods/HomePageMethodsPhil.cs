using PageObjects;

namespace PageMethods
{
    public class HomePageMethodsPhil : BaseSetUp
    {
        private readonly IHomePageObjects _IHomePageObjects;
        private readonly IBasePageObjects _IBasePageObjects;

        public HomePageMethodsPhil(IHomePageObjects iHomePageObjects, IBasePageObjects iBasePageObjects) : base(iBasePageObjects)
        {
            _IHomePageObjects = iHomePageObjects;
            _IBasePageObjects = iBasePageObjects;
        }
        public bool IsEmailPopUpDisplayed() => IsDisplayed(_IHomePageObjects.EmailPopUp);
    }
}
