using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;

namespace Assignment12._3._2
{
    public class BooksViewModel
    {
        private readonly BookContext _db;
        public ObservableCollection<Book> Books { get; set; } = new();
        private int _newBookID;
        public int NewBookID
        {
            get => _newBookID;
            set { _newBookID = value; OnPropertyChanged(); }
        }

        private string _newBookTitle;
        public string NewBookTitle 
        { 
            get => _newBookTitle;
            set { _newBookTitle = value; OnPropertyChanged(); }
        }

        private string _newBookAuthor;
        public string NewBookAuthor
        {
            get => _newBookAuthor;
            set { _newBookAuthor = value; OnPropertyChanged(); }
        }

        private int _newBookYear;
        public int NewBookYear
        {
            get => _newBookYear;
            set { _newBookYear = value; OnPropertyChanged(); }
        }
        public ICommand AddBookCommand { get; }
        public ICommand RefreshCommand { get; }
        public ICommand DeleteBookCommand { get; }
        public BooksViewModel(BookContext db)
        {
            _db = db;
            LoadBooks();

            AddBookCommand = new Command(AddBook);
            RefreshCommand = new Command(LoadBooks);
            DeleteBookCommand = new Command(DeleteBook);
        }

        private void LoadBooks()
        {
            Books.Clear();
            foreach (var book in _db.Books.ToList())
                Books.Add(book);
        }

        private void AddBook()
        {
            
            var newBook = new Book { Id = NewBookID, Title = NewBookTitle, Author = NewBookAuthor, PublishDate = NewBookYear };
            _db.Books.Add(newBook);
            _db.SaveChanges();

            Books.Add(newBook);

            NewBookID = 0;
            NewBookTitle = "";
            NewBookAuthor = "";
            NewBookYear = 0;
        }
        private void DeleteBook()
        {
            var bookToDelete = _db.Books.FirstOrDefault(b => b.Id == NewBookID);
            if (bookToDelete == null) return;

            _db.Books.Remove(bookToDelete);
            _db.SaveChanges();

            Books.Remove(bookToDelete);

            NewBookID = 0; // Clear input
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
