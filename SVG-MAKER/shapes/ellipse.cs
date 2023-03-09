[Serializable]
class ellipse : shapes
{
    public string s = "Ellipse";
    public string getShape()
    {
        return s;
    }
    private string ID, fill, stroke;
    private int rx, ry, cx, cy, strokewidth;
    public ellipse()
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.rx = 10;
        this.ry = 15;
        this.cx = 10;
        this.cy = 10;
        this.stroke = "black";
        this.strokewidth = 10;
        this.fill = "blue";
    }

    public ellipse(int rx, int ry, int cx, int cy, string stroke, int strokewidth, string fill)
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.rx = rx;
        this.ry = ry;
        this.cx = cx;
        this.cy = cy;
        this.fill = fill;
        this.stroke = stroke;
        this.strokewidth = strokewidth;
    }

    public string getSVG()
    {
        return "<ellipse cx=\"" + this.cx + "\" " + "cy=\"" + this.cy + "\" " + "rx=\"" + this.rx + "\" " + "ry=\"" + this.ry + "\" " + " stroke=\"" + this.stroke + "\" stroke-width=\"" + this.strokewidth + "\" fill=\"" + this.fill + "\"/>\n";
    }

    public string getID()
    {
        return ID;
    }
}