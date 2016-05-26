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
using System.Collections.ObjectModel;

namespace GreatQuotes.Data
{
    public class QuoteManager
    {
        static readonly Lazy<QuoteManager> instance = new Lazy<QuoteManager>(() => new QuoteManager());

        public static QuoteManager Instance { get { return instance.Value; } }

        readonly IQuoteLoader repo;

        public IList<GreatQuote> Quotes { get; private set; }

        private QuoteManager() {
            repo = QuoteLoaderFactory.Create();
            Quotes = new ObservableCollection<GreatQuote>(repo.Load());
        }

        public void Save() {
            repo.save(Quotes);
        }
    }
}