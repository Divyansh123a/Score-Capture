using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score            //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)   //DO NOT CHANGE 'Main' Signature
        {
            //Implement code her
            string [] str = new string[6];
            for(int i=0; i<6; i++)
            {
                Console.WriteLine("Player name : ");
                str[i] = Console.ReadLine();
            }
            int t=0, d=0, b=0;
            
            for(int i=0; i<6; i++)
            {
                if(str[i] == "Bill")
                {
                    b++;
                    if(str[i] == str[i+1]){
                        b=b + 2;
                        i++;
                    }
                }
                if(str[i] == "Tommy"){
                    t++;
                    if(str[i]==str[i+1]){
                        t= t + 2;
                        i++;
                    }
                }
                if(str[i]== "Daisy"){
                    d++;
                    if(str[i]==str[i+1]){
                        d = d + 2;
                        i++;
                    }
                }
            }
            Console.WriteLine("Bill Score : {0}" , b);
            Console.WriteLine("Tommy Score : {0}" , t);
            Console.WriteLine("Daisy Score : {0}" , d);
        }
    }
}
