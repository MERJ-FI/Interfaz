#version 330 core
in vec3 aPosition;
in vec2 aTexCoord;
out vec4 vertexColor;

out vec2 TexCoord;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    gl_Position = vec4(aPosition, 1.0) * model * view * projection;
    vertexColor = vec4(0.6f, 0.8f, 0.72f, 1.0f);
    TexCoord = vec2(aTexCoord.x, aTexCoord.y);
}
