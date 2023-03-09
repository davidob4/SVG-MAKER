[Serializable]
class line : shapes
{
    public string s = "Line";
    public string getShape()
    {
        return s;
    }
    private string ID, stroke;
    private int x1, y1, x2, y2, strokewidth;

    public line()
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.x1 = 10;
        this.y1 = 10;
        this.x2 = 30;
        this.y2 = 30;
        this.stroke = "black";
        this.strokewidth = 10;
    }

    public line(int x1, int y1, int x2, int y2, string stroke, int strokewidth)
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.stroke = stroke;
        this.strokewidth = strokewidth;
    }

    public int getx1()
    {
        return this.x1;
    }

    public int gety1()
    {
        return this.y1;
    }

    public int getx2()
    {
        return this.x2;
    }

    public int gety2()
    {
        return this.y2;
    }

    public string getSVG()
    {
        return "<line x1=\"" + this.x1 + "\" " + "y1=\"" + this.y1 + "\" " + "x2=\"" + this.x2 + "\" " + "y2=\"" + this.y2 + "\" " + "stroke=\"" + this.stroke + "\" stroke-width=\"" + this.strokewidth + "\"/>\n";
    }

    public string getID()
    {
        return ID;
    }
}