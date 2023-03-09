class cmlInterface
{
    private int pointer;
    private User user;
    public cmlInterface(Canvas canvas)
    {
        user = new User();
        FirstStep(canvas);
    }
    public void FirstStep(Canvas canvas)
    {
        Console.WriteLine();
        Console.WriteLine("Choose the command below \n");
        Console.WriteLine("1: Generate Random Shape");
        Console.WriteLine("2: Display current Canvas to Console");
        Console.WriteLine("3: Save current Canvas to File \n");

        Console.WriteLine("4: Add Shape");
        Console.WriteLine("5: Delete Shape");
        Console.WriteLine("6: Update Shape \n");

        Console.WriteLine("7: Undo");
        Console.WriteLine("8: Redo");

        Console.WriteLine("9: Exit");
        Console.Write("--> ");

        try
        {
            int num = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (num)
            {
                case 1:
                    Console.Clear();
                    user.addCommand(new AddRanShapeCommand(canvas));
                    Console.WriteLine("Added a random shape to the canvas!");
                    FirstStep(canvas);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(canvas.getSVG());
                    FirstStep(canvas);
                    break;
                case 3:
                    Console.Clear();
                    File.WriteAllTextAsync("files_SVG/SVGOUT.svg", canvas.getSVG());
                    Console.WriteLine("Saved to SCGOUT.svg");
                    FirstStep(canvas);
                    break;
                case 4:
                    Console.Clear();
                    user.addCommand(new AddShapeCommand(canvas, addShapeMenu(canvas)));
                    FirstStep(canvas);
                    break;
                case 5:
                    Console.Clear();
                    user.addCommand(new DeleteShapeCommand(canvas, deleteShapeMenu(canvas)));
                    FirstStep(canvas);
                    break;
                case 6:
                    Console.Clear();
                    user.addCommand(new UpdateCommand(canvas, updateShapeMenu(canvas), pointer));
                    FirstStep(canvas);
                    break;
                case 7:
                    Console.Clear();
                    user.undo();
                    FirstStep(canvas);
                    break;
                case 8:
                    Console.Clear();
                    user.redo();
                    FirstStep(canvas);
                    break;
                case 9:

                break;
            }
        }
        catch (Exception e)
        {
            Console.Clear();
            //Console.WriteLine(e);
            Console.WriteLine("Invalid Input! Please Input a number from the following selection");
            FirstStep(canvas);
        }
    }
    public shapes addShapeMenu(Canvas canvas)
    {
        Console.Clear();
        Console.WriteLine("Please input Which shape you would like to add \n");
        Console.WriteLine("1: Circle \n2: Rectangle \n3: Ellipse \n4: Line \n5: PolyLine \n6: PolyGon \n");
        Console.Write("--> ");
        int num = Int32.Parse(Console.ReadLine());
        try{
        switch (num)
        {
            case 1:
                string c = "Circle";
                Console.Clear();
                Console.WriteLine("Input Parameters");
                Console.Write("Radius: ");
                int rad = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate X: ");
                int cx = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate Y: ");
                int cy = Int32.Parse(Console.ReadLine());
                Console.Write("Stroke Colour: ");
                string stroke = Console.ReadLine();
                Console.Write("Stroke Width: ");
                int stw = Int32.Parse(Console.ReadLine());
                Console.Write("Fill Colour: ");
                string fill = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("New " + c + " added");
                return new circle(rad, cx, cy, stroke, stw, fill);
            case 2:
                c = "Rectangle";
                Console.Clear();
                Console.Write("Coordinate X: ");
                cx = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate Y: ");
                cy = Int32.Parse(Console.ReadLine());
                Console.Write("Width: ");
                int width = Int32.Parse(Console.ReadLine());
                Console.Write("Height: ");
                int height = Int32.Parse(Console.ReadLine());
                Console.Write("Stroke Colour: ");
                stroke = Console.ReadLine();
                Console.Write("Stroke Width: ");
                stw = Int32.Parse(Console.ReadLine());
                Console.Write("Fill Colour: ");
                fill = Console.ReadLine();
                Console.Clear();                
                Console.WriteLine("New " + c + " added");
                return new rectangle(cx, cy, width, height, stroke, stw, fill);
            case 3:
                c = "Ellipse";
                Console.Clear();
                Console.Write("Coordinate X: ");
                cx = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate Y: ");
                cy = Int32.Parse(Console.ReadLine());
                Console.Write("Horizontal Radius: ");
                int rx = Int32.Parse(Console.ReadLine());
                Console.Write("Vertical Radius: ");
                int ry = Int32.Parse(Console.ReadLine());
                Console.Write("Stroke Colour: ");
                stroke = Console.ReadLine();
                Console.Write("Stroke Width: ");
                stw = Int32.Parse(Console.ReadLine());
                Console.Write("Fill Colour: ");
                fill = Console.ReadLine();
                Console.Clear();                
                Console.WriteLine("New " + c + " added");
                return new ellipse(rx, ry, cx, cy, stroke, stw, fill);
            case 4:
                c = "Line";
                Console.Clear();
                Console.Write("Coordinate X (1): ");
                cx = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate Y (1): ");
                cy = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate X (2): ");
                int cx2 = Int32.Parse(Console.ReadLine());
                Console.Write("Coordinate Y (2): ");
                int cy2 = Int32.Parse(Console.ReadLine());
                Console.Write("Stroke Colour: ");
                stroke = Console.ReadLine();
                Console.Write("Stroke Width: ");
                stw = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("New " + c + " added");
                return new line(cx, cy, cx2, cy2, stroke, stw);
            case 5:
                c = "PolyLine";
                Console.Clear();
                List<line> l = new List<line>();
                Console.Write("Starting Coordinate X: ");
                cx = Int32.Parse(Console.ReadLine());
                Console.Write("Starting Coordinate Y: ");
                cy = Int32.Parse(Console.ReadLine());

                while (true)
                {
                    Console.Write("Next Coordinate X: ");
                    cx2 = Int32.Parse(Console.ReadLine());
                    Console.Write("Next Coordinate Y: ");
                    cy2 = Int32.Parse(Console.ReadLine());
                    line tempLine = new line(cx, cy, cx2, cy2, "black", 1);
                    l.Add(tempLine);
                    Console.WriteLine();
                    cx = cx2;
                    cy = cy2;

                    Console.Write("Input 1 to add another line or 2 to create the polyline: ");
                    if (Int32.Parse(Console.ReadLine()) == 2)
                    {
                        break;
                    }

                    Console.Clear();
                }
                Console.Clear();
                Console.Write("Stroke Colour: ");
                stroke = Console.ReadLine();
                Console.Write("Stroke Width: ");
                stw = Int32.Parse(Console.ReadLine());
                Console.WriteLine("New " + c + " added");
                return new polyLine(l, stroke, stw);
            case 6:
                c = "PolyGon";
                Console.Clear();
                List<line> l2 = new List<line>();
                Console.Write("Starting Coordinate X: ");
                cx = Int32.Parse(Console.ReadLine());
                Console.Write("Starting Coordinate Y: ");
                cy = Int32.Parse(Console.ReadLine());

                int startx = cx;
                int starty = cy;
                line tempLine2;

                while (true)
                {
                    Console.Write("Next Coordinate X: ");
                    cx2 = Int32.Parse(Console.ReadLine());
                    Console.Write("Next Coordinate Y: ");
                    cy2 = Int32.Parse(Console.ReadLine());
                    tempLine2 = new line(cx, cy, cx2, cy2, "black", 1);
                    l2.Add(tempLine2);
                    Console.WriteLine();
                    cx = cx2;
                    cy = cy2;

                    Console.Write("Input 1 to add another line or 2 to create the polyline: ");
                    if (Int32.Parse(Console.ReadLine()) == 2)
                    {
                        break;
                    }

                    Console.Clear();
                }
                tempLine2 = new line(cx2, cy2, startx, starty, "black", 1);
                l2.Add(tempLine2);
                Console.Clear();
                Console.Write("Stroke Colour: ");
                stroke = Console.ReadLine();
                Console.Write("Stroke Width: ");
                stw = Int32.Parse(Console.ReadLine());
                Console.Write("Fill Colour: ");
                fill = Console.ReadLine();
                Console.WriteLine("New " + c + " added");
                return new polyGon(l2, stroke, stw, fill);
            }
        }catch(Exception e){
            Console.WriteLine("Wrong Selection: Please input valid selection");
            addShapeMenu(canvas);
        }
        return new circle();
    }
    public int deleteShapeMenu(Canvas canvas){
        Console.WriteLine("Choose shape for Deletion");
        for (int i = 0; i < canvas.elsLength(); i++)
        {
            Console.WriteLine((i + 1) + ": " + canvas.elsReturn(i).getShape());
        }
        Console.Write("--> ");
        pointer = Int32.Parse(Console.ReadLine());
        if(pointer > canvas.elsLength() || pointer < 1){
            Console.Clear();
            Console.WriteLine("Wrong Input");
            deleteShapeMenu(canvas);
        }
        Console.Clear();
        return pointer;
    }
    public shapes updateShapeMenu(Canvas canvas)
    {
        Console.WriteLine("Choose shape to update");
        for (int i = 0; i < canvas.elsLength(); i++)
        {
            Console.WriteLine((i + 1) + ": " + canvas.elsReturn(i).getShape());
        }
        Console.Write("--> ");
        pointer = Int32.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        shapes tempS = addShapeMenu(canvas);
        return tempS;
    }
}