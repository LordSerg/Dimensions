# Technology used
C#, WindowsForms, Bitmap, math

# Overview
In program I realised every n-dimensional cube rotation from n=2 to n=6

# About project
This project is a result of my study in matrices.
In the first place there was an idea that **any object of n-D space (where n ∈ ℕ) can be rotated with a special matrix sized n×n.**

Number of matrices of rotation depends on **n**.

for n = 2 number of matrices = 1

for n = 3 number of matrices = 3

for n = 4 number of matrices = 6

And so on... in general for any **n** number of needed matrices **k** to rotate n-dimensional space equals:

$$k = {n*(n-1) \over 2}$$

Multiplying rotation matrices between each other results matrix of combined rotation

## Examples

### 2D rotation
![2D Rotation example](animations/2d.gif)

### 3D rotation
![3D Rotation example](animations/3d.gif)

### 4D rotation
![4D Rotation example](animations/4d.gif)

### 5D rotation
![5D Rotation example](animations/5d.gif)

### 6D rotation
![6D Rotation example](animations/6d.gif)


## Math explanation
### for 2D space the matrix looks like this:

$$
\left( \begin{matrix}
cos(α) & -sin(α) \\
sin(α) & cos(α) \\
\end{matrix} \right)
$$

### for 3D space the matrices look like this:

> $$
X = \left( \begin{matrix}
1 & 0 & 0 \\
0 & cos(α) & -sin(α) \\
0 & sin(α) & cos(α) \\
\end{matrix} \right)
$$

> $$
Y = \left( \begin{matrix}
cos(α) & 0 & sin(α) \\
0 & 1 & 0 \\
-sin(α) & 0 & cos(α) \\
\end{matrix} \right)
$$

> $$
Z = \left( \begin{matrix}
cos(α) & -sin(α) & 0 \\
sin(α) & cos(α) & 0 \\
0 & 0 & 1 \\
\end{matrix} \right)
$$

### For rotating
Any object (cube, for example) can be rotated using these matices.

For rotating any object in nD-space you just have to represent every point of object as a vector and then **multiply a matrix by vector**:

to rotate 3D point p 

> $$
p = \left( \begin{matrix}
1 \\
2 \\
1 \\
\end{matrix} \right)
$$

around **X** axes by 30° we have to:

> $$
\begin{align}
p\' & = \left( \begin{matrix}
1 & 0 & 0 \\
0 & cos(30) & -sin(30) \\
0 & sin(30) & cos(30) \\
\end{matrix} \right) & * \left( \begin{matrix}
1 \\
2 \\
1 \\
\end{matrix} \right) \\
 & = \left( \begin{matrix}
1 & 0 & 0 \\
0 & {\sqrt{3} \over 2} & -{1 \over 2} \\
0 & {1 \over 2} & {\sqrt{3} \over 2} \\
\end{matrix} \right) & * \left( \begin{matrix}
1 \\
2 \\
1 \\
\end{matrix} \right) \\
 & = \left( \begin{matrix}
1 + 0 + 0 \\
0 + {{\sqrt{3}*2} \over 2} - {1 \over 2} \\
0 + {2 \over 2} + {\sqrt{3} \over 2} \\
\end{matrix} \right) \\
 & = \left( \begin{matrix}
1\\
\sqrt{3} - {1 \over 2} \\
1 + {\sqrt{3} \over 2} \\
\end{matrix} \right) \\
 & \approx \left( \begin{matrix}
1\\
1.232 \\
1.866 \\
\end{matrix} \right)
\end{align}
$$

