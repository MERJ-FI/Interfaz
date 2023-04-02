using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using OpenTK;
//using OpenTK.Graphics.ES11;
using OpenTK.Graphics.ES30;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace Cansat_HMI
{
    public partial class CargaPrimaria : Form
    {
        static readonly Stopwatch timer = new Stopwatch();
        Shaders shader;
        bool bLoaded;
        float[] vertices = {
            -0.5f, -0.5f, -0.5f, 
             0.5f, -0.5f, -0.5f,  
             0.5f,  0.5f, -0.5f,  
             0.5f,  0.5f, -0.5f,  
            -0.5f,  0.5f, -0.5f,  
            -0.5f, -0.5f, -0.5f,  
                                  
            -0.5f, -0.5f,  0.5f,  
             0.5f, -0.5f,  0.5f,  
             0.5f,  0.5f,  0.5f,  
             0.5f,  0.5f,  0.5f,  
            -0.5f,  0.5f,  0.5f,  
            -0.5f, -0.5f,  0.5f,  
                                  
            -0.5f,  0.5f,  0.5f,  
            -0.5f,  0.5f, -0.5f,  
            -0.5f, -0.5f, -0.5f,  
            -0.5f, -0.5f, -0.5f,  
            -0.5f, -0.5f,  0.5f,  
            -0.5f,  0.5f,  0.5f,  
                                  
             0.5f,  0.5f,  0.5f,  
             0.5f,  0.5f, -0.5f,  
             0.5f, -0.5f, -0.5f,  
             0.5f, -0.5f, -0.5f,  
             0.5f, -0.5f,  0.5f,  
             0.5f,  0.5f,  0.5f,  
                                  
            -0.5f, -0.5f, -0.5f,  
             0.5f, -0.5f, -0.5f,  
             0.5f, -0.5f,  0.5f,  
             0.5f, -0.5f,  0.5f,  
            -0.5f, -0.5f,  0.5f,  
            -0.5f, -0.5f, -0.5f,  
                                  
            -0.5f,  0.5f, -0.5f,  
             0.5f,  0.5f, -0.5f,  
             0.5f,  0.5f,  0.5f,  
             0.5f,  0.5f,  0.5f,  
            -0.5f,  0.5f,  0.5f,  
            -0.5f,  0.5f, -0.5f  
        };
        uint[] indices = {  // note that we start from 0!
            0, 1, 3,   // first triangle
            1, 2, 3    // second triangle
        };


        int VertexBufferObject;
        int ElementBufferObject;
        int VertexArrayObject;
        System.Timers.Timer t = new System.Timers.Timer(16);
        double timeValue = 0.0;

        private static uint vertexBufferHandle, shaderProgramHandle, vertexArrayHandle;

        public CargaPrimaria()
        {
            InitializeComponent();
           
            //Suscribo el timer al evento elapsed. 
            t.Elapsed += OnRender;
            //Lo inicio.
            
            


        }

        private void OnRender(object sender, ElapsedEventArgs e)
        {
            //glControlPrimary.Invalidate();

            Invoke(new MethodInvoker(() =>
            {
                GL.Clear(ClearBufferMask.ColorBufferBit);


                timeValue += 1.6;
                //Matrix4 rotation = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians((float)timeValue));
                //Matrix4 scale = Matrix4.CreateScale(0.5f, 0.5f, 0.5f);
                //Matrix4 trans = rotation * scale;

                //int location = GL.GetUniformLocation(shader.Handle, "transform");

                //GL.UniformMatrix4(location, true, ref trans);
                //

                Matrix4 model = Matrix4.CreateRotationX((float)MathHelper.DegreesToRadians(timeValue));
                GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "model"), true, ref model);

                GL.DrawArrays(PrimitiveType.Triangles, 0, 36);
                //shader.Use();

                //// update the uniform color
                //timeValue += 0.16;
                //float greenValue = (float)Math.Sin(timeValue) / 2.0f + 0.5f;
                //int vertexColorLocation = GL.GetUniformLocation(shader.Handle, "ourColor");
                //GL.Uniform4(vertexColorLocation, 0.0f, greenValue, 0.0f, 1.0f);

                ////GL.BindVertexArray(VertexArrayObject);
                //GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, (IntPtr)0);
                glControlPrimary.SwapBuffers();

            }));
            

            

        }



        private void CargaPrimaria_Load(object sender, EventArgs e)
        {
            

        }


        private void glControlPrimary_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            

        }

        private void glControlPrimary_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, glControlPrimary.Width, glControlPrimary.Height);
        }

        private void glControlPrimary_Load(object sender, EventArgs e)
        {
            glControlPrimary.MakeCurrent();
            Color backGroundColor = Color.WhiteSmoke;

            //glControlPrimary.MakeCurrent();
            GL.ClearColor((float)backGroundColor.R / 255.0f, (float)backGroundColor.G / 255.0f,
                (float)backGroundColor.B / 255.0f, (float)backGroundColor.A / 255.0f);
            GL.Clear((ClearBufferMask.ColorBufferBit));

            //Generate a vertex buffer 
            VertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            //Generate a element buffer 
            ElementBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ElementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StaticDraw);

            shader = new Shaders("shader.vert", "shader.frag");

            GL.VertexAttribPointer(shader.GetAttribLocation("aPosition"), 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(shader.GetAttribLocation("aPosition"));

            shader.Use();

            /*
            VertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(VertexArrayObject);
            // 2. copy our vertices array in a buffer for OpenGL to use
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ElementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
            // 3. then set our vertex attributes pointers
            GL.VertexAttribPointer(shader.GetAttribLocation("aPosition"), 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(shader.GetAttribLocation("aPosition"));

            */

            //GL.DrawArrays(PrimitiveType.Triangles, 0, 3);}
            //Matrix4 rotation = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(72.0f));
            //Matrix4 scale = Matrix4.CreateScale(0.5f, 0.5f, 0.5f);
            //Matrix4 trans = rotation * scale;

            Matrix4 model = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-55.0f));
            Matrix4 view = Matrix4.CreateTranslation(0.0f, 0.0f, -3.0f); 
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), Width / Height, 0.1f, 100.0f);

            
            GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "model"), true, ref model);
            GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "view"), true, ref view);
            GL.UniformMatrix4(GL.GetUniformLocation(shader.Handle, "projection"), true, ref projection);


            //int location = GL.GetUniformLocation(shader.Handle, "transform");

            //GL.UniformMatrix4(location, true, ref trans);

            //GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, (IntPtr)0);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 36);
            glControlPrimary.SwapBuffers();
            t.Start();

        }

        private void CargaPrimaria_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            timer.Stop();
            t.Stop();
            //No buffer asociated
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //Delete the vertex buffer object
            GL.DeleteBuffer(VertexBufferObject);
            shader.Dispose();
        }




    }
}
