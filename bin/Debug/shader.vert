#version 330 core
layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec3 aColor;
in vec2 aTexCoord;
out vec3 vertexColor;


out vec2 TexCoord;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    gl_Position = vec4(aPosition, 1.0) * model * view * projection;
    vertexColor = aColor;
    TexCoord = vec2(aTexCoord.x, aTexCoord.y);
}
