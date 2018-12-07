namespace access_system.Presenters.Presenters
{
    public abstract class ViewPresenterBase<TView>
    {
        protected TView _view;

        public ViewPresenterBase(TView view)
        {
            _view = view;
        }

        public abstract void InitializeView();
    }
}
