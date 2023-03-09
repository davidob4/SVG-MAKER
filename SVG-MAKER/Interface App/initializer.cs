public class initializer{
    public initializer(){
        Console.Clear();
        Console.WriteLine("WELCOME TO THE SVG MAKER & EDITOR");
        Console.WriteLine("Please Input the Canvas Size");
        stepOne(); 
    }
    public void stepOne(){
        try{
        Console.Write("X value: ");
        int CanvasX = Int32.Parse(Console.ReadLine());
        if(CanvasX < 100){
            Console.Clear();
            Console.WriteLine("Canvas width and height must be greater than 100 in size");
            stepOne();
        }
        Console.Write("Y value: ");
        int CanvasY = Int32.Parse(Console.ReadLine());
        if(CanvasY < 100){
            Console.Clear();
            Console.WriteLine("Canvas width and height must be greater than 100 in size");
            stepOne();
        }
        Canvas canvas = new Canvas(CanvasX, CanvasY);
        Console.Clear();
        new cmlInterface(canvas);
        }catch(Exception e){
            Console.Clear();
            Console.WriteLine("Wrong Input");
            stepOne();
        }
    }
}