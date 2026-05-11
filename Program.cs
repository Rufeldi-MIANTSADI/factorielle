namespace factorielle
{ 

class Program
    {
    static void Main(string[] args)
       {
         
        Console.WriteLine("Entrez un nombre de votre choix: ");
        
            if (int.TryParse(Console.ReadLine(), out int n))
            {             
                if(n < 0)

                {
                  Console.WriteLine("la factorielle n'existe pas pour les nombres negatifs.");
                  return;
                }
                long factorielle = 1;

                for(int i = 1; i <=n; i++)
                {
                 factorielle *= i;
                }

                Console.WriteLine("La factorielle de " + n + " est : " + factorielle);
           
            }
            else
            {
            Console.WriteLine("Veuillez entrer un nombre valide.");
            }
        }
    
    }  
}