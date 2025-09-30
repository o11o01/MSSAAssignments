namespace Assignment12._3._2
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(BooksViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
