namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Criamos a pilha de navegaçao
            var navPage = new NavigationPage(new MinhaPagina());

            //Alteramos a cor do fundo e do texto da barra de navegaçao 
            navPage.BarBackground = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            MainPage = new GridLayoutDemo();
        }
    }
}
