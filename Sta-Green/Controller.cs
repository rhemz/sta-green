using System;
using System.Threading;

namespace Sta_Green
{

    class Controller
    {
        private View _view;
        private InputHelper _helper;

        private Timer _timer;
        private bool _isRunning;

        public bool Enabled
        {
            get { return _isRunning; }
            set 
            {
                _isRunning = value;
                if (_isRunning)
                {
                    BeginTimer();
                }
                else
                {
                    KillTimer();
                }
            }
        }


        public Controller(View view)
        {
            _view = view;
            _helper = new InputHelper();
            _isRunning = false;
        }


        private void BeginTimer()
        {
            _timer = new Timer(delegate
            {
                try
                {
                    //_view.DisplayStatus(_helper.GetLastInput().ToString(), true);
                    //InputHelper.POINT pos = _helper.GetCursorPosition();
                    //_view.DisplayStatus(String.Format("{0},{1}", pos.X, pos.Y), true);

                    if (_helper.GetLastInput() >= _view.Threshhold)
                    {
                        if (_view.SimulateKeyboard)
                        {
                            _helper.SendKeystroke((ushort)InputHelper.Keys.CONTROL);
                        }

                        if (_view.SimulateMouse)
                        {
                            _helper.MoveMouse(_view.MouseCoords);
                        }
                        _view.DisplayStatus(
                            String.Format("Sent input at: {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
                            , true);
                    }
                }
                catch(Exception e)
                {
                    _view.DisplayStatus(String.Format("Error: {0}", e.Message), false);
                }
            }, null, 0, _view.Interval);

            _view.DisplayStatus("Keeping you active!", true);
        }

        private void KillTimer()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }

            _view.DisplayStatus("Not running.", false);
        }


    }
}
