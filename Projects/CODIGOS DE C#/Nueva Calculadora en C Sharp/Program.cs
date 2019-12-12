using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Nueva_Calculadora_en_C_Sharp
{
    class Program : Opciones
    {
        public static Estructura estructura = new Estructura();
        public static Errores errores = new Errores();
        public static Indicadores indicadores = new Indicadores();
        public static Opciones opciones = new Opciones();

        static void Main(string[] args)
        {
            do
            {
                estructura.Cuerpo();
                errores.IndiError();

                indicadores.Titulos();
                opciones.Opcion();
                
                Console.Clear();
                
            } while (salir == false);

        }
    }

    class Estructura
    {
        private int X;
        private int Y;

        public void Cuerpo()
        {
            Console.SetCursorPosition(2,2);
            Console.Write("╔");

            Console.SetCursorPosition(117, 2);
            Console.Write("╗");

            Console.SetCursorPosition(2, 28);
            Console.Write("╚");

            Console.SetCursorPosition(117, 28);
            Console.Write("╝");

            for (int i = 3; i <= 116; i++)
            {
                X = i;

                Y = 2;

                Console.SetCursorPosition(X, Y);
                Console.Write("═");

                Y = 28;
                Console.SetCursorPosition(X, Y);
                Console.Write("═");
            }
            for (int i = 3; i <= 27; i++)
            {
                Y = i;

                X = 2;

                Console.SetCursorPosition(X, Y);
                Console.Write("║");

                X = 117;
                Console.SetCursorPosition(X, Y);
                Console.Write("║");
            }
        }
    }

    class Indicadores
    {
        public void Titulos()
        {
            Console.SetCursorPosition(50, 1);
            Console.Write("CALCULADORA DE INDICE");

            Console.SetCursorPosition(87, 4);
            Console.Write("INDICADOR DE ERRORES");

            Console.SetCursorPosition(3, 3);
            Console.Write("SI DESEA SALIR DEL PROGRAMA INGRESE (0) MATERIAS");
 
        }
        public void Titulos2()
        {
            Console.SetCursorPosition(3, 3);
            Console.Write("YA NO PODRA SALIR DEL PROGRAMA INGRESANDO (0)   ");
        }
    }

    class Opciones
    {
        public static bool salir = false;
        public int opcion;

        Errores errores = new Errores();
        Limpiador limpiador = new Limpiador();

        public void Opcion()
        {
            Indicadores indicadores = new Indicadores();
            Calculadora calculadora = new Calculadora();

            do
            {
                limpiador.Limpiar();
                Console.SetCursorPosition(3,6);
                Console.Write("Cantidad De Materias Seleccionadas >>> ");

                try
                {
                    calculadora.MATERIAS();

                    if (calculadora.materias > 7)
                    {
                        errores.IndiError2();
                    }
                    if (calculadora.materias < 0)
                    {
                        errores.IndiError3();
                    }
                }
                catch (Exception)
                {
                    calculadora.materias = 8;
                    errores.IndiError6();
                }

            } while ((calculadora.materias < 0) || (calculadora.materias > 7));

            if (calculadora.materias == 0)
            {
                salir = true;
            }

            if ((calculadora.materias > 0) && (calculadora.materias < 8))
            {   
                indicadores.Titulos2();
                calculadora.calcular();
            }
        }
        public void opcion2()
        {
            do
            {
                Console.SetCursorPosition(5, 27);
                Console.Write("Si desea salir del programa ingrese (0), si desea calcular otro indice ingrese (1): ");
                try
                {
                    opcion = Convert.ToInt16(Console.ReadLine());
                    limpiador.Limpiador5();

                    if (((opcion < 0) || (opcion > 1)))
                    {
                        errores.IndiError7();
                    }
                }
                catch (Exception)
                {
                    opcion = 2;
                    limpiador.Limpiador5();
                    errores.IndiError6();
                }

            } while ((opcion < 0) || (opcion > 1));

            if (opcion == 0)
            {
                salir = true;
            }
        }
    }

     class Calculadora : Opciones
    {
        Limpiador limpiador = new Limpiador();
        Opciones opciones = new Opciones();
        Errores errores = new Errores();
        NotaLiteral notaliteral = new NotaLiteral();

        public int[] nota;
        public int[] creditos;

        private int totalc, totaln;
        private int[] total;
        private double[] indice;

        public int materias;
        public void calcular()
        {
            nota = new int[materias];
            creditos = new int[materias];

            limpiador.Limpiar2();

            for (int i = 0; i <= materias-1; i++)
            {
                do
                {
                    try
                    {
                        Console.SetCursorPosition(3, limpiador.Y);
                        Console.Write("Ingrese La Nota " + (i + 1) + " >>> ");
                        nota[i] = Convert.ToInt32(Console.ReadLine());

                        if ((nota[i] < 0) || (nota[i] > 100))
                        {
                            limpiador.Limpiar3();
                            errores.IndiError4();
                            
                        }    
                    }
                    catch(Exception)
                    {
                        limpiador.Limpiar3();
                        errores.IndiError6();
                    }

                } while ((nota[i] < 0) || (nota[i] > 100));

                do
                {
                    try
                    {
                        Console.SetCursorPosition(35, limpiador.Y);
                        Console.Write("Ingrese Los Creditos  >>> ");
                        creditos[i] = Convert.ToInt32(Console.ReadLine());

                        if ((creditos[i] < 2) || (creditos[i] > 4))
                        {
                            limpiador.Limpiar4();
                            errores.IndiError5();
                        }
                    }
                    catch(Exception)
                    {
                        limpiador.Limpiar4();
                        errores.IndiError6();
                    }

                } while ((creditos[i] < 2) || (creditos[i] > 4));

                limpiador.Y++;
            }

            total = new int[materias];
            indice = new double[2];

            for(int i = 0; i <= materias-1; i++)
            {
                total[i] = creditos[i] * nota[i];
            }

            
           if(materias == 1)
            {
                totaln = total[0];
            }
            else
            {
                if (materias == 2)
                {
                    totaln = total[0] + total[1];
                }
                else
                {
                    if (materias == 3)
                    {
                        totaln = total[0] + total[1] + total[2];
                    }
                    else
                    {
                        if (materias == 4)
                        {
                            totaln = total[0] + total[1] + total[2] + total[3];
                        }
                        else
                        {
                            if (materias == 5)
                            {
                                totaln = total[0] + total[1] + total[2] + total[3] + total[4];
                            }
                            else
                            {
                                if (materias == 6)
                                {
                                    totaln = total[0] + total[1] + total[2] + total[3] + total[4] + total[5];
                                }
                                else
                                {
                                    if (materias == 7)
                                    {
                                        totaln = total[0] + total[1] + total[2] + total[3] + total[4] + total[5] + total[6];
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (materias == 1)
            {
                totalc = creditos[0];
            }
            else
            {
                if (materias == 2)
                {
                    totalc = creditos[0] + creditos[1];
                }
                else
                {
                    if (materias == 3)
                    {
                        totalc = creditos[0] + creditos[1] + creditos[2];
                    }
                    else
                    {
                        if (materias == 4)
                        {
                            totalc = creditos[0] + creditos[1] + creditos[2] + creditos[3];
                        }
                        else
                        {
                            if (materias == 5)
                            {
                                totalc = creditos[0] + creditos[1] + creditos[2] + creditos[3] + creditos[4];
                            }
                            else
                            {
                                if (materias == 6)
                                {
                                    totalc = creditos[0] + creditos[1] + creditos[2] + creditos[3] + creditos[4] + creditos[5];
                                }
                                else
                                {
                                    if (materias == 7)
                                    {
                                        totalc = creditos[0] + creditos[1] + creditos[2] + creditos[3] + creditos[4] + creditos[5] + creditos[6];
                                    }
                                }
                            }
                        }
                    }
                }
            }

            indice[0] = totaln / totalc;
            indice[1] = indice[0] * 4 / 100;

            Console.SetCursorPosition(5, 24);
            Console.Write("Su Indice Academico Es: " + indice[1]);

            for (int i = 0; i <= materias-1; i++)
            {
                if (nota[i] <= 59)
                {
                    notaliteral.LITERAL1();
                }
                else
                {
                    if (nota[i] <= 69)
                    {
                        notaliteral.LITERAL2();
                    }
                    else
                    {
                        if (nota[i] <= 79)
                        {
                            notaliteral.LITERAL3();
                        }
                        else
                        {
                            if (nota[i] <= 89)
                            {
                                notaliteral.LITERAL4();
                            }
                            else
                            {
                                if ((nota[i] <= 100) && (nota[i] >= 90))
                                {
                                    notaliteral.LITERAL5();
                                }
                            }
                        }
                    }
                }

            }

            opciones.opcion2();

        }
        public void MATERIAS()
        {
            materias = Convert.ToInt16(Console.ReadLine()); 
        }
    }

    class Errores
    {
        Limpiador limpiador = new Limpiador();
        public int X, Y, Y2 = 6;

        public void IndiError()
        {
            Console.SetCursorPosition(79, 5);
            Console.Write("╔");

            Console.SetCursorPosition(115, 5);
            Console.Write("╗");

            Console.SetCursorPosition(79, 20);
            Console.Write("╚");

            Console.SetCursorPosition(115, 20);
            Console.Write("╝");

            for (int i = 80; i <= 114; i++)
            {
                X = i;

                Y = 5;

                Console.SetCursorPosition(X, Y);
                Console.Write("═");

                Y = 20;
                Console.SetCursorPosition(X, Y);
                Console.Write("═");
            }
            for (int i = 6; i <= 19; i++)
            {
                Y = i;

                X = 79;

                Console.SetCursorPosition(X, Y);
                Console.Write("║");

                X = 115;
                Console.SetCursorPosition(X, Y);
                Console.Write("║");
            }
        }

        public void IndiError2()
        {
            Console.SetCursorPosition(81, Y2);
            Console.Write("*Limite es de 7 Materias*");
            Y2++;

            if (Y2 >= 19)
            {
                for (int i = 6; i <= 19; i++)
                {
                    Console.SetCursorPosition(81, i);
                    Console.Write("                                  ");
                }
                Y2 = 6;
            }
        }
        public void IndiError3()
        {
            Console.SetCursorPosition(81, Y2);
            Console.Write("*No Negativo de Materias*");
            Y2++;

            if (Y2 >= 19)
            {
                for (int i = 6; i <= 19; i++)
                {
                    Console.SetCursorPosition(81, i);
                    Console.Write("                                  ");
                }
                Y2 = 6;
            }
        }
        public void IndiError4()
        {
            Console.SetCursorPosition(81, Y2);
            Console.Write("*El limite de notas es de 0 a 100*");
            Y2++;

            if (Y2 >= 19)
            {
                for (int i = 6; i <= 19; i++)
                {
                    Console.SetCursorPosition(81, i);
                    Console.Write("                                  ");
                }
                Y2 = 6;
            }
        }
        public void IndiError5()
        {
            Console.SetCursorPosition(81, Y2);
            Console.Write("*Limite de creditos es de 2 a 4*");
            Y2++;

            if (Y2 >= 19)
            {
                for (int i = 6; i <= 19; i++)
                {
                    Console.SetCursorPosition(81, i);
                    Console.Write("                                  ");
                }
                Y2 = 6;
            }
        }
        public void IndiError6()
        {
            Console.SetCursorPosition(81, Y2);
            Console.Write("*Error Alfanumericos o Caracteres*");
            Y2++;

            if (Y2 >= 19)
            {
                for (int i = 6; i <= 19; i++)
                {
                    Console.SetCursorPosition(81, i);
                    Console.Write("                                  ");
                }
                Y2 = 6;
            }

            Opciones.salir = false;
        }
        public void IndiError7()
        {
            Console.SetCursorPosition(81, Y2);
            Console.Write("*Ingrese la Opcion Correcta*");
            Y2++;

            if (Y2 >= 19)
            {
                for (int i = 6; i <= 19; i++)
                {
                    Console.SetCursorPosition(81, i);
                    Console.Write("                                  ");
                }
                Y2 = 6;
            }
        }

    }

    class Historial { }

    class Limpiador
    {
        public int Y = 6;

        public void Limpiar() // Para limpiar la peticion de materias
        {
            Console.SetCursorPosition(42, 6);
            Console.Write("     ");

        }
        public void Limpiar2() // Para la linea de cantidad materias
        {
            Console.SetCursorPosition(20, 6);
            Console.Write("                         ");
        }
        public void Limpiar3() // Para la linea de materias
        {
            Console.SetCursorPosition(20, Y);
            Console.Write("           ");
        }
        public void Limpiar4() // Para la linea de creditos
        {
            Console.SetCursorPosition(50, Y);
            Console.Write("              ");
        }
        public void Limpiador5() //Para la linea de opciones final
        {
            Console.SetCursorPosition(88, 27);
            Console.Write("           ");
        }
        
    }

    class NotaLiteral
    {
        public char[] literal = {'A', 'B', 'C', 'D', 'F'};
        
        public int X3 = 79, Y3= 22, N = 1;

        public void LITERAL1()
        {
            Console.SetCursorPosition(X3, Y3);
            Console.Write("(" + N + ")" + " Usted Obtuvo " + literal[4]);
            Y3++;
            N++;

            if(Y3 >= 26)
            {
                Y3 = 22;
                X3 = 99;
            }
        }
        public void LITERAL2()
        {
            Console.SetCursorPosition(X3, Y3);
            Console.Write("(" +N +")" + " Usted Obtuvo " + literal[3]);
            Y3++;
            N++;

            if (Y3 >= 26)
            {
                Y3 = 22;
                X3 = 99;
            }
        }
        public void LITERAL3()
        {
            Console.SetCursorPosition(X3, Y3);
            Console.Write("(" + N + ")" + " Usted Obtuvo " + literal[2]);
            Y3++;
            N++;

            if (Y3 >= 26)
            {
                Y3 = 22;
                X3 = 99;
            }
        }
        public void LITERAL4()
        {
            Console.SetCursorPosition(X3, Y3);
            Console.Write("(" + N + ")" + " Usted Obtuvo " + literal[1]);
            Y3++;
            N++;

            if (Y3 >= 26)
            {
                Y3 = 22;
                X3 = 99;
            }
        }
        public void LITERAL5()
        {
            Console.SetCursorPosition(X3, Y3);
            Console.Write("(" + N + ")" + " Usted Obtuvo " + literal[0]);
            Y3++;
            N++;

            if (Y3 >= 26)
            {
                Y3 = 22;
                X3 = 99;
            }
        }
    }
}
