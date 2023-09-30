using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_1_1 {
    internal class Mathematical_operations{
        private static double num1, num2;//result=resultado
        private static string select_operation;

        public Mathematical_operations(double number1,double number2,string Select_operation) {
            num1=number1;
            num2=number2;
            select_operation=Select_operation;
        }

        public static string operation(){
            string result=null;
            switch(select_operation) {
                case "Sumar":
                    result="Suma: "+num1+" + "+num2+" = "+(Math.Round((num1+num2),2));
                break;

                case "Restar":
                    result="Resta: "+num1+" - "+num2+" = "+(Math.Round((num1-num2),2));
                break;

                case "Multiplicacion":
                    result="Multiplicacion: "+num1+" * "+num2+" = "+(Math.Round((num1*num2),2));
                break;
                
                case "Division":
                    result="Division: "+num1+" / "+num2+" = "+(Math.Round((num1/num2),2));
                break;
            }

            return result;
        }
    }
}
