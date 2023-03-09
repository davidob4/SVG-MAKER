[Serializable]
class circle : shapes
{
    private string s = "Circle";

    public string getShape()
    {
        return s;
    }
    private int r, cx, cy, strokewidth;
    private string ID, stroke, fill;
    public circle()
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.r = 1;
        this.cx = 10;
        this.cy = 10;
        this.stroke = "black";
        this.strokewidth = 10;
        this.fill = "blue";
    }

    public circle(int rad, int cx, int cy, string stroke, int strokewidth, string fill)
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.fill = fill;
        this.stroke = stroke;
        this.strokewidth = strokewidth;
        this.r = rad;
        this.cx = cx;
        this.cy = cy;
    }

    public string getSVG()
    {
        return "<circle cx=\"" + this.cx + "\" " + "cy=\"" + this.cy + "\" " + "r=\"" + this.r + "\"" + " stroke=\"" + this.stroke + "\" stroke-width=\"" + this.strokewidth + "\" fill=\"" + this.fill + "\"/>\n";
    }

    public string getID()
    {
        return ID;
    }
}