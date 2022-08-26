class Program{
    static void Main(string[] args){
        Console.Write("Name : ");
        Console.ReadLine();
        Console.Write("Score : ");
        int score = int.Parse(Console.ReadLine());
        if(score >= 80){
            Console.WriteLine("Grade : A");
        }
        else if(score < 80 && score >= 75){
            Console.WriteLine("Grade : B+");
        
        }
        else if(score < 75 && score >= 70){
            Console.WriteLine("Grade : B");
        }
        else if(score < 70 && score >= 65){
            Console.WriteLine("Grade : C+");
        }
        else if(score < 65 && score >= 60){
            Console.WriteLine("Grade : C");
        }
        else if(score < 60 && score >= 55){
            Console.WriteLine("Grade : D+");
        }
        else if(score < 55 && score >= 50){
            Console.WriteLine("Grade : D");
        }
        else if(score < 50){
            Console.WriteLine("Grade : F");
        }
        

    }
}