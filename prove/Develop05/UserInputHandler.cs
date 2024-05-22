public static class UserInputHandler {
    public static int GetIntNumbersFromUserInput(string questionToUser) {
        bool isInvalidInput = true;
        int number;
        do
        {
            Console.Write(questionToUser);
            string userInput = Console.ReadLine();
            
            if(!int.TryParse(userInput, out number)) {
                Console.WriteLine("Invalid input. Please try again.");
                isInvalidInput = true;
            } else {
                isInvalidInput = false;
            }

        } while (isInvalidInput);

        return number;
        
    }


    public static int GetIntNumbersFromUserInput(string questionToUser, int min, int max) {  


        bool isInvalidInput = true;
        int number;
        do
        {
            Console.Write(questionToUser);
            string userInput = Console.ReadLine();
            
            if(!int.TryParse(userInput, out number) || number < min || number > max) {
                Console.WriteLine("Invalid input. Please try again.");
                isInvalidInput = true;
            } else {
                isInvalidInput = false;
            }

        } while (isInvalidInput);

        return number;  


    }
}