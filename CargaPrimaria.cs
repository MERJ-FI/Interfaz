using LearnOpenTK.Common;
using OpenTK;
using OpenTK.Graphics.ES30;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;


namespace Cansat_HMI
{
    public partial class CargaPrimaria : Form
    {
        #region Configurables
        const float alturaR = 0.9f;
        //Cara trasera
        public static readonly float[] colorC1 = new float[] { 1.0f, 0.0f, 0.0f};
        //Cara frontal o principal
        public static readonly float[] colorC2 = new float[] { 0.0f, 1.0f, 0.0f };
        //Caras laterales
        public static readonly float[] colorC3 = new float[] { 0.0f, 0.0f, 1.0f };
        public static readonly float[] colorC4 = new float[] { 0.0f, 0.0f, 1.0f };
        public static readonly float[] colorC5 = new float[] { 0.0f, 0.0f, 1.0f };
        public static readonly float[] colorC6 = new float[] { 0.0f, 0.0f, 1.0f };

        

        // Vertices de modelo 3D
        float[,] vertices = {
            {-0.5f, -0.5f, -alturaR, colorC1[0], colorC1[1], colorC1[2]}, 
            { 0.5f, -0.5f, -alturaR, colorC1[0], colorC1[1], colorC1[2]}, 
            { 0.5f,  0.5f, -alturaR, colorC1[0], colorC1[1], colorC1[2]}, 
            { 0.5f,  0.5f, -alturaR, colorC1[0], colorC1[1], colorC1[2]}, 
            {-0.5f,  0.5f, -alturaR, colorC1[0], colorC1[1], colorC1[2]},
            {-0.5f, -0.5f, -alturaR, colorC1[0], colorC1[1], colorC1[2]},
            
            {-0.5f, -0.5f,  alturaR, colorC2[0], colorC2[1], colorC2[2]}, 
            { 0.5f, -0.5f,  alturaR, colorC2[0], colorC2[1], colorC2[2]}, 
            { 0.5f,  0.5f,  alturaR, colorC2[0], colorC2[1], colorC2[2]}, 
            { 0.5f,  0.5f,  alturaR, colorC2[0], colorC2[1], colorC2[2]}, 
            {-0.5f,  0.5f,  alturaR, colorC2[0], colorC2[1], colorC2[2]},
            {-0.5f, -0.5f,  alturaR, colorC2[0], colorC2[1], colorC2[2]}, 

            {-0.5f,  0.5f,  alturaR, colorC3[0], colorC3[1], colorC3[2]}, 
            {-0.5f,  0.5f, -alturaR, colorC3[0], colorC3[1], colorC3[2]}, 
            {-0.5f, -0.5f, -alturaR, colorC3[0], colorC3[1], colorC3[2]}, 
            {-0.5f, -0.5f, -alturaR, colorC3[0], colorC3[1], colorC3[2]}, 
            {-0.5f, -0.5f,  alturaR, colorC3[0], colorC3[1], colorC3[2]},
            {-0.5f,  0.5f,  alturaR, colorC3[0], colorC3[1], colorC3[2]}, 

             {0.5f,  0.5f,  alturaR, colorC4[0], colorC4[1], colorC4[2]}, 
             {0.5f,  0.5f, -alturaR, colorC4[0], colorC4[1], colorC4[2]}, 
             {0.5f, -0.5f, -alturaR, colorC4[0], colorC4[1], colorC4[2]}, 
             {0.5f, -0.5f, -alturaR, colorC4[0], colorC4[1], colorC4[2]}, 
             {0.5f, -0.5f,  alturaR, colorC4[0], colorC4[1], colorC4[2]},
             {0.5f,  0.5f,  alturaR, colorC4[0], colorC4[1], colorC4[2]},

            {-0.5f, -0.5f, -alturaR, colorC5[0], colorC5[1], colorC5[2]}, 
            { 0.5f, -0.5f, -alturaR, colorC5[0], colorC5[1], colorC5[2]}, 
            { 0.5f, -0.5f,  alturaR, colorC5[0], colorC5[1], colorC5[2]}, 
            { 0.5f, -0.5f,  alturaR, colorC5[0], colorC5[1], colorC5[2]}, 
            {-0.5f, -0.5f,  alturaR, colorC5[0], colorC5[1], colorC5[2]}, 
            {-0.5f, -0.5f, -alturaR, colorC5[0], colorC5[1], colorC5[2]},

            {-0.5f,  0.5f, -alturaR, colorC6[0], colorC6[1], colorC6[2]}, 
            { 0.5f,  0.5f, -alturaR, colorC6[0], colorC6[1], colorC6[2]}, 
            { 0.5f,  0.5f,  alturaR, colorC6[0], colorC6[1], colorC6[2]}, 
            { 0.5f,  0.5f,  alturaR, colorC6[0], colorC6[1], colorC6[2]}, 
            {-0.5f,  0.5f,  alturaR, colorC6[0], colorC6[1], colorC6[2]}, 
            {-0.5f,  0.5f, -alturaR, colorC6[0], colorC6[1], colorC6[2]} 
        };


