using System.Collections;

namespace ABMWeb.Models
{
    public class BigViewModel : IEnumerable<BigViewModel>
    {
        public MainPage mainPage { get; set; }
        public Icon icon    { get; set; }

        public IEnumerator<BigViewModel> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
