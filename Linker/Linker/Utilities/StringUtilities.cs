using System.Linq;
using Xamarin.Forms.Internals;

namespace Linker.Utilities
{
    // MK If you comment out the Preserve attribute the code that uses reflection to instantiate this class will throw an exception
    //    as this class and its methods will be stripped out from the assemblies.

    //    NOTE: Provided that the linker.config file is not listing this class as a exception to the rule of stripping out code
    // [Preserve(AllMembers = true)]
    public class StringUtilities
    {
        public string ReverseString(string textToReverse)
        {
            return new string(textToReverse?.Reverse().ToArray());
        }
    }
}