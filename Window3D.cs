using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using System;

internal class Window3D : GameWindow
{
    private float lineWidth = 10.0f;
    private float linePositionY = 0.0f; // Poziția liniei pe axa Y
    private bool mouseMoving = false;
    private float linePositionX = 0.0f;


    public Window3D() : base(800, 600, new GraphicsMode(32, 24, 0, 8))
    {
        VSync = VSyncMode.On;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        GL.ClearColor(1.0f, 0.5f, 0.0f, 1.0f);
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        if (mouseMoving)
        {
            var mouseState = Mouse.GetState();
            linePositionY = -1.0f * (2.0f * mouseState.Y / Height - 1.0f);
        }
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        GL.MatrixMode(MatrixMode.Modelview);
        GL.LoadIdentity();

        GL.Begin(PrimitiveType.Lines);
        GL.Color3(0.0f, 1.0f, 0.0f); // Verde la un capăt
        GL.Vertex2(0.0f, linePositionY);
        GL.Color3(1.0f, 0.0f, 0.0f); // Roșu la celălalt capăt
        GL.Vertex2(1.0f, linePositionY);
        GL.End();

        SwapBuffers();
    }

    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);

        if (e.Button == MouseButton.Left)
        {
            mouseMoving = true;
        }
    }

    protected override void OnMouseUp(MouseButtonEventArgs e)
    {
        base.OnMouseUp(e);

        if (e.Button == MouseButton.Left)
        {
            mouseMoving = false;
        }
    }
    protected override void OnKeyDown(KeyboardKeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.Key == Key.W)
        {
            linePositionY += 0.05f; // Mișcare în sus (W)
        }
        else if (e.Key == Key.S)
        {
            linePositionY -= 0.05f; // Mișcare în jos (S)
        }
        else if (e.Key == Key.A)
        {
            linePositionX -= 0.05f; // Mișcare la stânga (A)
        }
        else if (e.Key == Key.D)
        {
            linePositionX += 0.05f; // Mișcare la dreapta (D)
        }
    }

}
