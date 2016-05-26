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
    public static class QuoteLoaderFactory
    {
        // This must be assigned to a method which creates a new quote loader.
        public static Func<IQuoteLoader> Create { get; set; }
    }
}