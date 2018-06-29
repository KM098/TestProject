using PageObjects;

namespace PageMethods
{
    public class SearchPageMethods : BaseSetUp
    {
        private readonly ISearchPageObjects _ISearchPageObjects;
        private readonly IBasePageObjects _IBasePageObjects;

        public SearchPageMethods(ISearchPageObjects iSearchPageObjects, IBasePageObjects iBasePageObjects) : base(iBasePageObjects)
        {
            _ISearchPageObjects = iSearchPageObjects;
            _IBasePageObjects = iBasePageObjects;
        }
    }
}
