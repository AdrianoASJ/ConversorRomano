using System;

namespace ConsoleApp2
{
    public class RomanosDoTDD
    {
       
        public RomanosDoTDD()
        {

        }

        public string NumeroIndoArabicos(int n)
        {
            string num = "";
            bool v = true;

            if (n == 0)
            {
                return "Este numero não existe";
            }

            while (true)
            {
                if (n > 999)
                {
                    
                    switch (n / 1000) //Milhar
                    {
                        case 1: num += "M"; break;
                        case 2: num += "MM"; break;
                        case 3: num += "MMM"; break;
                    }
                    
                    n -= 1000 * (n / 1000);
                }

                else if (n < 1000 && n > 99) //Centena
                {
                    string[] romanos = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
                    var auxcentenas = (n / 100) - 1;
                    num += romanos[auxcentenas];

                    n -= 100 * (n / 100);
                }

                else if (n < 100 && n > 9) //Dezena
                {
                    string[] romanos = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                    var auxdezenas = (n / 10) - 1;
                    num += romanos[auxdezenas];

                    n -= 10 * (n / 10);            
                }

                else if (n < 10 && n > 0) //Unidade
                {
                    string[] romanos = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
                    var auxunidades = n - 1;
                    num += romanos[auxunidades];

                    n -= n;
                    
                }
                else
                {
                    Console.Write("Este numero não existe");
                    v = false;
                    return num;
                }
                //-------------------------------------------------------------------------------------------------------

            }
        }

        public int NumeroRomano(string v)
        {
            {
                char[] numerosRomanos = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
                int[] comparadorDeNumeros = { 1, 5, 10, 50, 100, 500, 1000 };

                
                char[] charArray = v.ToCharArray();
                
                var valorFinal = 0;
                for (int i = 0; i < charArray.Length; i++)
                {
                    
                    for (int j = 0; j < numerosRomanos.Length; j++)
                    {
                        if (charArray[i] == numerosRomanos[j])
                        {
                            if (charArray[i] == 'C' && (i + 1 < charArray.Length))
                            {
                                if (charArray[i + 1] == 'M')
                                {
                                    valorFinal += comparadorDeNumeros[6] - comparadorDeNumeros[j];

                                    i++;
                                }
                                else if (charArray[i + 1] == 'D')
                                {
                                    valorFinal += comparadorDeNumeros[5] - comparadorDeNumeros[j];

                                    i++;
                                }
                                else
                                {
                                    valorFinal += comparadorDeNumeros[j];
                                    
                                }
                            }
                            else if (charArray[i] == 'X' && (i + 1 < charArray.Length))
                            {
                                if (charArray[i + 1] == 'L')
                                {
                                    valorFinal += comparadorDeNumeros[3] - comparadorDeNumeros[j];

                                    i++;
                                }
                                else if (charArray[i + 1] == 'C' && (i + 1 < charArray.Length))
                                {
                                    valorFinal += comparadorDeNumeros[4] - comparadorDeNumeros[j];

                                    i++;
                                }
                                else
                                {
                                    valorFinal += comparadorDeNumeros[j];

                                    

                                }
                            }
                            else if (charArray[i] == 'I' && (i + 1 < charArray.Length))
                            {
                                

                                if (charArray[i + 1] == 'V')
                                {
                                    valorFinal += comparadorDeNumeros[1] - comparadorDeNumeros[j];

                                    i++;
                                }
                                else if (charArray[i + 1] == 'X')
                                {
                                    valorFinal += comparadorDeNumeros[2] - comparadorDeNumeros[j];

                                    i++;
                                }
                                else
                                {
                                    valorFinal += comparadorDeNumeros[j];
                                    
                                }

                            }
                            else
                            {
                                valorFinal += comparadorDeNumeros[j];
                                
                            }
                            break;
                        }


                    }
                }

                return valorFinal;
            }
        }
    }
}