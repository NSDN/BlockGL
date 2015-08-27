Imports SharpGL

Class MainWindow
    Private Gl As OpenGL
    Private Msg As MsgWindow
    Private Const APP_VERSION As String = "0.001"
    Private Const _N As Char = Chr(13)

    Private rtri, rquad As Single

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded, MyBase.Loaded
        MainWindow.Title = "BlockGL" & " " & "Ver" & APP_VERSION
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As RoutedEventArgs) Handles BtnAbout.Click
        Msg = New MsgWindow()
        Msg.ShowWinodw("About", "  " & MainWindow.Title & _N & _N & "Developed by NSDN" & _N & _N & "            2015")
    End Sub

    Private Sub GlCtrl_OpenGLInitialized(sender As Object, args As SharpGL.SceneGraph.OpenGLEventArgs) Handles GlCtrl.OpenGLInitialized
        Gl = GlCtrl.OpenGL
    End Sub

    Private Sub GlCtrl_OpenGLDraw(sender As Object, args As SharpGL.SceneGraph.OpenGLEventArgs) Handles GlCtrl.OpenGLDraw
        Gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT Or OpenGL.GL_DEPTH_BUFFER_BIT)

        Gl.LoadIdentity()
        Gl.Translate(-1.5F, 0F, -6.0F)
        Gl.Rotate(rtri, 0F, 1.0F, 0F)

        Gl.Begin(OpenGL.GL_TRIANGLES)
        Gl.Color(1.0F, 0F, 0F) : Gl.Vertex(0F, 1.0F, 0F)
        Gl.Color(0F, 1.0F, 0F) : Gl.Vertex(-1.0F, -1.0F, 1.0F)
        Gl.Color(0F, 0F, 1.0F) : Gl.Vertex(1.0F, -1.0F, 1.0F)
        Gl.Color(1.0F, 0F, 0F) : Gl.Vertex(0F, 1.0F, 0F)
        Gl.Color(0F, 0F, 1.0F) : Gl.Vertex(1.0F, -1.0F, 1.0F)
        Gl.Color(0F, 1.0F, 0F) : Gl.Vertex(1.0F, -1.0F, -1.0F)
        Gl.Color(1.0F, 0F, 0F) : Gl.Vertex(0F, 1.0F, 0F)
        Gl.Color(0F, 1.0F, 0F) : Gl.Vertex(1.0F, -1.0F, -1.0F)
        Gl.Color(0F, 0F, 1.0F) : Gl.Vertex(-1.0F, -1.0F, -1.0F)
        Gl.Color(1.0F, 0F, 0F) : Gl.Vertex(0F, 1.0F, 0F)
        Gl.Color(0F, 0F, 1.0F) : Gl.Vertex(-1.0F, -1.0F, -1.0F)
        Gl.Color(0F, 1.0F, 0F) : Gl.Vertex(-1.0F, -1.0F, 1.0F)
        Gl.End()

        Gl.LoadIdentity()
        Gl.Translate(1.5F, 0F, -7.0F)
        Gl.Rotate(rquad, 1.0F, 1.0F, 1.0F)

        Gl.Begin(OpenGL.GL_QUADS)
        Gl.Color(0F, 1.0F, 0F)
        Gl.Vertex(1.0F, 1.0F, -1.0F) ： Gl.Vertex(-1.0F, 1.0F, -1.0F)
        Gl.Vertex(-1.0F, 1.0F, 1.0F) ： Gl.Vertex(1.0F, 1.0F, 1.0F)
        Gl.Color(1.0F, 0.5F, 0F)
        Gl.Vertex(1.0F, -1.0F, 1.0F) ： Gl.Vertex(-1.0F, -1.0F, 1.0F)
        Gl.Vertex(-1.0F, -1.0F, -1.0F) ： Gl.Vertex(1.0F, -1.0F, -1.0F)
        Gl.Color(1.0F, 0F, 0F)
        Gl.Vertex(1.0F, 1.0F, 1.0F) ： Gl.Vertex(-1.0F, 1.0F, 1.0F)
        Gl.Vertex(-1.0F, -1.0F, 1.0F) ： Gl.Vertex(1.0F, -1.0F, 1.0F)
        Gl.Color(1.0F, 1.0F, 0F)
        Gl.Vertex(1.0F, -1.0F, -1.0F) ： Gl.Vertex(-1.0F, -1.0F, -1.0F)
        Gl.Vertex(-1.0F, 1.0F, -1.0F) ： Gl.Vertex(1.0F, 1.0F, -1.0F)
        Gl.Color(0F, 0F, 1.0F)
        Gl.Vertex(-1.0F, 1.0F, 1.0F) ： Gl.Vertex(-1.0F, 1.0F, -1.0F)
        Gl.Vertex(-1.0F, -1.0F, -1.0F) ： Gl.Vertex(-1.0F, -1.0F, 1.0F)
        Gl.Color(1.0F, 0F, 1.0F)
        Gl.Vertex(1.0F, 1.0F, -1.0F) ： Gl.Vertex(1.0F, 1.0F, 1.0F)
        Gl.Vertex(1.0F, -1.0F, 1.0F) ： Gl.Vertex(1.0F, -1.0F, -1.0F)
        Gl.End()
        Gl.Flush()

        rtri += 1.0F
        rquad -= 1.0F
    End Sub

End Class
