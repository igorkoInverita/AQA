using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Inverita.AQA.SpecFlowProject
{
    [Binding]
    public class TablesStepsDefinitions
    {
        private readonly FeatureContext _featureContext;

        public TablesStepsDefinitions(FeatureContext featureContext)
        {
            _featureContext = featureContext;
        }

        //[Given(@"I read the following books")]
        public void GivenIReadTheFollowingBooks(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                var getRes = tableRow.TryGetValue("Author", out var author);
                Console.WriteLine(author);
            }
        }
        
        [Given(@"I read the following list of books")]
        [Given(@"I read the following books")]
        public void GivenIReadTheFollowingListBooks(Table table)
        {
            var booksTable = table.CreateSet<Book>();
            foreach (var book in booksTable)
            {
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Title);
            }
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}