        uint[] indices = {
            0, 1, 3,
            1, 2, 3
        };

        // Periodo de refresco de modelo 3D
        System.Timers.Timer t = new System.Timers.Timer(16);

        #endregion

        Shaders shader;
        int VertexBufferObject, ElementBufferObject;
        double timeValue = 0.0;
        Camera camera;
        bool Lapse = false;
        Matrix4 model, rotX, rotY, rotZ;
        

        public CargaPrimaria()
        {
            InitializeComponent();
            // Evento de acuerdo al periodo de renderizado.
            t.Elapsed += OnRender;
        }


        private void OnRender(object sender, ElapsedEventArgs e)
        {
            // Función de renderizado llamada cada 16 ms

            Invoke(new MethodInvoker(() =>
            {
                // Se limpia el trazado de color anterior.
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                // Se suma el tiempo 16 ms.
                timeValue += 0.16;

                rotX = Matrix4.CreateRotationX((float)MathHelper.DegreesToRadians(timeValue * 10));
                rotY = Matrix4.CreateRotationY((float)MathHelper.DegreesToRadians(timeValue * 5));
                rotZ = Matrix4.CreateRotationZ((float)MathHelper.DegreesToRadians(timeValue * 2.5));

                model = rotX * rotY * rotZ;

                GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "model"), true, ref model);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 36);

                glControlPrimary.SwapBuffers();

            }));


        }

        private void CargaPrimaria_Load(object sender, EventArgs e)
        {


        }


        private void glControlPrimary_Resize(object sender, EventArgs e)
        {

            GL.Viewport(0, 0, glControlPrimary.Width, glControlPrimary.Height);
        }

        private void glControlPrimary_Load(object sender, EventArgs e)
        {
            // Usar contexto actual.
            glControlPrimary.MakeCurrent();
            

            // Color de fondo.
            Color backGroundColor = Color.White;
            GL.Enable(EnableCap.DepthTest);

            // Se colorea el fondo.
            GL.ClearColor((float)backGroundColor.R / 255.0f, (float)backGroundColor.G / 255.0f,
                (float)backGroundColor.B / 255.0f, (float)backGroundColor.A / 255.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

           

            // Se genera un buffer vertex y se combina con el buffer objetivo
            VertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.DynamicDraw);

            //Generate a element buffer 
            ElementBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ElementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.DynamicDraw);


            shader = new Shaders("shader.vert", "shader.frag");

           
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
            GL.EnableVertexAttribArray(1);
            shader.Use();

            //Rotación inicial en X.
            Matrix4 model = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(0f));
            

            camera = new Camera(new Vector3(0f,0f,2.5f), glControlPrimary.Width / (float)glControlPrimary.Height);

            const float anguloCamara = 0f;// * (3.14159f/180);

            camera.Yaw -= 10f;
            camera.Pitch += anguloCamara;
            camera.Position += Vector3.UnitY * 0.20f;
            camera.Position -= Vector3.UnitX * 0.05f;

            Matrix4 cameraView = camera.GetViewMatrix();
            Matrix4 cameraProjection = camera.GetProjectionMatrix();

            

            // Modelo 3D
            GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "model"), true, ref model);
            
            //GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, (IntPtr)0);
            GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "view"), true, ref cameraView);
            GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "projection"), true, ref cameraProjection);

            
            GL.DrawArrays(PrimitiveType.Triangles, 0, 36);
            glControlPrimary.SwapBuffers();
            t.Start();
            
        }

        private void CargaPrimaria_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            t.Stop();
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DeleteBuffer(VertexBufferObject);
            shader.Dispose();


        } 


    }
}
