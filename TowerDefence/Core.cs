using System;
using System.Collections.Generic;
using System.Text;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace TowerDefence
{
    class Core
    {
        private RenderWindow _window;
        private Clock _timer;
        Sprite sp;
        public Core(string name, uint width, uint height)
        {
            _window = new RenderWindow(new VideoMode(width, height), name);
            _timer = new Clock();
        }

        public void Run()
        {
            Subscribe();
            Content.Load();
            sp = new Sprite(Content.texTile0);

            while(_window.IsOpen)
            {
                var time = _timer.ElapsedTime.AsSeconds();
                _timer.Restart();

                _window.DispatchEvents();

                Events();
                Update();
                Render();
            }
        }

        private void Subscribe()
        {
            _window.Closed += WindowCloseEvent;
            _window.KeyPressed += WindowKeyPressedEvent;
            _window.TextEntered += WindowTextEnteredEvent;
            _window.Resized += WindowResizedEvent;
        }

        private void Events()
        {

        }

        private void Update()
        {

        }

        private void Render()
        {
            _window.Clear(Color.White);

            _window.Draw(sp);

            _window.Display();
        }

        private void WindowResizedEvent(object sender, SizeEventArgs e)
        {
            _window.SetView(new View(new FloatRect(0, 0, e.Width, e.Height)));
        }

        private void WindowTextEnteredEvent(object sender, TextEventArgs e)
        {
        }

        private void WindowKeyPressedEvent(object sender, KeyEventArgs e)
        {
        }

        private void WindowCloseEvent(object sender, EventArgs e)
        {
            var win = sender as RenderWindow;
            win.Close();
        }
    }
}
