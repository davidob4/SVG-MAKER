class ranShape{

public static shapes genRanShape(int CanvasX, int CanvasY)
    {
        var rand = new Random();
        int randomShape = rand.Next(5);
        string[] colours = { "black", "white", "blue", "green", "blue", "purple" };
        int RanRad = rand.Next(10, 51);
        int ranCX = rand.Next(60, CanvasX - 60);
        int ranCY = rand.Next(60, CanvasY - 60);
        int strokeW = rand.Next(2, 6);
        string stroke = colours[rand.Next(colours.Length)];
        string fill = colours[rand.Next(colours.Length)];
        int RandWidth = rand.Next(10, 61);
        int RandLength = rand.Next(30, 151);
        int RandRX = rand.Next(10, 61);
        int RandRY = rand.Next(30, 81);

        shapes s = new circle();

        switch (randomShape)
        {
            case 0:
                s = new circle(RanRad, ranCX, ranCY, stroke, strokeW, fill);
                break;
            case 1:
                ranCX += 140;
                ranCY += 140;
                s = new rectangle(ranCX, ranCY, RandWidth, RandLength, stroke, strokeW, fill);
                break;
            case 2:
                ranCX += 140;
                ranCY += 140;
                s = new ellipse(RandRX, RandRY, ranCX, ranCY, stroke, strokeW, fill);
                break;
            case 3:
                ranCX = rand.Next(20, CanvasX - 20);
                ranCY = rand.Next(20, CanvasY - 20);
                RandRX = rand.Next(20, CanvasX - 20);
                RandRY = rand.Next(20, CanvasY - 20);
                s = new line(ranCX, ranCY, RandRX, RandRY, stroke, strokeW);
                break;
            case 4:
                int noOfLines = rand.Next(3, 7);
                ranCX = rand.Next(20, CanvasX - 20);
                ranCY = rand.Next(20, CanvasY - 20);
                RandRX = rand.Next(20, CanvasX - 20);
                RandRY = rand.Next(20, CanvasY - 20);
                List<line> l = new List<line>();
                line tempLine = new line(ranCX, ranCY, RandRX, RandRY, stroke, strokeW);
                l.Add(tempLine);

                for (int i = 1; i < noOfLines; i++)
                {
                    RandRX = rand.Next(20, CanvasX - 20);
                    RandRY = rand.Next(20, CanvasY - 20);
                    line tLine = new line(tempLine.getx2(), tempLine.gety2(), RandRX, RandRY, stroke, strokeW);
                    l.Add(tLine);
                    tempLine = tLine;
                }

                s = new polyLine(l, stroke, strokeW);
                break;
            case 5:
                int noOfSides = rand.Next(3, 7);
                ranCX = rand.Next(20, CanvasX - 20);
                ranCY = rand.Next(20, CanvasY - 20);
                RandRX = rand.Next(20, CanvasX - 20);
                RandRY = rand.Next(20, CanvasY - 20);
                List<line> l1 = new List<line>();
                line tempLine1 = new line(ranCX, ranCY, RandRX, RandRY, stroke, strokeW);
                s = new polyGon();
                break;
        }
        return s;
    }
}