using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Assignment11._1._1.Models;
using Assignment11._1._1.Data;

namespace Assignment11._1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductContext context;
        Book newBook = new Book();
        public MainWindow(ProductContext _context)
        {
            InitializeComponent();
            context = _context;
            
            BookDG.ItemsSource = context.Books.ToList();
            AddBookGrid.DataContext = newBook;

        }
        Book selectedBook;
        private void UpdateButton_Click(object Sender, RoutedEventArgs e)
        {
            selectedBook = (Sender as FrameworkElement).DataContext as Book;
            UpdateBookGrid.DataContext = selectedBook;
        }
        private void DeleteButton_Click(object Sender, RoutedEventArgs e)
        {
            var book = (Sender as FrameworkElement).DataContext as Book;
            if(book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
                BookDG.ItemsSource = context.Books.ToList();
                MessageBox.Show("Product Deleted Successfully");
            }
        }
        private void UpdateBookEdit(object Sender, RoutedEventArgs e)
        {
            context.Books.Update(selectedBook);
            context.SaveChanges();
            BookDG.ItemsSource = context.Books.ToList();
        }
        private void AddBook(object Sender, RoutedEventArgs e)
        {
            context.Books.Add(newBook);
            context.SaveChanges();
            BookDG.ItemsSource = context.Books.ToList();
            MessageBox.Show("Product Added Successfully");
            newBook = new Book();
            AddBookGrid.DataContext = newBook;

        }
    }
}