using System;
using System.Collections.Generic;

namespace DirectorySyncMVP
{
    public class SyncPresenter
    {
        private readonly IView _view;
        private readonly SyncModel _model;

        public SyncPresenter(IView view, SyncModel model)
        {
            _view = view;
            _model = model;
            _view.SyncRequested += OnSyncRequested;
        }

        private void OnSyncRequested()
        {
            var log = new List<string>();
            _model.SyncDirectories(_view.Directory1Path, _view.Directory2Path, out log);

            foreach (var entry in log)
            {
                _view.ShowLog(entry);
            }
        }
    }
}