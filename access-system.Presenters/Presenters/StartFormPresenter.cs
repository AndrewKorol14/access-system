using access_system.IServices;
using access_system.Presenters.Views;

namespace access_system.Presenters.Presenters
{
    public class StartFormPresenter : ViewPresenterBase<IStartFormView>
    {
        private IStartService _startService;

        public StartFormPresenter(IStartFormView view, IStartService startService) : base(view)
        {
            _startService = startService;
        }

        public delegate StartFormPresenter Factory(IStartFormView view);

        public override void InitializeView()
        {
            _view.StartEntity = _startService.GetData();
        }
    }
}
