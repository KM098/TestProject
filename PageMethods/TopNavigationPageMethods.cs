using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects;

namespace PageMethods
{
    public class TopNavigationPageMethods : BaseSetUp
    {
        private readonly ITopNavigationPageObjects _ITopNavigationPageObjects;
        private readonly IBasePageObjects _IBasePageObjects;

        public TopNavigationPageMethods(ITopNavigationPageObjects iTopNavigationPageObjects, IBasePageObjects iBasePageObjects) : base(iBasePageObjects)
        {
            _ITopNavigationPageObjects = iTopNavigationPageObjects;
            _IBasePageObjects = iBasePageObjects;
        }

        public void SearchByTerm(string searchTerm)
        {
            EnterText(_ITopNavigationPageObjects.SearchBox, "Chandeliers");
            _ITopNavigationPageObjects.SearchSubmitButton.Click();
        }
    }
}
