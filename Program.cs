using System.Runtime.InteropServices;

namespace FizzBuzz {
    public class FizzBuzz {
        public static void Main() {
            Console.WriteLine("Welcome to FizzBuzz");
            string message = "";

            for(int i = 1; i <= 255; i++) {
                message = "";
                message = AppendMessageBasedOnRules(message,i);

                if(string.IsNullOrEmpty(message))
                    Console.WriteLine(i);                       
                else
                    Console.WriteLine(message);                    
            }    
        }
        // Function to append Fizz and Buzz based on rules
        public static string AppendMessageBasedOnRules(string message,int number) {   

            if(number % 3 == 0)
                message += "Fizz";

            if(number % 5 == 0)
                message += "Buzz";

            if(number % 7 == 0)
                message += "Bang";

            if(number % 11 == 0) {
                message = "Bong";
            }

            if(number % 13 == 0) {
                message = "Fezz" + message;  
                message = message.Contains("FizzBuzz") ?  message.Replace("FezzFizzBuzz","FizzFezzBuzz") : message;
            }
            
            if(number % 17 == 0) {                    
                message = ReverseMessageString(message);
            }     

            return message;
        }

        //Reverse the order of messages for number divided by 17
        public static string ReverseMessageString(string message) {
            string reversedMessage = "";
            for (int i = 0; i < message.Length; i += 4) {
                reversedMessage = string.Concat(message.Substring(i,4), reversedMessage);
            }

        return reversedMessage;
        }
    }        
}