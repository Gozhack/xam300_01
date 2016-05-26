using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GreatQuotes.Data
{
    public interface IQuoteLoader
    {
        IEnumerable<GreatQuote> Load();
        void save(IEnumerable<GreatQuote> quotes);
    }
}