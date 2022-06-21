using GraphQLExperiments.Models;

namespace GraphQLExperiments;

public class Query
{
    public Book GetBook() => 
        new Book
        {
            Title = "Three body problem",
            Author = new Author
            {
                Name = "Liu Cixin"
            }
        };
}