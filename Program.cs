using System;

namespace Calculatorinsharp 
{
    class Program 
    {
        public static char? opp = null;
        //nullables are required as a character variable is not allowed to be null
        //we make this global to operate upon it in multiple methods 
        public static void Main(string[] args)
        {
            //this will be passed onto the onclick method as the looping constraint 
            string arr = "";
            string arr2 = "";
            // 1 -> 9 -> + -> 2 -> 1 -> = -> end of operation 
            
            //work out . <- check
            // work out negatives <- check
            // 1 - > 9 -> + -> 2 -> - -> 2 -> = -> eop work out this edge case   <- recall second method within itself after calling the the operator functions


            // clearing the first array or second array operations <- c char will change array value to zero update and set arry to zero and operators to null 
            //instantiate the void method within another class project in order  <- 
            //if operator is entered with empty array return zero <- 
            
            Console.WriteLine("Enter in number 1 to end specify operator (/*+-) or submit an empty line: ");
            arr  = onClickUpdate(arr, arr2, opp); 
            Console.WriteLine("array1 : " +arr);
            //Operation assignment  
            while (opp != '-' ||opp != '+' ||opp != '*' ||opp != '/') {
                if(opp == '-' ||opp == '+' ||opp == '*' ||opp == '/') {break;}
                Console.WriteLine("Please Enter an operator  (/*+-): " );
                string b = Console.ReadLine(); 
                if(b == "+") { 
                    opp = '+';
                    break;
                } 
                else if (b == "-") {
                    opp = '-';
                    break;
                }
                else if (b == "*") {
                    opp = '*';
                    break;
                }
                else if (b == "/") {
                    opp = '/';
                    break;
                }
                else {
                Console.WriteLine("This is not a valid number or operation, please enter a operator");
                }
            }
            Console.WriteLine("Selected Operation (/*+-): " + opp);
            Console.WriteLine("Enter in number 2 hit enter to finish calculation: ");
            arr2 = onClickUpdate(arr,arr2,opp);  
            if(opp == '+'){ adda(arr,arr2);}
            if(opp == '-'){ suba(arr,arr2);}
            if(opp == '/'){ diva(arr,arr2);}
            if(opp == '*'){ multa(arr,arr2);}
        }
        
           //we click  button 9 -> 
           // 1. this sends command " " which onclick checks for instead of operator 
           // 2. then calls opp = converttochar(value);   

public static string onClickUpdate(string arr, string arr2, char? operators){ 
    String b; 
            //This needs to loop again if another operator is selected 
            //string two creator
        while (operators == '-' ||operators == '+' ||operators == '/' ||operators == '*') {
            
            b = Console.ReadLine(); 
            double num = 0;
                
            bool canConvert = double.TryParse(b, out num);
                if (canConvert == true){
                    arr2 = arr2+num; 
                }else {
                //within this add a operator check to recall onclick
                    /*if 
                    (b == "+"||b == "-"||b == "/"||b == "*" ) {
                        Console.WriteLine("we're looping");
                        double passer = Convert.ToDouble(arr)+Convert.ToDouble(arr2);
                        
                        string formatted = String.Format("{0}", passer);
                        Console.WriteLine("formatted: "+ formatted);
                        arr2 = ""; 
                        onClickUpdate(formatted,arr2,'+');
                        }*/
                    if(b == "=") { 
                       
                        return arr2; 
                        
                    } else {
                        Console.WriteLine("This is not a valid number or the Enter key please hit either input");
                        } 
                     
                    
                    
                } 
           
        }
        //string 1 creator
        while (operators == null){ 
            b  = Console.ReadLine(); 
            double num = 0; 
            bool canConvert = double.TryParse(b, out num);
            if (canConvert == true){
                arr = arr+num; 
            }   else    {                
                if(b == "+") { 
                    opp = '+';
                    return arr; 
                    } 
                else if (b == "-") {
                    opp = '-';
                    return arr;
                    }
                else if (b == "*") {
                 opp = '*';
                    return arr;
                    }
                else if (b == "/") {
                 opp = '/';
                    return arr;
                    }
                else if (b == ""){
                    return arr; 
                }                    
                else {
                Console.WriteLine("This is not a valid number or operation, please enter a number or operator");
                    }
                
                } 
                }
            return arr; 
        }
               

        public static void adda (string arr, string arr2)     
        { 
            Console.WriteLine("arr1: " + arr + " arr2: " + arr2); 
            double sum = Convert.ToDouble(arr) + Convert.ToDouble(arr2); 
            Console.WriteLine("Output + :" +sum); 
        }   
        public static void suba (string arr, string arr2)     
        {     
            Console.WriteLine("arr1: " + arr + " arr2: " + arr2); 
            double sum = Convert.ToDouble(arr) - Convert.ToDouble(arr2); 
            Console.WriteLine("Output - :" +sum); 
        }
        public static void diva (string arr, string arr2)     
        {
            Console.WriteLine("arr1: " + arr + " arr2: " + arr2); 
            double sum = Convert.ToDouble(arr) / Convert.ToDouble(arr2); 
            Console.WriteLine("Output / :" +sum); 
        }
        public static void multa (string arr, string arr2)    
        { 
            Console.WriteLine("arr1: " + arr + " arr2: " + arr2); 
            double sum = Convert.ToDouble(arr) * Convert.ToDouble(arr); 
            Console.WriteLine("Output * :" +sum); 
        }
    }
}

/*public static string onClickUpdate(string arr, string arr2, char? operators) { 
    String b; 
    
    // First loop to input first number and operator
    while (operators == null) { 
        b = Console.ReadLine(); 
        double num = 0; 
        bool canConvert = double.TryParse(b, out num);
        if (canConvert == true){
            arr = arr + num; 
        } else {                
            if(b == "+") { 
                return onClickUpdate(arr, "", '+');
            } else if (b == "-") {
                return onClickUpdate(arr, "", '-');
            } else if (b == "*") {
                return onClickUpdate(arr, "", '*');
            } else if (b == "/") {
                return onClickUpdate(arr, "", '/');
            } else if (b == "") {
                return arr; 
            } else {
                Console.WriteLine("This is not a valid number or operation, please enter a number or operator");
            }
        } 
    }
    
    // Second loop to input second number
    b = Console.ReadLine(); 
    double num2 = 0; 
    bool canConvert2 = double.TryParse(b, out num2);
    if (canConvert2 == true){
        if (operators == '+') {
            double result = Convert.ToDouble(arr) + num2;
            Console.WriteLine(result);
            return onClickUpdate(result.ToString(), "", null);
        } else if (operators == '-') {
            double result = Convert.ToDouble(arr) - num2;
            Console.WriteLine(result);
            return onClickUpdate(result.ToString(), "", null);
        } else if (operators == '*') {
            double result = Convert.ToDouble(arr) * num2;
            Console.WriteLine(result);
            return onClickUpdate(result.ToString(), "", null);
        } else if (operators == '/') {
            double result = Convert.ToDouble(arr) / num2;
            Console.WriteLine(result);
            return onClickUpdate(result.ToString(), "", null);
        } else {
            Console.WriteLine("Error: no operator selected");
            return arr;
        }
    } else if (b == "") {
        return arr;
    } else {
        Console.WriteLine("This is not a valid number, please enter a number or press Enter");
        return onClickUpdate(arr, "", operators);
    }  
}
*/