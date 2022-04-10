namespace BelPomagalo.Controllers
{
    internal class Controller<T> where T:Form
    {
        protected readonly T _form;
        public Controller(T form)
        {
            _form = form;
        }
        public T Form { get => _form; }
    }
}
