using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAL.Utilities
{
    class Matrices
    {
        public byte[,] ImageTo2DByteArray(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            byte[] bytes = new byte[height * data.Stride];
            try
            {
                Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);
            }
            finally
            {
                bmp.UnlockBits(data);
            }

            byte[,] result = new byte[height, width];
            for (int y = 0; y < height; ++y)
                for (int x = 0; x < width; ++x)
                {
                    int offset = y * data.Stride + x * 3;
                    result[y, x] = (byte)((bytes[offset + 0] + bytes[offset + 1] + bytes[offset + 2]) / 3);
                }
            return result;
        }
        public Bitmap GrayScaleFilter(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = image.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }

        //ESTOS 3 METODOS PARA IMPRIMIR SOLO FUERON UTILIZADOS PARA PRUEBAS DURANTE EL DESARROLLO
        public void Imprimir(string[,] mat)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Imprimir(int[,] mat)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Imprimir(double[,] mat)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }


        double[,] SubMatriz(double[,] Entrada, int fila, int columna) //Creación de una matriz de 3*3 en base al valor obtenido actual
        {
            double[,] Salida =  {
                                    { Entrada[fila-1,columna-1], Entrada[fila-1,columna], Entrada[fila-1,columna+1]},
                                    { Entrada[fila,columna-1], Entrada[fila,columna], Entrada[fila,columna+1]},
                                    { Entrada[fila+1,columna-1], Entrada[fila+1,columna], Entrada[fila+1,columna+1]}};
            return Salida;
        }
        public int[,] AplicarFiltro(double[,] Original, double[,] filtro) //AQUÍ SE MANIPULA TODA LA IMAGEN
        {
            int[,] Salida = new int[Original.GetLength(0), Original.GetLength(1)];

            for (int i = 0; i < Original.GetLength(0); i++)
            {
                for (int j = 0; j < Original.GetLength(1); j++)
                {
                    if (j == 0 || i == 0 || (j == Original.GetLength(1) - 1) || (i == Original.GetLength(0) - 1)) //ESTO SUCEDE PARA CORREGIR LOS BORDES (no se les asignará filtro y se copiará tal cual la imagen original)
                    {
                        Salida[i, j] = Convert.ToInt32(Original[i, j]);
                    }
                    else //(Aqui ya se aplicarán los filtros)
                    {
                        var matrizMenor = SubMatriz(Original, i, j); //SE SACA UNA MATRIZ PEQUEÑA CON SOLO LOS VALORES DEL INDICE A OPERAR

                        //APLICACIÓN DEL FILTRO:
                        Salida[i, j] = Convert.ToInt32(NuevoValor(matrizMenor, filtro));
                    }
                }
            }
            return Salida;
        }
        double NuevoValor(double[,] Submatriz, double[,] filtro) //SE USA PARA CALCULAR EL VALOR NUEVO OBTENIDO POR EL FILTRO
        {
            double resultado = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double ResultadoParcial = Submatriz[i, j] * filtro[i, j]; //Se almacena solo el resultado de multiplicar el valor de la original[i,j] * filtro[i,j]
                    resultado += ResultadoParcial; //Resultado acumulativo que se devolverá al final 
                }
            }
            return resultado;
        }

        public int[,] Reescalamiento(int[,] matriz) //ESTE SE HACE SI Y SOLO SI HAY UN VALOR MAYOR A 255
        {
            int mayor = MaxMatriz(matriz);
            int menor = MinMatriz(matriz);
            int rango = mayor - menor; //rango a usar posteriormente para reescalar la matriz
            double factor = 255.00 / (double)rango;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    double nuevoValor = (double)matriz[i, j] * factor;
                    matriz[i, j] = Convert.ToInt32(nuevoValor); //se agrega el reescalado
                }
            }
            return matriz;
        }
        public int MaxMatriz(int[,] m) //Valor máximo en la matriz
        {
            int max = m[0, 0];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (max < m[i, j])
                    {
                        max = m[i, j];
                    }
                }
            }
            return max;
        }
        int MinMatriz(int[,] m) //valor mínimo en la matriz
        {
            int max = m[0, 0];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (max > m[i, j])
                    {
                        max = m[i, j];
                    }
                }
            }
            return max;
        }
    }
    
}
