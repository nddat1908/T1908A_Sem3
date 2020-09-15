using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLab10.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
    }

    public class NewsManager
    {
        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem() { Id = 1, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/1.png" }) ;
            items.Add(new NewsItem() { Id = 2, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/2.png" }) ;
            items.Add(new NewsItem() { Id = 3, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/3.png" }) ;
            items.Add(new NewsItem() { Id = 4, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/4.png" }) ;
            items.Add(new NewsItem() { Id = 5, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/5.png" }) ;
            items.Add(new NewsItem() { Id = 6, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/6.png" }) ;
            items.Add(new NewsItem() { Id = 7, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/7.png" }) ;
            items.Add(new NewsItem() { Id = 8, Category = "Book", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Books/8.png" }) ;

            items.Add(new NewsItem() { Id = 9, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie1.jpg" }) ;
            items.Add(new NewsItem() { Id = 10, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie2.jpg" }) ;
            items.Add(new NewsItem() { Id = 11, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie3.jpg" }) ;
            items.Add(new NewsItem() { Id = 12, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie4.jpg" }) ;
            items.Add(new NewsItem() { Id = 13, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie5.jpg" }) ;
            items.Add(new NewsItem() { Id = 14, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie1.jpg" }) ;
            items.Add(new NewsItem() { Id = 15, Category = "Movie", Title = "To hellas nor had virtues", Content = "Found dares nor hight relief mote of uses then childe",Img = "Assets/Movies/movie3.jpg" }) ;

            return items;
        }
        public static void GetNews(string category,ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();

            var filteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            filteredNewsItems.ForEach(p => newsItems.Add(p));

        }

    }
     
}
