namespace FuncExplanation
{
    internal class Program
    {

        static List<string> nombres = new List<string>
        {
            "Juan", "Pedro", "Maria", "Ana", "Luis", "Carlos", "Laura", "Sofia",
            "Miguel", "Lucia", "Javier", "Elena", "Diego", "Carmen", "Pablo", "Marta",
            "Alejandro", "Paula", "Daniel", "Isabel", "David", "Cristina", "Sergio", "Patricia",
            "Jorge", "Raquel", "Alberto", "Beatriz", "Fernando", "Silvia", "Manuel", "Rosa",
            "Antonio", "Teresa", "Francisco", "Claudia", "Rafael", "Natalia", "Adrian", "Victoria",
            "Marcos", "Andrea", "Mario", "Sara", "Ivan", "Julia", "Oscar", "Alicia",
            "Ruben", "Eva", "Gabriel", "Diana", "Hugo", "Nuria", "Samuel", "Irene",
            "Nicolas", "Alba", "Emilio", "Aitana", "Andres", "Valeria", "Enrique", "Carolina",
            "Roberto", "Lorena", "Eduardo", "Monica", "Ricardo", "Sandra", "Guillermo", "Noelia",
            "Victor", "Esther", "Tomas", "Ines", "Felipe", "Pilar", "Jaime", "Amelia"
        };



        static int ContarNombres(string letra, Func<string, bool> filtro)
        {
            nombres = nombres.Where(filtro).ToList();

            foreach (var nombre in nombres)
            {
                imprimir(nombre);
            }

            return nombres.Count;

        }

            static Action<string> imprimir = x => Console.WriteLine(x);
        static void Main(string[] args)
        {
            Func<string,string, int> queUsaremos;

            //queUsaremos = ContarNombresSegundaConLetra;


          //  queUsaremos  = (y,d) => nombres.Where(x=> x.Contains(y)).Count();




            Console.WriteLine(ContarNombres("a", x => x.Contains("a")));
            Console.WriteLine(ContarNombres("a", x => x.StartsWith("a")));
            Console.WriteLine(ContarNombres("a", x => x.EndsWith("a")));
            

        }
    }
}
