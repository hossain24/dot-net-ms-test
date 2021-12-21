using System;

namespace DotNet {
    public class BookAvailability {
        public Book WrittenBook { get; set; }

        public bool AvailabilityOfBook (Book book) {

            if (book.IsAvailable)
                return true;
            if (WrittenBook == book)
                return true;

            return false;

            //return (book.IsAvailable || WrittenBook == book);
        }
    }

    public class Book {
        public bool IsAvailable { get; set; }
    }
}