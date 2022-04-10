namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal abstract class AddEntityController<T> : Controller<T> where T : Form
    {
        public AddEntityController(T form) : base(form)
        {
        }
        protected abstract void HandleAddNewEntityButtonClick(object? sender, EventArgs e);
        
    }
}
