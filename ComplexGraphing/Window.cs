using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL;

namespace ComplexGraphing
{
    internal class Window : GameWindow
    {
        public Window()
            : base(GameWindowSettings.Default, new NativeWindowSettings()
            {
                Title = "Complex Graphing Calculator",
                Size = new(1920, 1080),
                StartVisible = false,
                APIVersion = new(3,3),
            })
        {
            
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad()
        {
            GL.ClearColor(new Color4(230, 56, 39, 255));
            IsVisible = true;

            base.OnLoad();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            SwapBuffers();

            base.OnRenderFrame(args);
        }
    }
}
