using SA_Week4.Model;
using System.Windows.Controls;

namespace SA_Week4.ViewModel
{
    public class SodokuViewModel
    {
        private SodokuModel _game;

        public SodokuViewModel()
        {
            _game = new SodokuModel();
            _game.NewGame();
        }

        public SodokuModel Game
        {
            get { return _game; }
        }
    }
}