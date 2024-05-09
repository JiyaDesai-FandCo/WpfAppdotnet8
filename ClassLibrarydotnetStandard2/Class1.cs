using System;
using Windows.Services.Store;

namespace ClassLibrarydotnetStandard2
{
    public class Class1
    {
        public string LibraryFunctionToGetPackageName()
        {

            // will only work if you include Windows SDK Contract nuget package

            Windows.ApplicationModel.Package package = Windows.ApplicationModel.Package.Current;
            var Packageversion = new Version(package.Id.Version.Major, package.Id.Version.Minor, package.Id.Version.Build);
            var PackageDisplayName = package.DisplayName;
            var PackageUniqueName = package.Id.Name;
            return (string.Format("{0} - {1}", PackageDisplayName, Packageversion.ToString()));
        }

        public bool StoreInit()
        {
            StoreContext s = StoreContext.GetDefault();
            if (s==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
