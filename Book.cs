// Make a Book class that has
// - Title property
// - Author property
// - ISBN (this will be a string) property

using System.Collections.Generic;

namespace Library {
    public class Book 
    {
        public Book() 
        {
            IsAvailble = true;
        }
        
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailble { get; set; }
    }
}

 