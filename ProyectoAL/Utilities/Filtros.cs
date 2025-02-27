﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAL.Utilities
{
    public class Filtros
    {
        public double[,] m1 = { //matriz de prueba
                                    { 10, 42, 55, 89},
                                    { 11, 10, 01, 80},
                                    { 45, 10, 01, 11},
                                    { 11, 01, 11, 10}};

        //DIFUMINADO
        public double[,] Difuminado = { //matriz de prueba
                                    { 0.0625, 0.125, 0.0625},
                                    { 0.125, 0.25, 0.125},
                                    { 0.0625, 0.125, 0.0625}};

        //REALZAR
        public double[,] Realzar = { //matriz de prueba
                                    { -2, -1, 0},
                                    { -1, 1, 1},
                                    { 0, 1, 2}};

        //SOBEL INFERIOR
        public double[,] SobelInf = { //matriz de prueba
                                    { -1, -2, -1 },
                                    { 0, 0, 0},
                                    { 1, 2, 1}};

        //SOBEL SUPERIOR
        public double[,] SobelSup = { //matriz de prueba
                                    { 1, 2, 1 },
                                    { 0, 0, 0},
                                    { -1, -2, -1}};

        //SOBEL IZQUIERDO
        public double[,] SobelIzq = { //matriz de prueba
                                    { 1, 0, -1 },
                                    { 2, 0, -2},
                                    { 1, 0, -1}};

        //SOBEL DERECHO
        public double[,] SobelDer = { //matriz de prueba
                                    { -1, 0, 1 },
                                    { -2, 0, 2},
                                    { -1, 0, 1}};

        //CONTORNO
        public double[,] Contorno = { //matriz de prueba
                                    { -1, -1, -1},
                                    { -1, 8, -1},
                                    { -1, -1, -1}};

        //AFILAR
        public double[,] Afilar = { //matriz de prueba
                                    { 0, -1, 0},
                                    { -1, 5, -1},
                                    { 0, -1, 0}};

        //ORIGINAL
        public double[,] Original = { //matriz de prueba
                                    { 0, 0, 0},
                                    { 0, 1, 0},
                                    { 0, 0, 0}};
        
        //PERSONALIZADO
        public double[,] Personalizado()
        {
            double[,] per = { //matriz de prueba
                                         { 0, 0, 0},
                                         { 0, 0, 0},
                                         { 0, 0, 0}};
            return per;
        }
        public double[,] Personalizado(double n1, double n2, double n3, double n4, double n5, double n6, double n7, double n8, double n9)
        {
            double[,] per = { //matriz de prueba
                                         { n1, n2, n3},
                                         { n4, n5, n6},
                                         { n7, n8, n9}};
            return per;
        }
    }
}
